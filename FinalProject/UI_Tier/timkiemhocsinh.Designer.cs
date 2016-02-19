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
            this.coldienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
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
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4});
            this.gridControl1.Size = new System.Drawing.Size(1162, 330);
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
            this.coldienthoai,
            this.colghichu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colmahocsinh
            // 
            this.colmahocsinh.Caption = "Mã học sinh";
            this.colmahocsinh.FieldName = "mahocsinh";
            this.colmahocsinh.Name = "colmahocsinh";
            this.colmahocsinh.Visible = true;
            this.colmahocsinh.VisibleIndex = 0;
            // 
            // colmalop
            // 
            this.colmalop.Caption = "Mã lớp";
            this.colmalop.ColumnEdit = this.repositoryItemComboBox1;
            this.colmalop.FieldName = "malop";
            this.colmalop.Name = "colmalop";
            this.colmalop.Visible = true;
            this.colmalop.VisibleIndex = 1;
            // 
            // colhohocsinh
            // 
            this.colhohocsinh.Caption = "Họ";
            this.colhohocsinh.FieldName = "hohocsinh";
            this.colhohocsinh.Name = "colhohocsinh";
            this.colhohocsinh.Visible = true;
            this.colhohocsinh.VisibleIndex = 2;
            // 
            // coltenhocsinh
            // 
            this.coltenhocsinh.Caption = "Tên";
            this.coltenhocsinh.FieldName = "tenhocsinh";
            this.coltenhocsinh.Name = "coltenhocsinh";
            this.coltenhocsinh.Visible = true;
            this.coltenhocsinh.VisibleIndex = 3;
            // 
            // colgioitinh
            // 
            this.colgioitinh.Caption = "Giới tính";
            this.colgioitinh.ColumnEdit = this.repositoryItemComboBox2;
            this.colgioitinh.FieldName = "gioitinh";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.Visible = true;
            this.colgioitinh.VisibleIndex = 4;
            // 
            // colngaysinh
            // 
            this.colngaysinh.Caption = "Ngày sinh";
            this.colngaysinh.ColumnEdit = this.repositoryItemComboBox3;
            this.colngaysinh.FieldName = "ngaysinh";
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.Visible = true;
            this.colngaysinh.VisibleIndex = 5;
            // 
            // colnoisinh
            // 
            this.colnoisinh.Caption = "Nơi sinh";
            this.colnoisinh.ColumnEdit = this.repositoryItemComboBox4;
            this.colnoisinh.FieldName = "noisinh";
            this.colnoisinh.Name = "colnoisinh";
            this.colnoisinh.Visible = true;
            this.colnoisinh.VisibleIndex = 6;
            // 
            // coldantoc
            // 
            this.coldantoc.Caption = "Dân tộc";
            this.coldantoc.FieldName = "dantoc";
            this.coldantoc.Name = "coldantoc";
            this.coldantoc.Visible = true;
            this.coldantoc.VisibleIndex = 7;
            // 
            // coldiachi
            // 
            this.coldiachi.Caption = "Địa chỉ";
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 8;
            // 
            // coldienthoai
            // 
            this.coldienthoai.Caption = "Điện thoại";
            this.coldienthoai.FieldName = "dienthoai";
            this.coldienthoai.Name = "coldienthoai";
            this.coldienthoai.Visible = true;
            this.coldienthoai.VisibleIndex = 9;
            // 
            // colghichu
            // 
            this.colghichu.Caption = "Ghi chú";
            this.colghichu.FieldName = "ghichu";
            this.colghichu.Name = "colghichu";
            this.colghichu.Visible = true;
            this.colghichu.VisibleIndex = 10;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // timkiemhocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 330);
            this.Controls.Add(this.gridControl1);
            this.Name = "timkiemhocsinh";
            this.Text = "TRA CỨU HỌC SINH";
            this.Load += new System.EventHandler(this.timkiemhocsinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn coldienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colghichu;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
    }
}