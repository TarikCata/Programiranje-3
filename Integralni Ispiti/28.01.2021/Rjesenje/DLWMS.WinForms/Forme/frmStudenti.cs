using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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

        List<string> godine = new List<string> { "Sve", "1", "2", "3" };

        List<string> aktivnosti = new List<string> { "Svi", "Aktivan", "Neaktivan"};

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            IzracunajProsjekPrebrojStudente();
            cmbGodineStudija.DataSource = godine;
            cmbAktivnosti.DataSource = aktivnosti;
        }

        private void IzracunajProsjekPrebrojStudente(List<Student> students = null)
        {
            var lista = students ?? _baza.Studenti.ToList();
            lblBrojStudenata.Text = $"Broj Studenta: {lista.Count.ToString()}";
            lblProsjecnaOcjena.Text = $"Prosjek ocjena: {Suma(lista).ToString()}";
        }

        private double Suma(List<Student> students)
        {
            double s = 0;
            int brojac = 0;
            foreach (var student in students)
            {
                foreach (var predmet in student.PolozeniPredmeti)
                {
                    s += predmet.Ocjena;
                    brojac++;
                }
            }
            return Math.Round((s/brojac),2);
        }
        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            try
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException}");
            }
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
        private bool PretragaStudenata(Student s)
        {
            return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
                    || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text.ToLower();

            UcitajPodatkeOStudentima(_baza.Studenti
              .Where(s => s.Ime.ToLower().Contains(filter)
                  || s.Prezime.ToLower().Contains(filter)).ToList());
        }

        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!provider(txtPretraga))
                return;
            if (cmbGodineStudija.Text == "Sve")
                UcitajPodatkeOStudentima();
            else
            {
                var godina = int.Parse(cmbGodineStudija.Text);
                pretragaGodina(godina);
            }
        }

        private void pretragaGodina(int godina)
        {
            var lista = _baza.Studenti.Where(x => x.GodinaStudija == godina).ToList();
            UcitajPodatkeOStudentima(lista);
            IzracunajProsjekPrebrojStudente(lista);
        }

        private void cmbAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!provider(txtPretraga))
                return;
            if (cmbAktivnosti.Text == "Svi")
                UcitajPodatkeOStudentima();
            else
            {
                if (cmbAktivnosti.Text == "Aktivan")
                    ucitajCMBAktivnosti(true);
                if (cmbAktivnosti.Text == "Neaktivan")
                    ucitajCMBAktivnosti(false);
            }
        }

        private void ucitajCMBAktivnosti(bool tip)
        {
            var list = _baza.Studenti.Where(x => x.Aktivan == tip).ToList();
            UcitajPodatkeOStudentima(list);
            IzracunajProsjekPrebrojStudente(list);
        }

        private bool provider(Control control)
        {
            var err = new ErrorProvider();
            if(control is TextBox)
            {
                if(control.Text == string.Empty)
                {
                    err.SetError(control, "Neka poruka");
                    return false;
                }
            }
            err.Clear();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudentiPotvrde frmStudentiPotvrde = new frmStudentiPotvrde();
            frmStudentiPotvrde.ShowDialog();
        }
    }
}
