using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        private List<string> GodineStudija = new List<string> { "Sve", "1", "2", "3", };
        private List<string> Aktivnosti = new List<string> { "Svi", "Aktivan", "Neaktivan" };
        List<Student> studenit = new List<Student>();
        string imePrezime;
        int godinaStudija;
        bool aktivan;
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            cmbGodineStudija.DataSource = GodineStudija;
            cmbAktivnosti.DataSource = Aktivnosti;
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima()
        {
            if (!validiraj())
                return;
            else
            {
                if (cmbAktivnosti.SelectedIndex == 0 && cmbGodineStudija.SelectedIndex == 0)
                {
                   studenit = _baza.Studenti.Where(x => x.Ime.ToLower().Contains(imePrezime) || x.Prezime.ToLower().Contains(imePrezime)).ToList();
                    UcitajProsjekPrebroj(studenit);
                }
                else
                {
                   studenit = _baza.Studenti.Where(x =>
                   x.Aktivan == aktivan &&  
                   x.GodinaStudija == godinaStudija &&
                   (x.Ime.ToLower().Contains(imePrezime) || x.Prezime.ToLower().Contains(imePrezime))).ToList();
                    UcitajProsjekPrebroj(studenit);
                }

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenit;
            }
        }

        private bool validiraj()
        {
            var err = new ErrorProvider();
            if (string.IsNullOrEmpty(txtPretraga.Text))
            {
                err.SetError(txtPretraga, "Ovo polje je obavezno!");
                return false;
            }
            err.Clear();
            return true;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            imePrezime = txtPretraga.Text.ToLower();
            UcitajPodatkeOStudentima();
        }
        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGodineStudija.SelectedIndex > 0)
            {
                godinaStudija = Convert.ToInt32(cmbGodineStudija.Text);
                UcitajPodatkeOStudentima();
            }
        }
        private void cmbAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAktivnosti.SelectedIndex > 0)
            {
                if (cmbAktivnosti.SelectedIndex == 1)
                    aktivan = true;
                if(cmbAktivnosti.SelectedIndex == 2)
                    aktivan = false;
                UcitajPodatkeOStudentima();
            }
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }
        private void UcitajProsjekPrebroj(List<Student> students)
        {
            if (students.Count == 0)
            {
                lblBrojStudenata.Text = "Broj studenata: 0";
                lblProsjek.Text = "Prosjecna ocjena: 0";
                return;
            }
            double sum = 0;
            int brojac = 0;
            foreach (var student in students)
            {
                foreach (var predmet in student.Uspjeh)
                {
                    sum += predmet.Ocjena;
                    brojac++;
                }
            }
            lblBrojStudenata.Text = $"Broj studenata: {students.Count}";
            lblProsjek.Text = $"Prosjecna ocjena: {Math.Round(sum / brojac, 2)}";
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6)
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmIzvjestaji(dgvStudenti.DataSource as List<Student>).ShowDialog();
            this.Show();
        }
    }
}
