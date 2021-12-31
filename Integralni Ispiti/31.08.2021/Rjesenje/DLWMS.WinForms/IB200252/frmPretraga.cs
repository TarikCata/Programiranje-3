using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200252
{
    public partial class frmPretraga : Form
    {
        private KonekcijaNaBazu db = DLWMSdb.Baza;
        private List<StudentiPolozeni> studentiPolozeni = new List<StudentiPolozeni>();

        private List<string> samoglasnici = new List<string>() { "a","e","i","o","u"};
        private List<string> znakovi = new List<string> { "?", "!", "<", ">", "*" };
        public frmPretraga()
        {
            InitializeComponent();
            dgvStdPredmeti.AutoGenerateColumns = false;
            textBox1.MaxLength = 500;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke(List<StudentiPolozeni> lista = null)
        {
            try
            {
                dgvStdPredmeti.DataSource = null;
                dgvStdPredmeti.DataSource = lista ?? Svi();
                if (lista != null)
                {
                    prosjekPredmeta(lista);
                    najboljiStudent(lista);
                }
                else
                {
                    prosjekPredmeta(Svi());
                    najboljiStudent(Svi());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void najboljiStudent(List<StudentiPolozeni> lista)
        {
            if(lista.Count <= 0)
            {
                lblNajboljiProsjek.Text = $"Najveci prosjek ostvario: <NOT-SET>";
                return;
            }
            int polPos = 0;
            double sum = 0;
            for (int i = 0; i < lista.Count; i++)
                if(lista[i].Prosjek > sum)
                {
                    polPos=i;
                    sum = lista[i].Prosjek;
                }
            lblNajboljiProsjek.Text = $"Najveci prosjek ostvario: {lista[polPos]}";
        }

        private void prosjekPredmeta(List<StudentiPolozeni> studentiPolozenis)
        {
            if (studentiPolozenis.Count <= 0)
            {
                lblProsej.Text = $"Prosjek prikazanih ocjena:0";
                return;
            }
            double sum = 0;
            foreach (var obj in studentiPolozenis)
                sum += obj.Prosjek;
            lblProsej.Text = $"Prosjek prikazanih ocjena: {Math.Round(sum / studentiPolozenis.Count, 2)}";
        }

        private List<StudentiPolozeni> Svi()
        {
            var sviStudenit = db.StudentiPredmeti.ToList().Select(x => x.Student).ToList();
            foreach (var student in sviStudenit)
            {
                studentiPolozeni.Add(new StudentiPolozeni()
                {
                    Student = student,
                    _Predmet = string.Join(";", db.StudentiPredmeti.ToList().Where(x => x.Student.Id == student.Id).Select(x => x.Predmet.Naziv).ToList()),
                    BrojPolozenih = db.StudentiPredmeti.ToList().Where(x => x.Student.Id == student.Id).ToList().Count,
                    Prosjek = db.StudentiPredmeti.ToList().Where(x => x.Student.Id == student.Id).Average(x => x.Ocjena),
                });
            }
            return studentiPolozeni;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var txt = txtPretraga.Text.ToLower();
            var novaLista = new List<StudentiPolozeni>();
            var sviStudenit = db.StudentiPredmeti.
                Where(x => x.Student.Ime.ToLower().Contains(txt)
                || x.Student.Prezime.ToLower().Contains(txt))
                .ToList().Select(x => x.Student).ToList();
            foreach (var s in sviStudenit)
            {
                novaLista.Add(new StudentiPolozeni()
                {
                    Student = s,
                    _Predmet = string.Join(";", db.StudentiPredmeti.ToList().Where(x => x.Student.Id == s.Id).Select(x => x.Predmet.Naziv).ToList()),
                    BrojPolozenih = db.StudentiPredmeti.ToList().Where(x => x.Student.Id == s.Id).ToList().Count,
                    Prosjek = db.StudentiPredmeti.ToList().Where(x => x.Student.Id == s.Id).Average(x => x.Ocjena),
                });
            }
            UcitajPodatke(novaLista);
        }

        private void dgvStdPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == 4)
            {
                var obj = dgvStdPredmeti.CurrentRow.DataBoundItem as StudentiPolozeni;
                var std = obj.Student;
                this.Hide();
                new frmKoriscniciIspitiScan(std).ShowDialog();
            }
            this.Show();
        }
        
        
        async private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                return;
            var txt = textBox1.Text.ToLower();
            int brojac1 = 0, brojac2 = 0, brojac3 = 0;
            int l1 = samoglasnici.Count;
            await Task.Run(() =>
            {

                brojac1 = txt.Where(x => samoglasnici.Contains(x.ToString())).Count();
                brojac2 = txt.Where(x => znakovi.Contains(x.ToString())).Count();
                brojac3 = txt.Length - brojac1 - brojac2;
                Action action = () => ucitajLbl(brojac1,brojac2,brojac3);
                BeginInvoke(action);
            });
        }

        private void ucitajLbl(int brojac1, int brojac2, int brojac3)
        {
            lblSuglasnici.Text = $"Broj samoglasnika {brojac1}";
            label2.Text = $"Broj suglasnika {brojac3}";
            lblZnakovi.Text = $"Broj znakova {brojac2}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int brojac = textBox1.Text.Length;
            lblKarakteri.Text = $"Broj karaktera {brojac}";
        }
    }
}


