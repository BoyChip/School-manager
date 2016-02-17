namespace UI_Tier
{
    partial class timkiemgiaovien
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
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoVienTableAdapter = new UI_Tier.dataDataSetTableAdapters.GiaoVienTableAdapter();
            this.tableAdapterManager = new UI_Tier.dataDataSetTableAdapters.TableAdapterManager();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmagiaovien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhogiaovien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltengiaovien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchucvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchuyenmon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_to_bomon = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.dataDataSet;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DangNhapTableAdapter = null;
            this.tableAdapterManager.DanhGiaTableAdapter = null;
            this.tableAdapterManager.DiemTableAdapter = null;
            this.tableAdapterManager.GiaoVienTableAdapter = this.giaoVienTableAdapter;
            this.tableAdapterManager.HocKy_NamHocTableAdapter = null;
            this.tableAdapterManager.HocSinhTableAdapter = null;
            this.tableAdapterManager.KhoiTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.ToBoMonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UI_Tier.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.giaoVienBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(984, 326);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmagiaovien,
            this.colhogiaovien,
            this.coltengiaovien,
            this.colgioitinh,
            this.colngaysinh,
            this.coldiachi,
            this.coldienthoai,
            this.colchucvu,
            this.colchuyenmon,
            this.colma_to_bomon});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colmagiaovien
            // 
            this.colmagiaovien.Caption = "Mã giáo viên";
            this.colmagiaovien.FieldName = "magiaovien";
            this.colmagiaovien.Name = "colmagiaovien";
            this.colmagiaovien.Visible = true;
            this.colmagiaovien.VisibleIndex = 0;
            // 
            // colhogiaovien
            // 
            this.colhogiaovien.Caption = "Họ";
            this.colhogiaovien.FieldName = "hogiaovien";
            this.colhogiaovien.Name = "colhogiaovien";
            this.colhogiaovien.Visible = true;
            this.colhogiaovien.VisibleIndex = 1;
            // 
            // coltengiaovien
            // 
            this.coltengiaovien.Caption = "Tên";
            this.coltengiaovien.FieldName = "tengiaovien";
            this.coltengiaovien.Name = "coltengiaovien";
            this.coltengiaovien.Visible = true;
            this.coltengiaovien.VisibleIndex = 2;
            // 
            // colgioitinh
            // 
            this.colgioitinh.Caption = "Giới tính";
            this.colgioitinh.FieldName = "gioitinh";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.Visible = true;
            this.colgioitinh.VisibleIndex = 3;
            // 
            // colngaysinh
            // 
            this.colngaysinh.Caption = "Ngày sinh";
            this.colngaysinh.FieldName = "ngaysinh";
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.Visible = true;
            this.colngaysinh.VisibleIndex = 4;
            // 
            // coldiachi
            // 
            this.coldiachi.Caption = "Địa chỉ";
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 5;
            // 
            // coldienthoai
            // 
            this.coldienthoai.Caption = "Điện thoại";
            this.coldienthoai.FieldName = "dienthoai";
            this.coldienthoai.Name = "coldienthoai";
            this.coldienthoai.Visible = true;
            this.coldienthoai.VisibleIndex = 6;
            // 
            // colchucvu
            // 
            this.colchucvu.Caption = "Chức vụ";
            this.colchucvu.FieldName = "chucvu";
            this.colchucvu.Name = "colchucvu";
            this.colchucvu.Visible = true;
            this.colchucvu.VisibleIndex = 7;
            // 
            // colchuyenmon
            // 
            this.colchuyenmon.Caption = "Chuyên môn";
            this.colchuyenmon.FieldName = "chuyenmon";
            this.colchuyenmon.Name = "colchuyenmon";
            this.colchuyenmon.Visible = true;
            this.colchuyenmon.VisibleIndex = 8;
            // 
            // colma_to_bomon
            // 
            this.colma_to_bomon.Caption = "Tổ - bộ môn";
            this.colma_to_bomon.FieldName = "ma_to_bomon";
            this.colma_to_bomon.Name = "colma_to_bomon";
            this.colma_to_bomon.Visible = true;
            this.colma_to_bomon.VisibleIndex = 9;
            // 
            // timkiemgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 326);
            this.Controls.Add(this.gridControl1);
            this.Name = "timkiemgiaovien";
            this.Text = "TRA CỨU GIÁO VIÊN";
            this.Load += new System.EventHandler(this.timkiemgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private dataDataSetTableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmagiaovien;
        private DevExpress.XtraGrid.Columns.GridColumn colhogiaovien;
        private DevExpress.XtraGrid.Columns.GridColumn coltengiaovien;
        private DevExpress.XtraGrid.Columns.GridColumn colgioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldiachi;
        private DevExpress.XtraGrid.Columns.GridColumn coldienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colchucvu;
        private DevExpress.XtraGrid.Columns.GridColumn colchuyenmon;
        private DevExpress.XtraGrid.Columns.GridColumn colma_to_bomon;
    }
}