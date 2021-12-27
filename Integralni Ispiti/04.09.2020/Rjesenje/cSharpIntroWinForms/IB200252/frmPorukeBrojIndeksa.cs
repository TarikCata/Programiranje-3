using cSharpIntroWinForms.P10;
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

namespace cSharpIntroWinForms.IB200252
{
    public partial class frmPorukeBrojIndeksa : Form
    {
        private Korisnik korisnik;

        private KonekcijaNaBazu konekcija = DLWMS.DB;

        //private KorisniciPredmeti obj;

        public frmPorukeBrojIndeksa()
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
        }

        //public frmPorukeBrojIndeksa(Korisnik korisnik) : this()
        //{
        //    this.korisnik = korisnik;
        //    Ucitaj();
        //    lblKomunikacija.Text += $"{korisnik.Ime} {korisnik.Prezime}";
        //}

        //public frmPorukeBrojIndeksa(KorisniciPoruke korisniciPoruke) : this()
        //{
        //    this.korisnik = korisniciPoruke.Korisnik;
        //    Ucitaj();
        //    lblKomunikacija.Text += $"{this.korisnik.Ime} {this.korisnik.Prezime}";
        //}

        public frmPorukeBrojIndeksa(KorisniciPredmeti obj)
        {
            this.korisnik = obj.Korisnik;
            Ucitaj();
            lblKomunikacija.Text += $"{this.korisnik.Ime} {this.korisnik.Prezime}";
        }

        private void Ucitaj()
        {
            try
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = korisnik.Poruke;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException}");
            }
        }

        private void frmPorukeBrojIndeksa_Load(object sender, EventArgs e)
        {

        }
    }
}
