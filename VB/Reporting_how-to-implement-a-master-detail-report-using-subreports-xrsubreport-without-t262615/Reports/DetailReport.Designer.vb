﻿Namespace dxSample
	Partial Public Class DetailReport
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
			Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DetailReport))
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.CatID = New DevExpress.XtraReports.Parameters.Parameter()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
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
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "dxSample.Properties.Settings.nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			tableQuery1.Name = "Products"
			tableInfo1.Name = "Products"
			columnInfo1.Name = "ProductID"
			columnInfo2.Name = "ProductName"
			columnInfo3.Name = "SupplierID"
			columnInfo4.Name = "CategoryID"
			columnInfo5.Name = "QuantityPerUnit"
			columnInfo6.Name = "UnitPrice"
			columnInfo7.Name = "UnitsInStock"
			columnInfo8.Name = "UnitsOnOrder"
			columnInfo9.Name = "ReorderLevel"
			columnInfo10.Name = "Discontinued"
			columnInfo11.Name = "EAN13"
			tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11})
			tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable1
			' 
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.Weight = 0.2857142857142857R
			' 
			' CatID
			' 
			Me.CatID.Description = "Parameter1"
			Me.CatID.Name = "CatID"
			Me.CatID.Type = GetType(Integer)
			Me.CatID.ValueInfo = "0"
			Me.CatID.Visible = False
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.Weight = 0.2857142857142857R
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 0.2857142857142857R
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
			' DetailReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Products"
			Me.DataSource = Me.sqlDataSource1
			Me.FilterString = "[CategoryID] = ?CatID"
			Me.Margins = New System.Drawing.Printing.Margins(0, 0, 100, 100)
			Me.PageHeight = 1200
			Me.PageWidth = 650
			Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.CatID})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
			Me.Version = "15.1"
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private CatID As DevExpress.XtraReports.Parameters.Parameter
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private DataField As DevExpress.XtraReports.UI.XRControlStyle
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle


	End Class
End Namespace
