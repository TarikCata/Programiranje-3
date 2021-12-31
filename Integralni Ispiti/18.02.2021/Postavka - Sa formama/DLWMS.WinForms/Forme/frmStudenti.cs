using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB180207;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza; 
        private List<int> ocjene = new List<int>() { 6,7,8,9,10};
        private List<string> poredjenja = new List<string>() { "<", ">", "=", "<=", ">=" };
        DateTime DateTimeOd;
        DateTime DateTimeDo;
        
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            cmbOcjena.DataSource = ocjene;
            cmbOperator.DataSource = poredjenja;
        }
    
        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();
            if(studenti != null)    
            {
                prebrojIprosjek(studenti);
            }
            else
            {
                prebrojIprosjek(_baza.Studenti.ToList());
            }
        }

        private void prebrojIprosjek(List<Student> studenti)
        {
            var studentiPredmeti = _baza.StudentiPredmeti.ToList();
            double sum = 0;
            int br = 0;
            
            lbl_prosjecnaocjena.Text = $"Prosjecna ocjena : {Math.Round(sum / br, 2)}"; 
            lbl_brojstudenta.Text = $"Broj studenata: {studenti.Count}";
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
        private void cmbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtriraj();
        }
        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtriraj();
        }

        private void filtriraj()
        {
            if(validiraj())
            {
                var d1 = dtpOD.Value;
                var d2 = dtpDO.Value;
                string op = cmbOperator.SelectedItem.ToString();
                var ocjena = int.Parse(cmbOcjena.SelectedItem.ToString());

                var studentiPredmeti = _baza.StudentiPredmeti.ToList();

                var poDatumu = studentiPredmeti.Where(x => x.Datum >= d1 && x.Datum <= d2).ToList();

                var poDatumuIOcjeni = filterOcjenaDatum(poDatumu, op, ocjena);

                var studenti = poDatumuIOcjeni.Select(x => x.Student.Id).ToList();

                var novaLista = _baza.Studenti.Where(x => studenti.Contains(x.Id)).ToList();

                UcitajPodatkeOStudentima(novaLista);
            }
        }
        private List<StudentiPredmeti> filterOcjenaDatum(List<StudentiPredmeti> filterPoDatumu, string operat, int ocjena)
        {

            if(operat == "<")
                filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena < ocjena).ToList();
            else
                if(operat == ">")
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena > ocjena).ToList();
            else
                if (operat == "=")
                filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena == ocjena).ToList();
            else
                if (operat == ">=")
                filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena >= ocjena).ToList();
            else
                if (operat == "<=")
                filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena <= ocjena).ToList();


            return filterPoDatumu;
        }
        private bool validiraj()
        {
            var err = new ErrorProvider();
            if(cmbOcjena.SelectedIndex < 0)
            {
                err.SetError(cmbOcjena, "Obaveznooo");
                return false;
            }
            if (cmbOperator.SelectedIndex < 0)
            {
                err.SetError(cmbOperator, "Obaveznooo");
                return false;
            }
            err.Clear();
            return true;
        }

        private void btnCovid_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCovidTestIB180207().ShowDialog();
            this.Show();
        }

    }
}
