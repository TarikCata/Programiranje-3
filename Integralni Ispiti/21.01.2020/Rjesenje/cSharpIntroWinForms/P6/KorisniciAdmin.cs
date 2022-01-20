using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
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

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;
                if (korisnici != null)
                    ucitajProsjek(korisnici);
                else
                    ucitajProsjek(konekcijaNaBazu.Korisnici.ToList());

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void ucitajProsjek(List<Korisnik> korisnici)
        {
            double sum = 0;
            int brojPredmete = 0;
            foreach (var korisnik in korisnici)
            {
                foreach (var predmet in korisnik.Uspjeh)
                {
                    sum += predmet.Ocjena;
                    brojPredmete++;
                }
            }
            if(sum > 0)
                lblProsjek.Text = $"Prosjek ocjena: {Math.Round(sum / brojPredmete,2)}";
            else
                lblProsjek.Text = $"Prosjek ocjena: 0";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            List<Korisnik> korisniks = new List<Korisnik>();
            var txt = txtPretraga.Text.ToLower();
            foreach (var x in konekcijaNaBazu.Korisnici.ToList())
            {
                if(x.Ime.ToLower().Contains(txt) || x.Prezime.ToLower().Contains(txt))
                    korisniks.Add(x);
            }
            LoadData(korisniks);
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                this.Hide();
                var obj = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
                new KorisniciPolozeniPredmeti(obj).ShowDialog();
                this.Show();
            }
        }
    }
}
