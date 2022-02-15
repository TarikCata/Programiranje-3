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
        private List<string> ocjene = new List<string>() { "6","7","8","9","10" }; 
        int ocjena;
        public frmPretraga()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }
        private void frmPretraga_Load(object sender, EventArgs e)
        {
            cmbOcjene.DataSource = ocjene;
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            try
            {
                dgvPredmeti.DataSource = null;
                dgvPredmeti.DataSource = db.StudentiPredmeti.Where(x => x.Ocjena >= ocjena).ToList();
                this.Text = $"Broj zapisa: {dgvPredmeti.RowCount}";
            }
            catch (Exception rx)
            {

                throw new Exception(rx.Message);
            }
        }
        private void cmbOcjene_SelectedIndexChanged(object sender, EventArgs e)
        {
            ocjena = Convert.ToInt32(cmbOcjene.Text);
        }
        private void btnPretraga_Click(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void dgvPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var sp = dgvPredmeti.CurrentRow.DataBoundItem as StudentiPredmeti;
                Hide();
                new frmPredmetiSeminarski(sp).ShowDialog();
                Show();
            }
        }
    }
}
