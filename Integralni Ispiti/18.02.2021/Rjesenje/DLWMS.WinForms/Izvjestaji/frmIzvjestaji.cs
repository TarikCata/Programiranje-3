using DLWMS.WinForms.IB200252;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiCovidTestovi> studentiCovidTestovis;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<StudentiCovidTestovi> studentiCovidTestovis) : this()
        {
            this.studentiCovidTestovis = studentiCovidTestovis;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tbl = new dsDLWMS.CovidiDataTable();
            int br = 1;
            foreach (var x in studentiCovidTestovis)
            {
                var red = tbl.NewCovidiRow();
                red.RB = br.ToString();
                red.Student = x.Student.ToString();
                red.Rezultat = x.Rezultat;
                red.Dostavljen = x.Dostavljen ? "Da" : "Ne";
                tbl.Rows.Add(red);
                br++;
            }

            rds.Name = "dsCovidi";
            rds.Value = tbl;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
