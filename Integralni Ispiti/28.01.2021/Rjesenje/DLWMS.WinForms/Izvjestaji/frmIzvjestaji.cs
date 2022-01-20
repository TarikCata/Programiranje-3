using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Student> students;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<Student> dataSource) : this()
        {
            this.students = dataSource;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tbl = new dsDLWMS.StudentiDataTable();
            foreach (var x in students)
            {
                var red = tbl.NewStudentiRow();
                red.Rb = x.Id.ToString();
                red.Indeks = x.Indeks;
                red.Ime = x.Ime;
                red.Prezime = x.Prezime;
                red.Spol = x.Spol.ToString();
                red.Godina = x.GodinaStudija.ToString();
                red.Aktivan = x.Aktivan ? "Da" : "Ne";
                tbl.Rows.Add(red);
            }

            rds.Name = "dsDLWMS";
            rds.Value = tbl;
            
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
