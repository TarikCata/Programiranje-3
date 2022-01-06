using cSharpIntroWinForms.IB200252;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        bool preLoad = true;
        private List<Korisnik> sviKorisnici = new List<Korisnik>();
       
        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
            cmbSpolovi.DataSource = konekcijaNaBazu.Spolovi.ToList();
            sviKorisnici = konekcijaNaBazu.Korisnici.ToList();
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? konekcijaNaBazu.Korisnici.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex  == 5)
            {
                this.Hide();
                var obj = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
                new KorisniciSlikePregled(obj).ShowDialog();
                this.Show();
            }    
        }

        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(preLoad)
            {
                preLoad = false;
                return;
            }
            var spol = cmbSpolovi.SelectedItem as Spolovi;
            UcitajPoSpolovima(spol);
        }

        private void UcitajPoSpolovima(Spolovi spol)
        {
            var lista = new List<Korisnik>();
            foreach(var korisnik in sviKorisnici)
            {
                if(korisnik.Spol.Id == spol.Id)
                {
                    lista.Add(korisnik);
                }
            }
            LoadData(lista);
        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdmin.Checked)
                ucitajAdmine();
            else
                LoadData();
        }

        private void ucitajAdmine()
        {
            var lista = konekcijaNaBazu.Korisnici.Where(x => x.Admin == cbAdmin.Checked).ToList();
            LoadData(lista);
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var lista = new List<Korisnik>();
            var txt = txtPretraga.Text.ToLower();
            foreach (var item in sviKorisnici)
            {
                if(item.Ime.ToLower().Contains(txt) || item.Prezime.ToLower().Contains(txt))
                {
                    lista.Add(item);
                }
            }
            LoadData(lista);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtSuma.Text == string.Empty)
                return;
            double suma = 0;
            int n = Convert.ToInt32(txtSuma.Text);
           var sumiranje = Task.Run(() =>
           {
               for (int i = 1; i <= n; i++)
                   suma += i;
           });
            var await = sumiranje.GetAwaiter();
            await.OnCompleted(() => MessageBox.Show($"Suma od {0} do broja {n} je  {suma}", $"Threading", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }
    }
}
