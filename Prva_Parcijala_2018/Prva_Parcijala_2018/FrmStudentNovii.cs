using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prva_Parcijala_2018
{
    public partial class FrmStudentNovii : Form
    {
        private string domain = "@edu.fit.ba";

        private static List<Predmet> predmeti;

        public static double _Prosjek { get; set; }

        static int _brojPolozenih { get; set; } = 0;

        public FrmStudentNovii() 
        {
            InitializeComponent();
        }

        private void FrmStudentDetalji_Load(object sender, EventArgs e)
        {
            txtEmail.Text = $"ib{Student.Br}{domain}";
            txtBrojIndeksa.Text = txtEmail.Text.Trim(domain.ToCharArray());
        }
        private static List<Predmet> GenerisiPredmete()
        {
            int brojac = 1;
            double sum = 0;
            predmeti = new List<Predmet>();
            for (int i = 0; i < 5; i++)
            {
                Random r = new Random();
                var p = new Predmet()
                {
                    Naziv = $"Predmet {brojac}",
                    Ocjena = r.Next(6, 10),
                    _DateTime = DateTime.Now.ToUniversalTime(),
                };
                predmeti.Add(p);
                brojac++;
                sum += p.Ocjena;
                _brojPolozenih++;
            }
            _Prosjek = Math.Round((sum) / (predmeti.Count), 2);
            return predmeti;
        }
        
        private void btnSpasi_Click(object sender, EventArgs e)
        {
            
            if (Validacija.Validiraj(txtIme,err) && Validacija.Validiraj(txtPrezime,err) && 
                Validacija.Validiraj(pbStudentSlika,err))
            {
                var s = new Student()
                {  
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Predmeti = GenerisiPredmete(),
                    image = pbStudentSlika.Image,
                    Prosjek  = _Prosjek,
                    BrojPolozenih  = _brojPolozenih,
                };
                _brojPolozenih = 0;
                InMemoryDb.Registrovani.Add(s);
                MessageBox.Show("Dodan");
                Close();
                return;
            }
        }

        private void pbStudentSlika_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string putanja = ofd.FileName;
                Image image = Image.FromFile(putanja);
                pbStudentSlika.Image = image;
            }
        }
    }
}
