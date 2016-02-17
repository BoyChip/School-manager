namespace UI_Tier
{
    partial class quanlykhoilop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataDataSet = new UI_Tier.dataDataSet();
            this.khoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoiTableAdapter = new UI_Tier.dataDataSetTableAdapters.KhoiTableAdapter();
            this.tableAdapterManager = new UI_Tier.dataDataSetTableAdapters.TableAdapterManager();
            this.khoiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.khoiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmakhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenkhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoiBindingSource
            // 
            this.khoiBindingSource.DataMember = "Khoi";
            this.khoiBindingSource.DataSource = this.dataDataSet;
            // 
            // khoiTableAdapter
            // 
            this.khoiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DangNhapTableAdapter = null;
            this.tableAdapterManager.DanhGiaTableAdapter = null;
            this.tableAdapterManager.DiemTableAdapter = null;
            this.tableAdapterManager.GiaoVienTableAdapter = null;
            this.tableAdapterManager.HocKy_NamHocTableAdapter = null;
            this.tableAdapterManager.HocSinhTableAdapter = null;
            this.tableAdapterManager.KhoiTableAdapter = this.khoiTableAdapter;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.ToBoMonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UI_Tier.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khoiBindingSource1
            // 
            this.khoiBindingSource1.DataMember = "Khoi";
            this.khoiBindingSource1.DataSource = this.dataDataSet;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.khoiBindingSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(291, 141);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // khoiBindingSource2
            // 
            this.khoiBindingSource2.DataMember = "Khoi";
            this.khoiBindingSource2.DataSource = this.dataDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmakhoi,
            this.coltenkhoi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colmakhoi
            // 
            this.colmakhoi.Caption = "Mã khối";
            this.colmakhoi.FieldName = "makhoi";
            this.colmakhoi.Name = "colmakhoi";
            this.colmakhoi.Visible = true;
            this.colmakhoi.VisibleIndex = 0;
            // 
            // coltenkhoi
            // 
            this.coltenkhoi.Caption = "Tên khối";
            this.coltenkhoi.FieldName = "tenkhoi";
            this.coltenkhoi.Name = "coltenkhoi";
            this.coltenkhoi.Visible = true;
            this.coltenkhoi.VisibleIndex = 1;
            // 
            // quanlykhoilop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 141);
            this.Controls.Add(this.gridControl1);
            this.Name = "quanlykhoilop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH KHỐI LỚP";
            this.Load += new System.EventHandler(this.quanlykhoilop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource khoiBindingSource;
        private dataDataSetTableAdapters.KhoiTableAdapter khoiTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource khoiBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource khoiBindingSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmakhoi;
        private DevExpress.XtraGrid.Columns.GridColumn coltenkhoi;
    }
}