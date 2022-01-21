using DLWMS.WinForms.IB200252;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<KorisniciIspitiScan> sken;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<KorisniciIspitiScan> sken)
        {
            this.sken = sken;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            var tableScan = new dsDLWMS.ScanDataTable();
            foreach (var obj in sken)
            {
                var red = tableScan.NewRow();
                
            }
        }

        private void reportViewer1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
