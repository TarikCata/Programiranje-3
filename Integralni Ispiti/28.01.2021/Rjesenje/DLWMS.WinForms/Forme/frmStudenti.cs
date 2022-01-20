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
        bool aktivan = false;
        int godinaStudija = 0;
        
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            cmbGodineStudija.DataSource = GodineStudija;
            cmbAktivnosti.DataSource = Aktivnosti;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima("svi");
        }

        private void UcitajPodatkeOStudentima(string svi)
        {
            dgvStudenti.DataSource = null;
            var lista = new List<Student>();

            if (svi == "svi")
            {
                dgvStudenti.DataSource = _baza.Studenti.ToList();
                UcitajProsjekPrebroj(_baza.Studenti.ToList());
            }
            if (cmbGodineStudija.SelectedIndex > 0 && cmbAktivnosti.SelectedIndex > 0)
            {
                lista = _baza.Studenti.Where(x => x.GodinaStudija == godinaStudija && x.Aktivan == aktivan).ToList();
                dgvStudenti.DataSource = lista;
                UcitajProsjekPrebroj(lista);
                return;
            }
            if (cmbGodineStudija.SelectedIndex > 0 && cmbAktivnosti.SelectedIndex == 0)
            {
                lista = _baza.Studenti.Where(x => x.GodinaStudija == godinaStudija).ToList();
                dgvStudenti.DataSource = lista;
                UcitajProsjekPrebroj(lista);
                return;
            }
            if (cmbGodineStudija.SelectedIndex == 0 && cmbAktivnosti.SelectedIndex > 0)
            {
                lista = _baza.Studenti.Where(x => x.Aktivan == aktivan).ToList();
                dgvStudenti.DataSource = lista;
                UcitajProsjekPrebroj(lista);
                return;
            }
        }

        private bool validiraj(string text)
        {
            var err = new ErrorProvider();
            if (string.IsNullOrEmpty(text))
            {
                err.SetError(txtPretraga, "Ovo polje je obavezno!");
                return false;
            }
            err.Clear();
            return true;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            //filter = txtPretraga.Text.ToLower();
            //UcitajPodatkeOStudentima(string.Empty);
        }
        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGodineStudija.SelectedIndex == 0)
            {
                UcitajPodatkeOStudentima("svi");
                return;
            }
            godinaStudija = cmbGodineStudija.SelectedIndex;
            if (validiraj(txtPretraga.Text))
                UcitajPodatkeOStudentima(string.Empty);
        }
        private void cmbAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAktivnosti.SelectedIndex == 0)
            {
                UcitajPodatkeOStudentima("svi");
                return;
            }
            if(validiraj(txtPretraga.Text))
            {
                if (cmbAktivnosti.Text == "Aktivan")
                    aktivan = true;
                if (cmbAktivnosti.Text == "Neaktivan")
                    aktivan = false;
                UcitajPodatkeOStudentima(string.Empty);
            }
        }
       
        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima("svi");
        }
        private void UcitajProsjekPrebroj(List<Student> students)
        {
            if(students.Count == 0)
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

                UcitajPodatkeOStudentima("svi");
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
