using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudentiPotvrde : Form
    {
        private KonekcijaNaBazu db = DLWMSdb.Baza;

        public frmStudentiPotvrde()
        {
            InitializeComponent();
            dgvPotvrde.AutoGenerateColumns = false;
        }

        private void frmStudentiPotvrde_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                dgvPotvrde.DataSource = null;
                dgvPotvrde.DataSource = db.StudentiPotvrde.ToList();
                lblpotvrde.Text = $"Trenutno potvrda:{db.StudentiPotvrde.ToList().Count}";
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException}");
            }
        }

        private bool provjera(string txt)
        {
            Regex regex = new Regex(@"^\d$");
            if (txt == string.Empty)
            {
                MessageBox.Show("Unesite validnu vrijednost!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(!regex.IsMatch(txt))
            {
                MessageBox.Show("Unesite validnu vrijednost!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var txt = txtGenerisi.Text;
            if (!provjera(txt))
                return;
            int n = int.Parse(txt);
            Action action = () => UcitajPodatke();
            await Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                {
                    Random random = new Random();
                    int r = random.Next(1, db.Studenti.ToList().Count - 1);
                    int v = random.Next(0, 1);
                    var sp = new StudentiPotvrde();
                    sp.Student = db.Studenti.ToList().ElementAt(r);
                    sp.Datum = DateTime.Now.ToString();
                    sp.Svrha = $"Svrha {i}";
                    sp.Izdata = 1;
                    db.StudentiPotvrde.Add(sp);
                }
                db.SaveChanges();
                BeginInvoke(action);
            });
        }

        async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (db.StudentiPotvrde.ToList().Count == 0)
            {
                MessageBox.Show("Nema podataka za obriasti!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            DialogResult d = MessageBox.Show("Jeste li sigurni da zelite obrisati sve podatke?","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Action action = () => UcitajPodatke();
                await Task.Run(() =>
                {
                    db.StudentiPotvrde.RemoveRange(db.StudentiPotvrde);
                    db.SaveChanges();
                    BeginInvoke(action);
                });
            }
            else
                return;
        }
    }
}
