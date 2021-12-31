using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB180207
{
    public partial class frmCovidTestIB180207 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        private List<string> list = new List<string>() { "Pozitivan","Negativan"};
        Stopwatch Stopwatch1 = new Stopwatch(); 
        Stopwatch Stopwatch2 = new Stopwatch(); 
        public frmCovidTestIB180207()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmCovidTestIB180207_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajCmbove();
        }

        private void UcitajCmbove()
        {
            cmbStudent.Items.AddRange(db.Studenti.ToArray());
            cmbRezultatTesta.DataSource = list;
        }
        

        private void UcitajPodatke(Stopwatch s = null, Stopwatch b = null)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.StudentiCovidTestovi.ToList();
            Ucitaj(s,b);
        }

        private void Ucitaj(Stopwatch s, Stopwatch b)
        {
            if(s == null)
               lbAdd.Text = "Vrijeme izvrsavanja dodaavnja: 0";
            else
            {
                var vr1 = s.ElapsedMilliseconds.ToString();
                lbAdd.Text = $"Vrijeme izvrsavanja dodaavnja: {vr1} ms";
            }
            if(b == null)
                lbDel.Text = "Vrijeme izvrsavanja brisanja: 0";
            else
            {
                var vr2 = b.ElapsedMilliseconds.ToString();
                lbDel.Text = $"Vrijeme izvrsavanja brisanja: {vr2} ms";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            if(provjeriDatume())
            {
                var covidTestovi = new StudentiCovidTestovi()
                {
                    Student = cmbStudent.SelectedItem as Student,
                    DatumTestiranja = dtmDatumTestiranja.Value.ToString(),
                    Rezultat = cmbRezultatTesta.Text.ToString(),
                    Dostavljen = cbNalaz.Checked


                };
                db.StudentiCovidTestovi.Add(covidTestovi);
                db.SaveChanges();
                MessageBox.Show("Uspjesno dodan test!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajPodatke();
            }
        }

        private bool provjeriDatume()
        {
            var datum = dtmDatumTestiranja.Value.ToString();
            foreach (var item in db.StudentiCovidTestovi.ToList())
            {
                if(item.DatumTestiranja == datum)
                {
                    MessageBox.Show("Ne mozete dodati 2 testa na isti dan!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private async void btnObrisiTestove_Click(object sender, EventArgs e)
        {
            if (db.StudentiCovidTestovi.ToList().Count <= 0)
                return;
            Action action = () => UcitajPodatke(null,Stopwatch2);
            await Task.Run(() =>
            {
                Stopwatch2.Start();
                DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da zelite sve obrisati?","INFO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                db.StudentiCovidTestovi.RemoveRange(db.StudentiCovidTestovi);
                db.SaveChanges();
                BeginInvoke(action);
                Stopwatch2.Stop();
            });
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if(txtBrojTestova.Text == string.Empty)
            {
              MessageBox.Show("Unesite validnu vrijednost!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Action action = () => UcitajPodatke(Stopwatch1,null);
            await Task.Run(() =>
            {
                Stopwatch1.Start();
                int n = int.Parse(txtBrojTestova.Text);
                for (int i = 1; i <= n; i++)
                {
                    Random r = new Random();
                    var sci = new StudentiCovidTestovi()
                    {
                        Student = db.Studenti.ToList().ElementAt(r.Next(0, db.Studenti.ToList().Count - 1)),
                        DatumTestiranja = DateTime.Now.ToString(),
                        Rezultat = list.ElementAt(r.Next(0, 1)),
                        Dostavljen = true,
                    };
                    db.StudentiCovidTestovi.Add(sci);
                }
                db.SaveChanges();
                BeginInvoke(action);
                Stopwatch1.Stop();
            });
        }
    }
}
