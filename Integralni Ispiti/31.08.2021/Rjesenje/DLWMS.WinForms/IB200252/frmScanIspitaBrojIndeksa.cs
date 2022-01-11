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
    public partial class frmScanIspitaBrojIndeksa : Form
    {
        private KonekcijaNaBazu db = DLWMSdb.Baza;
        Student student;
        KorisniciIspitiScan IspitiScan;
        public frmScanIspitaBrojIndeksa()
        {
            InitializeComponent();
            dgvKorisniciScan.AutoGenerateColumns = false;
        }
        public frmScanIspitaBrojIndeksa(Student student) : this()
        {
            this.student = student;
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            lblKomunikacija.Text = $"Komunikacija sa: {student}";
            var lista = db.KorisniciIspitiScan.Where(x => x.Student.Id == student.Id).ToList();
            dgvKorisniciScan.DataSource = null;
            dgvKorisniciScan.DataSource = lista;
        } 
        private void dgvKorisniciScan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ks = dgvKorisniciScan.CurrentRow.DataBoundItem as KorisniciIspitiScan;
            if(e.ColumnIndex == 4)
            {
                DialogResult d = MessageBox.Show("Jeste li sigurni da zelite ovo obrisati","DLWMS",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    db.KorisniciIspitiScan.Remove(ks);
                    db.SaveChanges();
                    UcitajPodatke();
                    return;
                }
                else
                    return;
            }
            this.Hide();
            new frmNoviKorisniciIspiti(ks,true).ShowDialog();
            this.Show();
            UcitajPodatke();
        }   
        private void btnNoiv_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNoviKorisniciIspiti(new KorisniciIspitiScan() { Student = this.student}, false).ShowDialog();
            this.Show();
            UcitajPodatke();
        }
    }
}
