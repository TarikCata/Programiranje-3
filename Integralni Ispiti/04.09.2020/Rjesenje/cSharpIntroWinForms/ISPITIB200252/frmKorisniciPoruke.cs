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
    public partial class frmKorisniciPoruke : Form
    {
        private Korisnik korisnik;
        private KonekcijaNaBazu db = DLWMS.DB;
        private bool nema = false;
        public frmKorisniciPoruke()
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
        }

        public frmKorisniciPoruke(Korisnik k) : this()
        {
            this.korisnik = k;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lblKomunikacija.Text = $"Komunikacija sa: {korisnik}";
            var lista = db.KorisniciPoruke.Where(x => x.Korisnik.Id == korisnik.Id).ToList();
            if (lista.Count == 0)
            {
                lbl.Text = "Korinik nema niti jedne poruke.";
                nema = true;
                dgvPoruke.DataSource = lista;
            }
            else
            {
                dgvPoruke.DataSource = lista;
                nema = false;
            }
        }
        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            if (nema)
                return;
            var poruka = dgvPoruke.CurrentRow.DataBoundItem as KorisniciPoruke;
            this.Hide();
            new frmNovaPoruka(poruka).ShowDialog();
            this.Show();
        }
        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var poruka = dgvPoruke.CurrentRow.DataBoundItem as KorisniciPoruke;
            if(e.ColumnIndex == 3)
            {
                DialogResult d = MessageBox.Show("Jeste li sigurni da zelite obrisat","INFO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    db.KorisniciPoruke.Remove(poruka);
                    db.SaveChanges();
                    UcitajPodatke();
                }
                return;
            }
            if(poruka != null)
            {
                this.Hide();
                new frmNovaPoruka(poruka).ShowDialog();
                this.Show();
            }
        }
    }
}
