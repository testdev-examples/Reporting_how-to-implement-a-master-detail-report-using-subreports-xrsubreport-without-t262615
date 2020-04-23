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
            Me.components = New System.ComponentModel.Container()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim MasterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterReport))
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Title
            '
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1.0!
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            '
            'xrLabel1
            '
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(400.0!, 50.08334!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "xrLabel1"
            '
            'xrPictureBox1
            '
            Me.xrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 0!)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(250.0!, 98.08334!)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageBreak1, Me.xrSubreport1, Me.xrLabel2, Me.xrPictureBox1, Me.xrLabel1})
            Me.Detail.HeightF = 131.5!
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPageBreak1
            '
            Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.xrPageBreak1.Name = "xrPageBreak1"
            '
            'xrSubreport1
            '
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 108.5!)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.ReportSource = New dxSample.DetailReport()
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(650.0!, 23.0!)
            '
            'xrLabel2
            '
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 50.08335!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(400.0!, 48.0!)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "xrLabel2"
            '
            'sqlDataSource1
            '
            Me.sqlDataSource1.ConnectionName = "dxSample.Properties.Settings.nwindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            ColumnExpression1.ColumnName = "CategoryID"
            Table1.Name = "Categories"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "CategoryName"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "Description"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "Picture"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "Icon_17"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "Icon_25"
            ColumnExpression6.Table = Table1
            Column6.Expression = ColumnExpression6
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Columns.Add(Column6)
            SelectQuery1.Name = "Categories"
            SelectQuery1.Tables.Add(Table1)
            ColumnExpression7.ColumnName = "ProductID"
            Table2.Name = "Products"
            ColumnExpression7.Table = Table2
            Column7.Expression = ColumnExpression7
            ColumnExpression8.ColumnName = "ProductName"
            ColumnExpression8.Table = Table2
            Column8.Expression = ColumnExpression8
            ColumnExpression9.ColumnName = "SupplierID"
            ColumnExpression9.Table = Table2
            Column9.Expression = ColumnExpression9
            ColumnExpression10.ColumnName = "CategoryID"
            ColumnExpression10.Table = Table2
            Column10.Expression = ColumnExpression10
            ColumnExpression11.ColumnName = "QuantityPerUnit"
            ColumnExpression11.Table = Table2
            Column11.Expression = ColumnExpression11
            ColumnExpression12.ColumnName = "UnitPrice"
            ColumnExpression12.Table = Table2
            Column12.Expression = ColumnExpression12
            ColumnExpression13.ColumnName = "UnitsInStock"
            ColumnExpression13.Table = Table2
            Column13.Expression = ColumnExpression13
            ColumnExpression14.ColumnName = "UnitsOnOrder"
            ColumnExpression14.Table = Table2
            Column14.Expression = ColumnExpression14
            ColumnExpression15.ColumnName = "ReorderLevel"
            ColumnExpression15.Table = Table2
            Column15.Expression = ColumnExpression15
            ColumnExpression16.ColumnName = "Discontinued"
            ColumnExpression16.Table = Table2
            Column16.Expression = ColumnExpression16
            ColumnExpression17.ColumnName = "EAN13"
            ColumnExpression17.Table = Table2
            Column17.Expression = ColumnExpression17
            SelectQuery2.Columns.Add(Column7)
            SelectQuery2.Columns.Add(Column8)
            SelectQuery2.Columns.Add(Column9)
            SelectQuery2.Columns.Add(Column10)
            SelectQuery2.Columns.Add(Column11)
            SelectQuery2.Columns.Add(Column12)
            SelectQuery2.Columns.Add(Column13)
            SelectQuery2.Columns.Add(Column14)
            SelectQuery2.Columns.Add(Column15)
            SelectQuery2.Columns.Add(Column16)
            SelectQuery2.Columns.Add(Column17)
            SelectQuery2.Name = "Products"
            SelectQuery2.Tables.Add(Table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1, SelectQuery2})
            MasterDetailInfo1.DetailQueryName = "Products"
            RelationColumnInfo1.NestedKeyColumn = "CategoryID"
            RelationColumnInfo1.ParentKeyColumn = "CategoryID"
            MasterDetailInfo1.KeyColumns.Add(RelationColumnInfo1)
            MasterDetailInfo1.MasterQueryName = "Categories"
            MasterDetailInfo1.Name = "CategoriesProducts"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {MasterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            '
            'DataField
            '
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1.0!
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            '
            'TopMargin
            '
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPageInfo2
            '
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
            Me.xrPageInfo2.StyleName = "PageInfo"
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrPageInfo2.TextFormatString = "Page {0} of {1}"
            '
            'BottomMargin
            '
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'FieldCaption
            '
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1.0!
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            '
            'xrPageInfo1
            '
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
            Me.xrPageInfo1.StyleName = "PageInfo"
            '
            'pageFooterBand1
            '
            Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
            Me.pageFooterBand1.HeightF = 29.0!
            Me.pageFooterBand1.Name = "pageFooterBand1"
            '
            'PageInfo
            '
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1.0!
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            '
            'MasterReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageFooterBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "19.2"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
        Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
        Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
