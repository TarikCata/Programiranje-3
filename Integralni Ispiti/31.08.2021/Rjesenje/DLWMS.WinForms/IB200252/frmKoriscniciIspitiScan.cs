using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200252
{

    public partial class frmKoriscniciIspitiScan : Form
    {
        private KonekcijaNaBazu db = DLWMSdb.Baza;
        private Student Student;
        public frmKoriscniciIspitiScan()
        {
            InitializeComponent();
            dgvIspiti.AutoGenerateColumns = false;
        }
        public frmKoriscniciIspitiScan(Student s) : this()
        {
            this.Student = s;
            lblStudentIme.Text = Student.ToString();
            UcitajPodatke(s);
        }
        private void UcitajPodatke(Student s)
        {
            try
            {
                dgvIspiti.DataSource = null;
                var lista = db.StudentiIspitiScan.Where(x => x.Student.Id == s.Id).ToList();
                dgvIspiti.DataSource = lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void frmKoriscniciIspitiScan_Load(object sender, EventArgs e)
        {
            UcitajPodatke(Student);
        }

        private void dgvIspiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var red = dgvIspiti.CurrentRow.DataBoundItem as StudentiIspitiScan;
                DialogResult d = MessageBox.Show("Jeste li sigurni da zelite ovo izbrisati?","INFO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    db.StudentiIspitiScan.Remove(red);
                    db.SaveChanges();
                    UcitajPodatke(this.Student);
                }
                else
                    return;
            }
        }

        private void dgvIspiti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            var scan = dgvIspiti.CurrentRow.DataBoundItem as StudentiIspitiScan ;
            new frmNoviStudentiIspitiScan(scan).ShowDialog();
            this.Show();
        }

        private void btnDodajScan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNoviStudentiIspitiScan(Student).ShowDialog();
            UcitajPodatke(Student);
            this.Show();
        }
    }
}
