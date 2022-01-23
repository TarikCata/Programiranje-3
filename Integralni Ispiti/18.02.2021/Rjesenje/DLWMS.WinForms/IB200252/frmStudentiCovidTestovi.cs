using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200252
{
    public partial class frmStudentiCovidTestovi : Form
    {
        private KonekcijaNaBazu db = DLWMSdb.Baza;
        private List<string> vs = new List<string>() { "Negativan", "Pozitivan" };
        private List<StudentiCovidTestovi> covidTestovi = new List<StudentiCovidTestovi>();
        public frmStudentiCovidTestovi()
        {
            InitializeComponent();
            dgvStudentiCovidTestovi.AutoGenerateColumns = false;
        }

        private void frmStudentiCovidTestovi_Load(object sender, EventArgs e)
        {
            cmbRezultat.DataSource = vs;
            cmbStudent.DataSource = db.Studenti.ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                covidTestovi = db.StudentiCovidTestovi.ToList();
                dgvStudentiCovidTestovi.DataSource = null;
                dgvStudentiCovidTestovi.DataSource = covidTestovi;
                lblBrojTestova.Text = $"Broj potvrda: {covidTestovi.Count}";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var sct = new StudentiCovidTestovi();
            sct.Student = cmbStudent.SelectedItem as Student;
            if (provjera(dtpDatum.Value))
                sct.Datum = dtpDatum.Value.ToShortDateString();
            else
            {
                MessageBox.Show("Ne mozete dodati podatak na isti datum!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sct.Rezultat = cmbRezultat.Text;
            sct.Dostavljen = cbNalaz.Checked;
            db.StudentiCovidTestovi.Add(sct);
            db.SaveChanges();
            MessageBox.Show("Uspjesno pohranjen podatak!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            UcitajPodatke();
        }

        private bool provjera(DateTime value)
        {
            foreach(var item in covidTestovi)
            {
                if (item.Datum == value.ToShortDateString())
                    return false;
            }
            return true;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                return;
            int n = Convert.ToInt32(textBox1.Text);
            Action action = () => UcitajPodatke();
            await Task.Run(() => {

                for (int i = 0; i < n; i++)
                {
                    Random random = new Random();
                    var rStudent = random.Next(0, db.Studenti.ToList().Count - 1);
                    var rRez = random.Next(0, 1);
                    db.StudentiCovidTestovi.Add(new StudentiCovidTestovi()
                    {
                        Student = db.Studenti.ToList().ElementAt(rStudent),
                        Datum = DateTime.Now.ToShortDateString(),
                        Rezultat = vs.ElementAt(rRez),
                        Dostavljen = random.Next(2) == 1
                    });
                }
                db.SaveChanges();
                MessageBox.Show($"Uspjesno pohranjeno {n} podataka!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BeginInvoke(action);
            });
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (covidTestovi.Count <= 0)
                return;
            Action action = () => UcitajPodatke();
            await Task.Run(() =>
            {
                DialogResult d = MessageBox.Show("Jeste li sigurni da zelite obrisati sve podatke?","INFO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    int n = covidTestovi.Count;
                    db.StudentiCovidTestovi.RemoveRange(covidTestovi);
                    db.SaveChanges();
                    BeginInvoke(action);
                    MessageBox.Show($"Uspjesno obrisano {n} podataka!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    return;
            });
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            if (covidTestovi.Count <= 0)
                return;
            this.Hide();
            new frmIzvjestaji(dgvStudentiCovidTestovi.DataSource as List<StudentiCovidTestovi>).ShowDialog();
            this.Show();
        }
    }
}
