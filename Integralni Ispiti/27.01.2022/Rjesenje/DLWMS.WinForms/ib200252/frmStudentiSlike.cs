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
    public partial class frmStudentiSlike : Form
    {
        private Student std;
        KonekcijaNaBazu db = DLWMSdb.Baza;
        int index = 0;
        private Image image;
        List<StudentiSlike> studentiSlikes = new List<StudentiSlike>();
        public frmStudentiSlike()
        {
            InitializeComponent();
        }
        public frmStudentiSlike(Student std) : this()
        {
            this.std = std;
        }
        private void frmStudentiSlike_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            var lista = db.StudentiSlike.Where(x => x.Student.Id == std.Id).ToList();
            if (lista.Count == 0)
                return;
            else
            {
                studentiSlikes = lista;
                UcitajZaStudenta(studentiSlikes.ElementAt(index));
                UcitajLblBrojSlika();
            }
        }
        private void UcitajLblBrojSlika()
        {
            int n = index + 1;
            lblBrojSlika.Text = $"Slika {n}/{db.StudentiSlike.ToList().Count}";
        }
        private void UcitajZaStudenta(StudentiSlike studentiSlike)
        {
            lblDatum.Text = studentiSlike.Datum;
            if(studentiSlike.Slika != null)
                pbDonjaSlika.Image = Helpers.ImageHelper.FromByteToImage(studentiSlike.Slika);
            lblOpisDonji.Text = studentiSlike.Opis;
        }
        private void pbSlikaDodaj_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string putanja = ofd.FileName;
                image = Image.FromFile(putanja);
                pbSlikaDodaj.Image = image;
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            db.StudentiSlike.Add(new StudentiSlike()
            {
                Student = std,
                Slika = Helpers.ImageHelper.FromImageToByte(image),
                Opis = txtOpisGornji.Text,
                Datum = DateTime.Now.ToString(),
            });
            db.SaveChanges();
            MessageBox.Show("Uspjesno dodano!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            UcitajPodatke();
            pbSlikaDodaj.Image = null;
            txtOpisGornji.Text = string.Empty;
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            index++;
            if(index >= db.StudentiSlike.ToList().Count)
            {
                MessageBox.Show("Nema vise slika!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                index--;
            }
            UcitajPodatke();
        }
        private void btnLijevo_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                MessageBox.Show("Nema vise slika!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                index++;
            }
            UcitajPodatke();
        }
    }
}
