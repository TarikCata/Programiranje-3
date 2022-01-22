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
        List<string> ocjene = new List<string> { "6", "7", "8", "9", "10" };
        List<string> operatori = new List<string>() { ">", "<", "<=", ">=", "="};
        DateTime DatumDo;
        DateTime DatumOd;
        string Operator;
        int Ocjena;
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            cmbOcjene.DataSource = ocjene;
            cmbOperatori.DataSource = operatori;
            DatumOd = dtpOd.Value;
            DatumDo = dtpDo.Value;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima()
        {
            try
            {
                var studentiPredmeti = _baza.StudentiPredmeti.ToList();

                var poDatumu = studentiPredmeti.Where(x => x.Datum >= DatumOd && x.Datum <= DatumDo).ToList();

                var studentiPredmetiFiltrirno = new List<StudentiPredmeti>();
                if(Operator == "=")
                    studentiPredmetiFiltrirno = poDatumu.Where(x => x.Ocjena == Ocjena).ToList();
                else if(Operator == "<")
                    studentiPredmetiFiltrirno = poDatumu.Where(x => x.Ocjena < Ocjena).ToList();
                else if (Operator == ">")
                    studentiPredmetiFiltrirno = poDatumu.Where(x => x.Ocjena > Ocjena).ToList();
                else if (Operator == "<=")
                    studentiPredmetiFiltrirno = poDatumu.Where(x => x.Ocjena <= Ocjena).ToList();
                else if (Operator == ">=")
                    studentiPredmetiFiltrirno = poDatumu.Where(x => x.Ocjena >= Ocjena).ToList();

                if(studentiPredmetiFiltrirno.Count > 0)
                {
                    var studenti = studentiPredmetiFiltrirno.Select(x => x.Student).ToList();
                    ProsjekPrebroj(studenti);
                    dgvStudenti.DataSource = null;
                    dgvStudenti.DataSource = studenti;
                }
                else
                {
                    dgvStudenti.DataSource = null;
                    lblBrojStudenata.Text = $"Broj studenata: 0";
                    lblProsjek.Text = $"Prosjek ocjena: 0";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } 
        }

        private void ProsjekPrebroj(List<Student> studenti)
        {
            double sum = 0;
            foreach (var student in studenti)
            {
                sum = _baza.StudentiPredmeti.Where(x => x.Student.Id == student.Id).Average(x => x.Ocjena);
            }
            lblBrojStudenata.Text = $"Broj studenata: {studenti.Count}";
            lblProsjek.Text = $"Prosjek ocjena: {sum}";
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            DatumOd = dtpOd.Value;
            UcitajPodatkeOStudentima();
        }
        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            DatumDo = dtpDo.Value;
            UcitajPodatkeOStudentima();
        }
        private void cmbOperatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operator = cmbOperatori.Text;
            UcitajPodatkeOStudentima();
        }
        private void cmbOcjene_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ocjena = Convert.ToInt32(cmbOcjene.Text);
            UcitajPodatkeOStudentima();
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

                //UcitajPodatkeOStudentima(DatumOd, DatumDo);
            }
        }

    }
}
