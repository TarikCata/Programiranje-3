using cSharpIntroWinForms.IspitIB200252;
using cSharpIntroWinForms.P10;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;



namespace cSharpIntroWinForms
{
    public partial class frmGodineStudija : Form
    {
        bool edit = false;

        GodinaStudija _GodinaStudija { get; set; }

        public frmGodineStudija()
        {
            InitializeComponent();
            dgvGodineStudija.AutoGenerateColumns = false;
            _GodinaStudija = new GodinaStudija();

        }

        private void frmGodineStudija_Load(object sender, EventArgs e)
        {
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            try
            {
                dgvGodineStudija.DataSource = null;
                dgvGodineStudija.DataSource = DLWMS.DB.GodineStudija.ToList(); ;
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }


        private void btnSpasiGodina_Click(object sender, EventArgs e)
        {
            var err = new ErrorProvider();
            var naziv = txtNaziv.Text;
            var aktivna = cbAktivna.Checked;

            if (Validiraj(naziv, err))  
            {
                if (!edit)
                {
                    if (!ZabraniDuplikate(naziv, aktivna))
                        return;
                    else
                    {
                        _GodinaStudija.Naziv = naziv;   
                        if (aktivna == true)
                            _GodinaStudija.Aktivna = 1;
                        else
                            _GodinaStudija.Aktivna = 0;

                        DLWMS.DB.GodineStudija.Add(_GodinaStudija);
                        Spasi();
                    }
                }
                else
                    Edituj();
            }
            Ocisti();
        }

        private void Ocisti()
        {
            txtNaziv.Text = string.Empty;
            cbAktivna.Checked = false;
        }

        private bool Validiraj(string naziv, ErrorProvider err)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                err.SetError(txtNaziv, "Obavezo polje!");
                return false;
            }
            err.Clear();
            return true;
        }

        private bool ZabraniDuplikate(string naziv, bool aktivna)
        {
            foreach (var item in DLWMS.DB.GodineStudija)
            {
                if (item.Naziv == naziv)
                {
                    MessageBox.Show("Godina vec postoji", "Info", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void Spasi()
        {
            DLWMS.DB.SaveChanges();
            ucitajPodatke();
        }

        private void dgvGodineStudija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var godinaStudija = dgvGodineStudija.CurrentRow.DataBoundItem as GodinaStudija;
            if (godinaStudija != null)
            {
                txtNaziv.Text = godinaStudija.Naziv;
                if (godinaStudija.Aktivna == 1)
                    cbAktivna.Checked = true;
                else
                    cbAktivna.Checked = false;
            }
            _GodinaStudija = godinaStudija; 
            edit = true;
        }
        private void Edituj()
        {
            var naziv = txtNaziv.Text;
            var aktivna = cbAktivna.Checked;
            foreach (var godina in DLWMS.DB.GodineStudija)
            {
                if (godina.id == _GodinaStudija.id)
                {
                    godina.Naziv = naziv;
                    if (aktivna == true)
                        godina.Aktivna = 1;
                    else
                        godina.Aktivna = 0;
                    DLWMS.DB.Entry(godina).State = EntityState.Modified;
                }
            }
            edit = false;
            Spasi();
        }
    }

}
