Imports System
Imports DevExpress.XtraReports.UI

Namespace dxSample
	Partial Public Class MasterReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
			Dim xrSubReport As XRSubreport = DirectCast(sender, XRSubreport)
			Dim subRep As DetailReport = TryCast(xrSubReport.ReportSource, DetailReport)
			subRep.Parameters("CatID").Value = Convert.ToInt32(GetCurrentColumnValue("CategoryID"))
		End Sub
	End Class
End Namespace
