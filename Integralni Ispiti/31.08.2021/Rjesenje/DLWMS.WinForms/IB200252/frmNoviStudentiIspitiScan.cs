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
        private bool edit = false;

        private Student student;
        public frmNoviStudentiIspitiScan()
        {
            InitializeComponent();
            cmbPredmeti.DataSource = db.Predmet.ToList();
        }
        public frmNoviStudentiIspitiScan(Student s) : this()
        {
            this.student = s;
        }
        public frmNoviStudentiIspitiScan(StudentiIspitiScan scan) : this()
        {
            this.ispitiScan = scan;
            this.student = scan.Student;
            UcitajPodatke();
            edit = true;
        }

        private void UcitajPodatke()
        {
            
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            
            if(validiraj(txtNapomena,pbSlika))
            {
                if(!edit)
                    ispitiScan = new StudentiIspitiScan();

                ispitiScan.Student =  this.student;
                ispitiScan.Predmet = cmbPredmeti.SelectedItem as Predmet;
                ispitiScan.Scan = ImageHelper.FromImageToByte(pbSlika.Image);
                ispitiScan.Napomena = txtNapomena.Text;
                ispitiScan.Varao = cbVarao.Checked;

                if (edit)
                {
                    db.Entry(ispitiScan).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("Uspjesan edit podataka!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    db.StudentiIspitiScan.Add(ispitiScan);
                    db.SaveChanges();
                    MessageBox.Show("Uspjesan dodan podatak!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
