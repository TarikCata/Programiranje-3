using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
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
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnGodineStudija_Click(object sender, EventArgs e)
        {
            var frm = new frmGodineStudija();
            frm.ShowDialog();
        }

        private void btnPolozeniPredmeti_Click(object sender, EventArgs e)
        {
            var k = DLWMS.DB.Korisnici.ToList().First();    
            var frm = new KorisniciPolozeniPredmeti(k);
            frm.ShowDialog();
        }

        private void btnIzracunajSumu_Click(object sender, EventArgs e)
        {
            Izvrsi();
        }

        private async void Izvrsi()
        {
            await Task.Run(() => izracunajSumu());
        }

        private void izracunajSumu()
        {
            if (string.IsNullOrWhiteSpace(txtSuma.Text))
                return;
            int n = int.Parse(txtSuma.Text);
            int suma = 0;
            for (int i = 1; i <= n; i++)
                suma += i;
            MessageBox.Show($"Suma od 1 do {n} je {suma}","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
