using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.ib200252
{
    public partial class frmPredmetiSeminarski : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        private StudentiPredmeti s;
        private List<PredmetiSeminarski> predmetiSeminarski = new List<PredmetiSeminarski>();
        int index = 0;
        private Image img;
        public frmPredmetiSeminarski()
        {
            InitializeComponent();
        }

        public frmPredmetiSeminarski(StudentiPredmeti s) : this()
        {
            this.s = s;
            lblPredmet.Text = s.Predmet.ToString();
            lblStudent.Text = s.Student.ToString();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                var ps = db.PredmetiSeminarski.Where(x => x.Student.Id == s.Student.Id).ToList();
                if (ps.Count > 0)
                {
                    predmetiSeminarski = ps;
                    Ucitaj(predmetiSeminarski.ElementAt(index));
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void Ucitaj(PredmetiSeminarski predmetiSeminarski)
        {
            int n = index + 1;
            lblBrojSlika.Text = $"Broj slika: {n}/{this.predmetiSeminarski.Count}";
            lblOpis.Text = predmetiSeminarski.Opis;
            lblDatum.Text = predmetiSeminarski.Datum;
            if (predmetiSeminarski.Slika != null)
                pbDonja.Image = Helpers.ImageHelper.FromByteToImage(predmetiSeminarski.Slika);
        }

        private void pbGornja_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var putanja = ofd.FileName;
                img = Image.FromFile(putanja);
                pbGornja.Image = img;
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(pbGornja.Image == null)
            {
                MessageBox.Show("Unos slike obavezan","INFO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            db.PredmetiSeminarski.Add(new PredmetiSeminarski()
            {
                Student = s.Student,
                Predmet = s.Predmet,
                Slika = Helpers.ImageHelper.FromImageToByte(img),
                Datum = DateTime.Now.ToString(),
                Opis = txtOpis.Text,
            });
            db.SaveChanges();
            MessageBox.Show("Uspjesno dodano","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            UcitajPodatke();
            Ocisti();
        }
        private void Ocisti()
        {
            pbGornja.Image = null;
            txtOpis.Text = "";
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            index--;
            if(index < 0)
            {
                MessageBox.Show("Nema vise!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                index++;
                return;
            }
            UcitajPodatke();
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= predmetiSeminarski.Count)
            {
                MessageBox.Show("Nema vise!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                index--;
                return;
            }
            UcitajPodatke();
        }
    }
}
