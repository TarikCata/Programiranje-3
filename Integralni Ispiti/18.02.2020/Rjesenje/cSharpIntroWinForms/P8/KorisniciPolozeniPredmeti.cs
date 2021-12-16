using cSharpIntroWinForms.IspitIB200252;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
            if (korisnik.Uspjeh.Count > 0)
                UcitajPolozenePredmete();
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = konekcijaNaBazu.KorisniciPredmeti.ToList();
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();
            cmbOcjene.DataSource = new List<int>() { 6, 7, 8, 9, 10 };
            godStudija.DataSource = konekcijaNaBazu.GodineStudija.ToList();
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            var premdet = cmbPredmeti.SelectedItem as Predmeti;
            var godina = godStudija.SelectedItem as GodinaStudija;

            if (!zabranjenoDupliciranje(premdet , godina))
                return;

            var kp = new KorisniciPredmeti()
            {
                Korisnik = korisnik,
                Datum = dtpDatumPolaganja.Value.ToString(),
                Ocjena =  int.Parse(cmbOcjene.Text),
                Predmet = premdet
            };

            korisnik.Uspjeh.Add(kp);
            konekcijaNaBazu.SaveChanges();
            UcitajPolozenePredmete();
        }
        private bool zabranjenoDupliciranje(Predmeti predmet,GodinaStudija godinaStudija)
        {
            foreach (var polozeni in korisnik.Uspjeh)
            {
                if (polozeni.Predmet.Naziv == predmet.Naziv /* && polozeni.Godina.id == godinaStudija.id*/ )
                {
                    MessageBox.Show("Ne mozete dodati isti predmet na istoj godini!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}
