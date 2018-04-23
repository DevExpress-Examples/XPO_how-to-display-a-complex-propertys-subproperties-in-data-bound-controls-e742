using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace ComplexProperty
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form {
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private Session session1;
        private XPCollection xpCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection();
            this.session1 = new DevExpress.Xpo.Session();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "City:";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(435, 152);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpCollection1
            // 
            this.xpCollection1.DisplayableProperties = "This;Oid;Name;Address!;Address!Key;Address";
            this.xpCollection1.ObjectType = typeof(ComplexProperty.Person);
            this.xpCollection1.Session = this.session1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colName,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colOid
            // 
            this.colOid.Caption = "Oid";
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.OptionsColumn.ReadOnly = true;
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 0;
            this.colOid.Width = 64;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Address.AddressLine1";
            this.gridColumn1.FieldName = "Address.AddressLine1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 173;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Address.City";
            this.gridColumn2.FieldName = "Address.City";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 178;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Name", true));
            this.textEdit1.Location = new System.Drawing.Point(60, 170);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(234, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Address.City", true));
            this.textEdit2.Location = new System.Drawing.Point(60, 198);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(234, 20);
            this.textEdit2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(435, 238);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(AutoCreateOption.DatabaseAndSchema);
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			if(xpCollection1.Count == 0) {
                Person person = new Person(session1);
                person.Name = "Adam";
				Address addr = new Address(session1);
                addr.AddressLine1 = "Apple st., 1";
                addr.City = "Edem";
                addr.Zip = "111";
                person.Address = addr;
				person.Save();
                xpCollection1.Add(person);

				person = new Person(session1);
                person.Name = "Freddy";
                addr = new Address(session1);
                addr.AddressLine1 = "Elm st., 13";
                addr.City = "San-city";
                addr.Zip = "222";
                person.Address = addr;
				person.Save();
                xpCollection1.Add(person);
            }
		}
	}
}
