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
    public partial class frmNoviStudentiIspitiScan : Form
    {

        private KonekcijaNaBazu db = DLWMSdb.Baza;
        private StudentiIspitiScan ispitiScan;
        private bool pregled = false;
        private Student student;

        public frmNoviStudentiIspitiScan()
        {
            InitializeComponent();
        }
        public frmNoviStudentiIspitiScan(Student s) : this()
        {
            this.student = s;
            cmbPredmeti.DataSource = db.Predmet.ToList();
        }
        public frmNoviStudentiIspitiScan(StudentiIspitiScan scan) : this()
        {
            this.ispitiScan = scan;
            UcitajPodatke();
            pregled = true;
        }

        private void UcitajPodatke()
        {
            cmbPredmeti.Text = ispitiScan.Predmet.ToString();
            cmbPredmeti.Enabled = false;
            txtNapomena.Text = ispitiScan.Napomena;
            txtNapomena.ReadOnly = true;
            pbSlika.Image = ImageHelper.FromByteToImage(ispitiScan.Scan);
            pbSlika.Enabled = false;
            cbVarao.Checked = ispitiScan.Varao;
            cbVarao.Enabled = false;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            
            if(validiraj(txtNapomena,pbSlika))
            {
                if (!pregled)
                {
                    ispitiScan = new StudentiIspitiScan();
                    ispitiScan.Student = this.student;
                    ispitiScan.Predmet = cmbPredmeti.SelectedItem as Predmet;
                    ispitiScan.Scan = ImageHelper.FromImageToByte(pbSlika.Image);
                    ispitiScan.Napomena = txtNapomena.Text;
                    ispitiScan.Varao = cbVarao.Checked;
                    db.StudentiIspitiScan.Add(ispitiScan);
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno dodan podatak!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }

        private bool validiraj(TextBox txtNapomena, PictureBox pbSlika)
        {
            var err = new ErrorProvider();
            if(txtNapomena.Text == string.Empty)
            {
                err.SetError(txtNapomena, "Ovo polje je obavazno!");
                return false;
            }
            if(pbSlika.Image == null)
            {
                err.SetError(pbSlika, "Ovo polje je obavazno!");
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
                string putanja = ofd.FileName;
                var slika = Image.FromFile(putanja);
                pbSlika.Image = slika;
            }
        }

    }
}
