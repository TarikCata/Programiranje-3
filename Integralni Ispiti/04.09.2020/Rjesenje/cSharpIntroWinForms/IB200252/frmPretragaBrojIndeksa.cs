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
    public partial class frmPretragaBrojIndeksa : Form
    {
        private KonekcijaNaBazu konekcija = DLWMS.DB;

        private List<KorisniciPredmeti> predmeti = new List<KorisniciPredmeti>();
        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }

        private void frmPretragaBrojIndeksa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(List<KorisniciPredmeti> k = null)
        {
            try
            {
                dgvPredmeti.DataSource = null;
                dgvPredmeti.DataSource = k ?? konekcija.KorisniciPredmeti.ToList();
                IzracunajProsjek();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
        private void IzracunajProsjek(List<KorisniciPredmeti> k = null)
        {
            var l = k ?? konekcija.KorisniciPredmeti.ToList();
            double suma = 0;
            if(l.Count == 0)
                label2.Text = "Prosjek prikazanih ocjena: 0";
            else
            {
                foreach (var x in l)
                    suma += x.Ocjena;
                var s = Math.Round((suma / l.Count), 2);
                label2.Text = $"Prosjek prikazanih ocjena: {s.ToString()}";
            }

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var txt = txtPretraga.Text.ToLower();
            //var rez = konekcija.KorisniciPredmeti.Where(x => x.Predmet.Naziv.ToLower().Contains(txt)).ToList();
            var lista = new List<KorisniciPredmeti>();
            foreach (var x in konekcija.KorisniciPredmeti)
            {
                if(x.Predmet.Naziv.ToLower().Contains(txt))
                    lista.Add(x);
            }
            LoadData(lista);
            IzracunajProsjek(lista);
        }

        private void btnSumiraj_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                return;
            int n = int.Parse(textBox1.Text);
            var suma = 0;
            var izvrsavanje = Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                     suma += i;
            });
            var cekanje = izvrsavanje.GetAwaiter();
            cekanje.OnCompleted(() => lblSuma.Text = suma.ToString());
        }

        private void dgvPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvPredmeti.CurrentRow.DataBoundItem as KorisniciPredmeti;

            //var korisnik = konekcija.Korisnici.Where(x => x.Id == obj.Korisnik.Id) as Korisnik;
            if (e.ColumnIndex == 4)
            {
                var frm = new frmPorukeBrojIndeksa(obj);
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
