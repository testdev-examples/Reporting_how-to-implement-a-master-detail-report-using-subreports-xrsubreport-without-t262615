Namespace dxSample
	Partial Public Class MasterReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
			Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
			Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim tableQuery2 As New DevExpress.DataAccess.Sql.TableQuery()
			Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
			Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo15 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo16 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo17 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MasterReport))
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
			Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
			Me.Title.ForeColor = System.Drawing.Color.Maroon
			Me.Title.Name = "Title"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 16F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(400F, 50.08334F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(400F, 0F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(250F, 98.08334F)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageBreak1, Me.xrSubreport1, Me.xrLabel2, Me.xrPictureBox1, Me.xrLabel1})
			Me.Detail.HeightF = 131.5F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrSubreport1
			' 
			Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 108.5F)
			Me.xrSubreport1.Name = "xrSubreport1"
			Me.xrSubreport1.ReportSource = New dxSample.DetailReport()
			Me.xrSubreport1.SizeF = New System.Drawing.SizeF(650F, 23F)
'			Me.xrSubreport1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrSubreport1_BeforePrint)
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 50.08335F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(400F, 48F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "dxSample.Properties.Settings.nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			tableQuery1.Name = "Categories"
			tableInfo1.Name = "Categories"
			columnInfo1.Name = "CategoryID"
			columnInfo2.Name = "CategoryName"
			columnInfo3.Name = "Description"
			columnInfo4.Name = "Picture"
			columnInfo5.Name = "Icon_17"
			columnInfo6.Name = "Icon_25"
			tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6})
			tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
			tableQuery2.Name = "Products"
			tableInfo2.Name = "Products"
			columnInfo7.Name = "ProductID"
			columnInfo8.Name = "ProductName"
			columnInfo9.Name = "SupplierID"
			columnInfo10.Name = "CategoryID"
			columnInfo11.Name = "QuantityPerUnit"
			columnInfo12.Name = "UnitPrice"
			columnInfo13.Name = "UnitsInStock"
			columnInfo14.Name = "UnitsOnOrder"
			columnInfo15.Name = "ReorderLevel"
			columnInfo16.Name = "Discontinued"
			columnInfo17.Name = "EAN13"
			tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12, columnInfo13, columnInfo14, columnInfo15, columnInfo16, columnInfo17})
			tableQuery2.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo2})
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1, tableQuery2})
			masterDetailInfo1.DetailQueryName = "Products"
			relationColumnInfo1.NestedKeyColumn = "CategoryID"
			relationColumnInfo1.ParentKeyColumn = "CategoryID"
			masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
			masterDetailInfo1.MasterQueryName = "Categories"
			masterDetailInfo1.Name = "CategoriesProducts"
			Me.sqlDataSource1.Relations.Add(masterDetailInfo1)
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' DataField
			' 
			Me.DataField.BackColor = System.Drawing.Color.Transparent
			Me.DataField.BorderColor = System.Drawing.Color.Black
			Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DataField.BorderWidth = 1F
			Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
			Me.DataField.ForeColor = System.Drawing.Color.Black
			Me.DataField.Name = "DataField"
			Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.Format = "Page {0} of {1}"
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.xrPageInfo2.StyleName = "PageInfo"
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' FieldCaption
			' 
			Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
			Me.FieldCaption.BorderColor = System.Drawing.Color.Black
			Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.FieldCaption.BorderWidth = 1F
			Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
			Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
			Me.FieldCaption.Name = "FieldCaption"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.xrPageInfo1.StyleName = "PageInfo"
			' 
			' pageFooterBand1
			' 
			Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
			Me.pageFooterBand1.HeightF = 29F
			Me.pageFooterBand1.Name = "pageFooterBand1"
			' 
			' PageInfo
			' 
			Me.PageInfo.BackColor = System.Drawing.Color.Transparent
			Me.PageInfo.BorderColor = System.Drawing.Color.Black
			Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.PageInfo.BorderWidth = 1F
			Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.Black
			Me.PageInfo.Name = "PageInfo"
			' 
			' xrPageBreak1
			' 
			Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPageBreak1.Name = "xrPageBreak1"
			' 
			' MasterReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageFooterBand1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Categories"
			Me.DataSource = Me.sqlDataSource1
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
			Me.Version = "15.1"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private DataField As DevExpress.XtraReports.UI.XRControlStyle
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
		Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak

	End Class
End Namespace
