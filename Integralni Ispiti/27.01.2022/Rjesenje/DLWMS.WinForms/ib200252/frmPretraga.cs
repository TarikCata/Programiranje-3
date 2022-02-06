using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.ib200252
{
    public partial class frmPretraga : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;

        public frmPretraga()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void UcitajPodatke(List<StudentiPredmeti> s  = null)
        {
            try
            {
                dgvPredmeti.DataSource = null;
                dgvPredmeti.DataSource =  s ?? db.StudentiPredmeti.ToList();
                if(s != null)
                    this.Text = $"Broj Zapisa: {s.Count}"; 
                else
                    this.Text = $"Broj Zapisa: {db.StudentiPredmeti.ToList().Count}";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var naziv = txtPretraga.Text.ToLower();
            var lista = db.StudentiPredmeti.Where(x => x.Predmet.Naziv.ToLower().Contains(naziv)).ToList();
            UcitajPodatke(lista);
        }

        private void dgvPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                DialogResult d = MessageBox.Show("Jeste li sigurni da zelite obrisati?","INFO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    var studentPredmet = dgvPredmeti.CurrentRow.DataBoundItem as StudentiPredmeti;
                    db.StudentiPredmeti.Remove(studentPredmet);
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno izbrisano", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UcitajPodatke();
                    
                }
                else
                    return;
            }
            if(e.ColumnIndex == 5)
            {
                var objStudentPredmet = dgvPredmeti.CurrentRow.DataBoundItem as StudentiPredmeti;
                var std = objStudentPredmet.Student;
                this.Hide();
                new frmStudentiSlike(std).ShowDialog();
                this.Show();
            }

        }
    }
}
