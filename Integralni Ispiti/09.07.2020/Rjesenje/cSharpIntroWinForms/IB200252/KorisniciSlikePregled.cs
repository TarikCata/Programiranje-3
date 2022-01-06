using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB200252
{
    public partial class KorisniciSlikePregled : Form
    {
        private Korisnik korisnik;
        private KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        private List<Image> slike = new List<Image>(); 
        private List<KorisniciSlike> korisniciSlike;
        private int index = 0;
        public KorisniciSlikePregled()
        {
            InitializeComponent();
        }
        public KorisniciSlikePregled(Korisnik obj) : this()
        {
            this.korisnik = obj;
            lblIme.Text = obj.ToString();
            Ucitaj();
        }
        private void Ucitaj()
        {
            var k = konekcijaNaBazu.KorisniciSlike.Where(x => x.Korisnik.Id == korisnik.Id).ToList();
            if (k == null)
            {
                MessageBox.Show("Korisnik nema nijedne slike", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                korisniciSlike = k;
                foreach (var x in korisniciSlike)
                    slike.Add(ImageHelper.FromByteToImage(x.Slika));
                if (slike.Count == 0)
                    return;
                else
                    UcitajSliku(index);
            }
        }
        private void UcitajSliku(int index)
        {
            pbSlika.Image = slike[index];
            if(slike.Count == 0)
                lblbrojSlika.Text = "Nema slika";
            else
            {
                int v = index + 1;
                lblbrojSlika.Text = $"Slika {v}/{slike.Count}";
            }
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var putanja = ofd.FileName;
                Image image = Image.FromFile(putanja);
                var uBajt = ImageHelper.FromImageToByte(image);
                var ks = new KorisniciSlike() { Korisnik = korisnik,Slika = uBajt };
                konekcijaNaBazu.KorisniciSlike.Add(ks);
                konekcijaNaBazu.SaveChanges();
                MessageBox.Show($"Slika je uspjesno spasena!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Ucitaj();
            }
        }
        private void btnDesno_Click(object sender, EventArgs e)
        {
            index++;
            if(index >= slike.Count)
            {
                MessageBox.Show("Ne postoji vise slika","INFO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                index--;
                return;
            }
            UcitajSliku(index);
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            index--;
            if(index < 0) 
            {
                MessageBox.Show("Ne postoji vise slika", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                index++;
                return;
            }
            UcitajSliku(index);
        }
    }
}
