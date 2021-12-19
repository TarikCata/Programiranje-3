using cSharpIntroWinForms.IB200252;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        Spolovi spol = null;
        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }
        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadSpolove();
        }
        private void LoadSpolove()
        {
            cmbSpolovi.DataSource = null;
            cmbSpolovi.DataSource = konekcijaNaBazu.Spolovi.ToList();
        }
        private void LoadData(List<Korisnik> korisnici = null, string txt = "all")
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                //if(txt == "all")
                //{
                //}
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (admin % 2 != 0)
                return;
            else
                filterIme();
        }
        private void filterIme()
        {
            var pretraga = txtPretraga.Text.ToLower();
            var korisnici = new List<Korisnik>();
            foreach (var k in konekcijaNaBazu.Korisnici)
                if (k.Ime.ToLower().Contains(pretraga) || k.Ime.ToLower().Contains(pretraga))
                    korisnici.Add(k);
            LoadData(korisnici);
        }
        private bool ucitavanje = true;
        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            spol = cmbSpolovi.SelectedItem as Spolovi;
            if (ucitavanje)
            {
                ucitavanje = false;
                return;
            }
            else if (admin % 2 != 0)
                return;
            else
                pretragaSpol(spol);
        }
        private void pretragaSpol(Spolovi spol)
        {
            var korisnici = new List<Korisnik>();
            if (spol != null)
            {
                foreach (var korisnik in konekcijaNaBazu.Korisnici)
                {
                    if (korisnik.Spol.Id == spol.Id)
                    {
                        korisnici.Add(korisnik);
                    }
                }
            }
            LoadData(korisnici);
        }
        private int admin = 0;
        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (admin % 2 == 0)
            {
                var korisnici = new List<Korisnik>();
                if (cbAdmin.Checked)
                {
                    foreach (var k in konekcijaNaBazu.Korisnici)
                    {
                        if (k.Admin == cbAdmin.Checked && k.Spol == spol)
                        {
                            korisnici.Add(k);
                        }
                    }
                    if (korisnici.Count == 0)
                    {
                        MessageBox.Show("Ne postoji", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbAdmin.Checked = false;
                    }
                    else
                        LoadData(korisnici);
                }
            }
            else
                pretragaSpol(spol);
            admin++;
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            if(e.ColumnIndex == 5)
            {
                if(korisnik != null)
                {
                    var frm = new KorisniciSlikePregled(korisnik);
                    frm.ShowDialog();
                }
            }
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            if (txtAsync.Text == string.Empty)
                return;
            var n = int.Parse(txtAsync.Text);
            var suma = 0;
            var izvrasavanje = Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                {
                    suma += i;
                }
            });
            var cekanje = izvrasavanje.GetAwaiter();
            cekanje.OnCompleted(() => MessageBox.Show($"Suma brojeva od 1 do {n} je: {suma}"));
        }
    }
}

