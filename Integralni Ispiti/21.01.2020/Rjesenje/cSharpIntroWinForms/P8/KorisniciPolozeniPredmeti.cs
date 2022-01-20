using cSharpIntroWinForms.P10;
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

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        private List<string> ocjene = new List<string> {  "6", "7", "8", "9", "10" };
        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToArray();
            cmbOcjene.DataSource = ocjene;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
            UcitajPodatke(this.korisnik);
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
        }

        private void UcitajPodatke(Korisnik korisnik, List<KorisniciPredmeti> listaNepolozenih = null)
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = listaNepolozenih ?? konekcijaNaBazu.KorisniciPredmeti.Where(x => x.Korisnik.Id == korisnik.Id).ToList();
        }

        private void cbUcitajNepolozene_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUcitajNepolozene.Checked == true)
                UcitajNepolozene();
            else
                UcitajPodatke(this.korisnik);
        }

        private void UcitajNepolozene()
        {
            
            var novaLista = new List<KorisniciPredmeti>();
            foreach (var predmet in konekcijaNaBazu.Predmeti.ToList())
                foreach (var predmetKorisnik in korisnik.Uspjeh)
                {
                    if(predmet.Id != predmetKorisnik.Id)
                    {
                        novaLista.Add(new KorisniciPredmeti
                        {
                            Korisnik = korisnik,
                            Predmet = predmet,
                            Datum = DateTime.Now.ToString()
                        });
                    }
                }
            if (!provjeri(novaLista))
            {
                cbUcitajNepolozene.Checked = false;
                return;
            }
            UcitajPodatke(this.korisnik,novaLista);
        }

        private bool provjeri(List<KorisniciPredmeti> novaLista)
        {
            int brojac = 0;
            foreach (var predmet in novaLista)
            {
                foreach (var korisnikPredmet in korisnik.Uspjeh)
                {
                    if(predmet.Predmet.Naziv == korisnikPredmet.Predmet.Naziv)
                       brojac++;
                }
                if (brojac == 2)
                {
                    MessageBox.Show("Korisnik polozio sve ispite!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            var korPred = new KorisniciPredmeti()
            {
                Korisnik = this.korisnik,
                Predmet = cmbPredmeti.SelectedItem as Predmeti,
                Ocjena = int.Parse(cmbOcjene.Text),
                Datum = dtpDatumPolaganja.Value.ToString(),
            };
            konekcijaNaBazu.KorisniciPredmeti.Add(korPred);
            konekcijaNaBazu.SaveChanges();
            MessageBox.Show("Uspjesno dodano","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            UcitajPodatke(this.korisnik);
        }

        private async void btnASYNC_Click(object sender, EventArgs e)
        {
            Predmeti predmeti = cmbPredmeti.SelectedItem as Predmeti;
            Action action = () => UcitajPodatke(this.korisnik);
            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    var kopre = new KorisniciPredmeti()
                    {
                        Korisnik = this.korisnik,
                        Predmet = predmeti,
                        Ocjena = 6,
                        Datum = DateTime.Now.ToString(),
                    };
                    konekcijaNaBazu.KorisniciPredmeti.Add(kopre);
                }
                konekcijaNaBazu.SaveChanges();
                MessageBox.Show("Uspjesno dodano 50 predmeta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BeginInvoke(action);
            });
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            this.Show();
        }
    }
}
