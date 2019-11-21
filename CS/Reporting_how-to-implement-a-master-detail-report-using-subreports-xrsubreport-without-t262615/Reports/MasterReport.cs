using System;
using DevExpress.XtraReports.UI;

namespace dxSample {
    public partial class MasterReport : DevExpress.XtraReports.UI.XtraReport {
        public MasterReport() {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRSubreport xrSubReport = (XRSubreport)sender;
            DetailReport subRep = xrSubReport.ReportSource as DetailReport;
            subRep.Parameters["CatID"].Value = Convert.ToInt32(GetCurrentColumnValue("CategoryID"));
        }
    }
}
