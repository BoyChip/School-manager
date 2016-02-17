namespace UI_Tier
{
    partial class timkiemhocsinh
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
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocSinhTableAdapter = new UI_Tier.dataDataSetTableAdapters.HocSinhTableAdapter();
            this.tableAdapterManager = new UI_Tier.dataDataSetTableAdapters.TableAdapterManager();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahocsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmalop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhohocsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhocsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoisinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldantoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhotencha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnghenghiepcha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhotenme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnghenghiepme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataMember = "HocSinh";
            this.hocSinhBindingSource.DataSource = this.dataDataSet;
            // 
            // hocSinhTableAdapter
            // 
            this.hocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DangNhapTableAdapter = null;
            this.tableAdapterManager.DanhGiaTableAdapter = null;
            this.tableAdapterManager.DiemTableAdapter = null;
            this.tableAdapterManager.GiaoVienTableAdapter = null;
            this.tableAdapterManager.HocKy_NamHocTableAdapter = null;
            this.tableAdapterManager.HocSinhTableAdapter = this.hocSinhTableAdapter;
            this.tableAdapterManager.KhoiTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.ToBoMonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UI_Tier.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hocSinhBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 330);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmahocsinh,
            this.colmalop,
            this.colhohocsinh,
            this.coltenhocsinh,
            this.colgioitinh,
            this.colngaysinh,
            this.colnoisinh,
            this.coldantoc,
            this.coldiachi,
            this.colhotencha,
            this.colnghenghiepcha,
            this.colhotenme,
            this.colnghenghiepme,
            this.coldienthoai,
            this.colghichu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colmahocsinh
            // 
            this.colmahocsinh.FieldName = "mahocsinh";
            this.colmahocsinh.Name = "colmahocsinh";
            this.colmahocsinh.Visible = true;
            this.colmahocsinh.VisibleIndex = 0;
            // 
            // colmalop
            // 
            this.colmalop.FieldName = "malop";
            this.colmalop.Name = "colmalop";
            this.colmalop.Visible = true;
            this.colmalop.VisibleIndex = 1;
            // 
            // colhohocsinh
            // 
            this.colhohocsinh.FieldName = "hohocsinh";
            this.colhohocsinh.Name = "colhohocsinh";
            this.colhohocsinh.Visible = true;
            this.colhohocsinh.VisibleIndex = 2;
            // 
            // coltenhocsinh
            // 
            this.coltenhocsinh.FieldName = "tenhocsinh";
            this.coltenhocsinh.Name = "coltenhocsinh";
            this.coltenhocsinh.Visible = true;
            this.coltenhocsinh.VisibleIndex = 3;
            // 
            // colgioitinh
            // 
            this.colgioitinh.FieldName = "gioitinh";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.Visible = true;
            this.colgioitinh.VisibleIndex = 4;
            // 
            // colngaysinh
            // 
            this.colngaysinh.FieldName = "ngaysinh";
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.Visible = true;
            this.colngaysinh.VisibleIndex = 5;
            // 
            // colnoisinh
            // 
            this.colnoisinh.FieldName = "noisinh";
            this.colnoisinh.Name = "colnoisinh";
            this.colnoisinh.Visible = true;
            this.colnoisinh.VisibleIndex = 6;
            // 
            // coldantoc
            // 
            this.coldantoc.FieldName = "dantoc";
            this.coldantoc.Name = "coldantoc";
            this.coldantoc.Visible = true;
            this.coldantoc.VisibleIndex = 7;
            // 
            // coldiachi
            // 
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 8;
            // 
            // colhotencha
            // 
            this.colhotencha.FieldName = "hotencha";
            this.colhotencha.Name = "colhotencha";
            this.colhotencha.Visible = true;
            this.colhotencha.VisibleIndex = 9;
            // 
            // colnghenghiepcha
            // 
            this.colnghenghiepcha.FieldName = "nghenghiepcha";
            this.colnghenghiepcha.Name = "colnghenghiepcha";
            this.colnghenghiepcha.Visible = true;
            this.colnghenghiepcha.VisibleIndex = 10;
            // 
            // colhotenme
            // 
            this.colhotenme.FieldName = "hotenme";
            this.colhotenme.Name = "colhotenme";
            this.colhotenme.Visible = true;
            this.colhotenme.VisibleIndex = 11;
            // 
            // colnghenghiepme
            // 
            this.colnghenghiepme.FieldName = "nghenghiepme";
            this.colnghenghiepme.Name = "colnghenghiepme";
            this.colnghenghiepme.Visible = true;
            this.colnghenghiepme.VisibleIndex = 12;
            // 
            // coldienthoai
            // 
            this.coldienthoai.FieldName = "dienthoai";
            this.coldienthoai.Name = "coldienthoai";
            this.coldienthoai.Visible = true;
            this.coldienthoai.VisibleIndex = 13;
            // 
            // colghichu
            // 
            this.colghichu.FieldName = "ghichu";
            this.colghichu.Name = "colghichu";
            this.colghichu.Visible = true;
            this.colghichu.VisibleIndex = 14;
            // 
            // timkiemhocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 330);
            this.Controls.Add(this.gridControl1);
            this.Name = "timkiemhocsinh";
            this.Text = "TRA CỨU HỌC SINH";
            this.Load += new System.EventHandler(this.timkiemhocsinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private dataDataSetTableAdapters.HocSinhTableAdapter hocSinhTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmahocsinh;
        private DevExpress.XtraGrid.Columns.GridColumn colmalop;
        private DevExpress.XtraGrid.Columns.GridColumn colhohocsinh;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhocsinh;
        private DevExpress.XtraGrid.Columns.GridColumn colgioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colnoisinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldantoc;
        private DevExpress.XtraGrid.Columns.GridColumn coldiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colhotencha;
        private DevExpress.XtraGrid.Columns.GridColumn colnghenghiepcha;
        private DevExpress.XtraGrid.Columns.GridColumn colhotenme;
        private DevExpress.XtraGrid.Columns.GridColumn colnghenghiepme;
        private DevExpress.XtraGrid.Columns.GridColumn coldienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colghichu;
    }
}