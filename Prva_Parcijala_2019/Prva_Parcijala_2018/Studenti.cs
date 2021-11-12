using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prva_Parcijala_2018
{
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
            dgStudenti.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = dgStudenti.CurrentRow.DataBoundItem as Student;
            if (student != null)
            {
                frmDetaljniPodaci frmDetaljniPodaci = new frmDetaljniPodaci(student);
                frmDetaljniPodaci.ShowDialog();
            }
            else
            {
                MessageBox.Show("Odaberite za kojeg studenta zelite ucitati podatke");
                return;
            }
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke(List<Student> s = null)
        {
            dgStudenti.DataSource = null;
            dgStudenti.DataSource = s ?? InMemoryDb.Registrovani;
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            FrmStudentNovii frmStudentDetalji = new FrmStudentNovii(); 
            frmStudentDetalji.ShowDialog();
            UcitajPodatke();
            
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            List<Student> s = new List<Student>();
            foreach (var student in InMemoryDb.Registrovani)
                if(student.BrojIndeksa.ToLower().Contains(txtFilter.Text.ToLower()))
                    s.Add(student);
            UcitajPodatke(s);
        }
    }
}
