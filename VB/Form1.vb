Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace ComplexProperty
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private session1 As Session
		Private xpCollection1 As XPCollection
		Private colOid As DevExpress.XtraGrid.Columns.GridColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
			Me.session1 = New DevExpress.Xpo.Session()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(13, 173)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(84, 20)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Name:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(13, 201)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(84, 20)
			Me.label2.TabIndex = 3
			Me.label2.Text = "City:"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xpCollection1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(435, 152)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' xpCollection1
			' 
			Me.xpCollection1.DisplayableProperties = "This;Oid;Name;Address!;Address!Key;Address"
			Me.xpCollection1.ObjectType = GetType(ComplexProperty.Person)
			Me.xpCollection1.Session = Me.session1
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOid, Me.colName, Me.gridColumn1, Me.gridColumn2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.EnableMasterViewMode = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			' 
			' colOid
			' 
			Me.colOid.Caption = "Oid"
			Me.colOid.FieldName = "Oid"
			Me.colOid.Name = "colOid"
			Me.colOid.OptionsColumn.ReadOnly = True
			Me.colOid.Visible = True
			Me.colOid.VisibleIndex = 0
			Me.colOid.Width = 64
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 1
			Me.colName.Width = 94
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Address.AddressLine1"
			Me.gridColumn1.FieldName = "Address.AddressLine1"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 2
			Me.gridColumn1.Width = 173
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Address.City"
			Me.gridColumn2.FieldName = "Address.City"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 3
			Me.gridColumn2.Width = 178
			' 
			' textEdit1
			' 
			Me.textEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Name", True))
			Me.textEdit1.Location = New System.Drawing.Point(60, 170)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(234, 20)
			Me.textEdit1.TabIndex = 5
			' 
			' textEdit2
			' 
			Me.textEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Address.City", True))
			Me.textEdit2.Location = New System.Drawing.Point(60, 198)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(234, 20)
			Me.textEdit2.TabIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(435, 238)
			Me.Controls.Add(Me.textEdit2)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			XpoDefault.DataLayer = XpoDefault.GetDataLayer(AutoCreateOption.DatabaseAndSchema)
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			If xpCollection1.Count = 0 Then
				Dim person As New Person(session1)
				person.Name = "Adam"
				Dim addr As New Address(session1)
				addr.AddressLine1 = "Apple st., 1"
				addr.City = "Edem"
				addr.Zip = "111"
				person.Address = addr
				person.Save()
				xpCollection1.Add(person)

				person = New Person(session1)
				person.Name = "Freddy"
				addr = New Address(session1)
				addr.AddressLine1 = "Elm st., 13"
				addr.City = "San-city"
				addr.Zip = "222"
				person.Address = addr
				person.Save()
				xpCollection1.Add(person)
			End If
		End Sub
	End Class
End Namespace
