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

namespace cSharpIntroWinForms.ISPITIB200252
{
    public partial class frmPretraga : Form
    {
        private KonekcijaNaBazu db = DLWMS.DB;
        public frmPretraga()
        {
            InitializeComponent();
            dgvPredetu.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke(List<KorisniciPredmeti> ks = null)
        {
            try
            {
                dgvPredetu.DataSource = null;
                dgvPredetu.DataSource = ks ?? db.KorisniciPredmeti.ToList();
                if (ks != null)
                    UcitajProsjek(ks);
                else
                    UcitajProsjek(db.KorisniciPredmeti.ToList());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void UcitajProsjek(List<KorisniciPredmeti> ks)
        {
            double sum = 0;
            foreach (var item in ks)
               sum += item.Ocjena;
            if (sum == 0)
                lblProsjek.Text = "Prosjek Ocjena: 0";
            else
                lblProsjek.Text = $"Prosjek Ocjena: {Math.Round(sum/ks.Count,2)}";

        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var txt = txtPretraga.Text.ToLower();
            var lista = new List<KorisniciPredmeti>();
            foreach (var predmet in db.KorisniciPredmeti.ToList())
            {
                if(predmet.Predmet.Naziv.ToLower().Contains(txt))
                    lista.Add(predmet);
            }
            UcitajPodatke(lista);
        }
        private void btnThread_Click(object sender, EventArgs e)
        {
            if (txtThread.Text == string.Empty)
                return;
            int n = Convert.ToInt32(txtThread.Text);
            double sum = 0; 
            var iz = Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                    sum += i;
            });
            var cekanje = iz.GetAwaiter();
            cekanje.OnCompleted(() => lblThread.Text = $"{sum}");
        }
        private void dgvPredetu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                var ks = dgvPredetu.CurrentRow.DataBoundItem as KorisniciPredmeti;
                var k = ks.Korisnik;
                this.Hide();
                new frmKorisniciPoruke(k).ShowDialog();
                this.Show();
            }
        }
    }
}
