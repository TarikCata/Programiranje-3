using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200252
{
    public partial class frmPretraga : Form
    {
        private KonekcijaNaBazu db = DLWMSdb.Baza;
        private List<PredmetiStudenti> sviPredmetiStudenti = new List<PredmetiStudenti>();
        private List<string> samoglasnici = new List<string> { "a", "e", "i", "o", "u" };
        private List<string> znakovi = new List<string> { "!", "?", "*", "<", ">" };
        public frmPretraga()
        {
            InitializeComponent();
            dgvPredmetiStudenti.AutoGenerateColumns = false;
            PreuzmiPodatke();
        }
        private void PreuzmiPodatke()
        {
            var PredmetiStudenti = db.StudentiPredmeti.ToList();
            foreach (var predmetS in PredmetiStudenti)
            {
                var predmetStudent = new PredmetiStudenti();
                predmetStudent.Student = predmetS.Student;
                predmetStudent.Predmet = string.Join(";", PredmetiStudenti.Where(x => x.Student.Id == predmetStudent.Student.Id).Select(x => x.Predmet.Naziv));
                predmetStudent.BrojPolezenih = PredmetiStudenti.Where(x => x.Student.Id == predmetS.Student.Id).Select(x => x.Predmet).ToList().Count;
                predmetStudent.Prosjek = PredmetiStudenti.Where(x => x.Student.Id == predmetS.Student.Id).Average(x => x.Ocjena);
                sviPredmetiStudenti.Add(predmetStudent);
            }
        }
        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void UcitajPodatke(List<PredmetiStudenti> s = null)
        {
            dgvPredmetiStudenti.DataSource = null;
            dgvPredmetiStudenti.DataSource = s ?? sviPredmetiStudenti;
            if(s == null)
            {
                lblProsjek.Text = $"Prosjek ocjena : {sviPredmetiStudenti.Average(x => x.Prosjek)}";
                lblNajbolji.Text = $"Najveci prosjek ostvario: {Najbolji(sviPredmetiStudenti)}";
            }
            else
            {
                lblProsjek.Text = $"Prosjek ocjena : {s.Average(x => x.Prosjek)}";
                lblNajbolji.Text = $"Najveci prosjek ostvario: {Najbolji(s)}";
            }
        }
        Student Najbolji(List<PredmetiStudenti> s)
        {
            double suma = 0;
            Student student = null;
            foreach (var x in s)
                if (x.Prosjek > suma)
                {
                    suma = x.Prosjek;
                    student = x.Student;
                }
            if (student != null)
                return student;
            return null; 
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var txt = txtPretraga.Text.ToLower();
            var lista = new List<PredmetiStudenti>();
            foreach(var x in sviPredmetiStudenti)
                if(x.Student.Ime.ToLower().Contains(txt) || x.Student.Prezime.ToLower().Contains(txt))
                    lista.Add(x);
            UcitajPodatke(lista);
        }
        private void dgvPredmetiStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                this.Hide();
                var obj = dgvPredmetiStudenti.CurrentRow.DataBoundItem as PredmetiStudenti;
                var std = obj.Student;
                new frmScanIspitaBrojIndeksa(std).ShowDialog();
                this.Show();
            }
        }
        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
                return;
            int b1 = 0, b2 = 0,b3 = 0;
            var txt = textBox1.Text.ToLower();
            Action action = () => UcitajLbl(b1, b2, b3);
            await Task.Run(() =>
            { 
                b1 = txt.Where(x => samoglasnici.Contains(x.ToString())).Count();
                b3 = txt.Where(x => znakovi.Contains(x.ToString())).Count();
                b2 = txt.Length - b1 - b3;
                BeginInvoke(action);
            });
        }
        private void UcitajLbl(int b1, int b2, int b3)
        {
            lblSamoglasnici.Text = $"Broj samoglasnika: {b1}";
            lblSuglasnici.Text = $"Broj suglasnika: {b2}";
            lblZnakovi.Text = $"Broj znakova: {b3}";
        }
    }
}
