using cSharpIntroWinForms.P10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB200252
{
    public partial class KorisniciSlikePregled : Form
    {
        private Korisnik korisnik;

        public KorisniciSlikePregled()
        {
            InitializeComponent();
        }

        public Image byteToImage(byte[] vs)
        {
            using (var ms = new MemoryStream(vs))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        public byte[] ImageToByte(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms,image.RawFormat);
                return ms.ToArray();    
            }
        }

        public KorisniciSlikePregled(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
            LoadData();
        }

        private void LoadData()
        {
            if (korisnik.Slike.Count != 0)
                pbSlika.Image =  byteToImage(korisnik.Slike[0].slika);
            else
                MessageBox.Show("Nemate slike.. click na box za dodavanje!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        int index = 0;
        private void btnLijevo_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                pbSlika.Image = byteToImage(korisnik.Slike[index - 1].slika);
                index--;    
            }
            else
                MessageBox.Show("Ne postoji slika");
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            if (index < korisnik.Slike.Count - 1)
            {
                pbSlika.Image = byteToImage(korisnik.Slike[index + 1].slika);
                index--;
            }
            else
                MessageBox.Show("Ne postoji slika");
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string putanja = ofd.FileName;
                Image img = Image.FromFile(putanja);
                var ks = new KorisniciSlike()
                {
                    korisnik = korisnik,
                    slika = ImageToByte(img)
                };
                korisnik.Slike.Add(ks);
                DLWMS.DB.SaveChanges();
            }
            LoadData();
        }
    }
}
