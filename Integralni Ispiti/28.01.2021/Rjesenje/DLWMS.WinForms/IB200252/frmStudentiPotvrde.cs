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
    public partial class frmStudentiPotvrde : Form
    {
        private KonekcijaNaBazu db = DLWMSdb.Baza;
        private List<Student> students = new List<Student>(); 
        public frmStudentiPotvrde()
        {
            InitializeComponent();
            dgvPotvrd.AutoGenerateColumns = false;
            students = db.Studenti.ToList();
        }

        private void frmStudentiPotvrde_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvPotvrd.DataSource = null;
            dgvPotvrd.DataSource = db.StudentiPotvrde.ToList(); 
            lblBrojPotvrda.Text = $"Broj potvrda: {db.StudentiPotvrde.ToList().Count}";
        }

        private async void s_Click(object sender, EventArgs e)
        {
            var brojevi = "0123456789";
            if (txtGen.Text == string.Empty || txtGen.Text.Contains(brojevi))
                return;
            var n = Convert.ToInt32(txtGen.Text);
            Action action = () => UcitajPodatke();
            await Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                {
                    Random rnd = new Random();
                    int s = rnd.Next(0,students.Count-1);
                    var b = rnd.Next(2) == 1;
                    var studentPotvrda = new StudentiPotvrde()
                    {
                        Student = students.ElementAt(s),
                        Svrha = $"Svrha {i}",
                        Datum = $"{DateTime.Now}",
                        Izdata = b,
                    };
                    db.StudentiPotvrde.Add(studentPotvrda);
                }
                db.SaveChanges();
                BeginInvoke(action);
            });
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            Action action = () => UcitajPodatke();
            await Task.Run(() =>
            {
                DialogResult d = MessageBox.Show("Jeste li sigurni da zelite sve izbrisati?","INFO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    db.StudentiPotvrde.RemoveRange(db.StudentiPotvrde);
                    db.SaveChanges();
                    BeginInvoke(action);
                }
                else
                    return;
            });
        }
    }
}
