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

        public frmIzvjestaji(List<KorisniciIspitiScan> sken) : this()
        {
            this.sken = sken;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tbl = new dsDLWMS.ScanDataTable();
            foreach (var x in sken)
            {
                var red = tbl.NewScanRow();
                red.Predmet = x.Predmet.Naziv;
                red.Napomena = x.Napomena;
                red.Varanje = x.Varanje ? "Da" : "Ne";
                tbl.Rows.Add(red);
            }

            rds.Name = "dsScan";
            rds.Value = tbl;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
