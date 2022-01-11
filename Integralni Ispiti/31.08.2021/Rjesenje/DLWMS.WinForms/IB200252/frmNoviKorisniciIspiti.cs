using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNoviKorisniciIspiti : Form
    {
        private bool edit;
        private KorisniciIspitiScan ispitiScan = new KorisniciIspitiScan();
        private KonekcijaNaBazu db = DLWMSdb.Baza;
        private Student student;
        public frmNoviKorisniciIspiti()
        {
            InitializeComponent();
        }
        public frmNoviKorisniciIspiti(KorisniciIspitiScan ispitiScan,bool edit) :this()
        {
            this.edit = edit;
            if (edit)
            {
                this.ispitiScan = ispitiScan;
                UcitajPodatke();
            }
            else
            {
               this.student = ispitiScan.Student;
                cmbPredmeti.DataSource = db.Predmet.ToList();
            }
        }
        private void UcitajPodatke()
        {
            cmbPredmeti.Text = ispitiScan.Predmet.ToString();
            cmbPredmeti.Enabled = false;
            txtNapomena.Text = ispitiScan.Napomena;
            txtNapomena.ReadOnly = true;
            if(ispitiScan.Scan != null)
                pbSlika.Image = ImageHelper.FromByteToImage(ispitiScan.Scan);
            pbSlika.Enabled = false;
            cbVaranje.Checked = ispitiScan.Varanje;
            cbVaranje.Enabled = false;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (!edit)
                {
                    ispitiScan = new KorisniciIspitiScan();
                    ispitiScan.Student = this.student;
                    ispitiScan.Napomena = txtNapomena.Text;
                    ispitiScan.Scan = Helpers.ImageHelper.FromImageToByte(pbSlika.Image);
                    ispitiScan.Varanje = cbVaranje.Checked;
                    ispitiScan.Predmet = cmbPredmeti.SelectedItem as Predmet;
                    db.KorisniciIspitiScan.Add(ispitiScan);
                    db.SaveChanges();
                    this.Hide();
                    MessageBox.Show("Uspjesno dodano!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                this.Close();
            }
        }
        private bool Validiraj()
        {
            var err = new ErrorProvider();
            if(txtNapomena.Text == string.Empty)
            {
                err.SetError(txtNapomena, "Ovo polje je obavezno!");
                return false;
            }
            err.Clear();
            if (pbSlika.Image == null)
            {
                err.SetError(pbSlika, "Ovo polje je obavezno!");
                return false;
            }
            err.Clear();
            return true;
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var putanja = ofd.FileName;
                var slika = Image.FromFile(putanja);
                pbSlika.Image = slika;
            }
        }
    }
}
