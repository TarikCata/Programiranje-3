using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.ISPITIB200252
{
    public partial class frmNovaPoruka : Form
    {
        private KorisniciPoruke poruka;

        public frmNovaPoruka()
        {
            InitializeComponent();
        }

        public frmNovaPoruka(KorisniciPoruke poruka) : this()
        {
            this.poruka = poruka;
            Ucitaj();
        }

        private void Ucitaj()
        {
            if(this.poruka != null)
            {
                txtSadrzaj.Text = poruka.Sadrzaj;
                txtPrimalac.Text = poruka.Korisnik.ToString();
                if (poruka.Slika == null)
                    return;
                else
                    pbSlika.Image = ImageHelper.FromByteToImage(poruka.Slika);
            }
        }
    }
}
