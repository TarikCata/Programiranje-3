using System;
using System.Windows.Forms;

namespace Prva_Parcijala_2018
{
    public partial class frmDetaljniPodaci : Form
    {
        private Student _student;

        public frmDetaljniPodaci()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public frmDetaljniPodaci(object student) : this()
        {
            _student = (Student)student;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            txtBrojIndeksa.Text = _student.BrojIndeksa;
            txtIme.Text = _student.Ime;
            txtPrezime.Text = _student.Prezime;
            txtEmail.Text = _student.Email;
            pbStudentSlika.Image = _student.image;
            dataGridView1.DataSource = _student.Predmeti;
        }

        //public void UcitajStudenta(Student student)
        //{
        //    if (true)
        //    {
        //        return;
        //    }
        //}
        private void frmDetaljniPodaci_Load(object sender, EventArgs e)
        {

        }
    }
}
