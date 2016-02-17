namespace UI_Tier
{
    partial class quanlynguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlynguoidung));
            this.dataDataSet = new UI_Tier.dataDataSet();
            this.dangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangNhapTableAdapter = new UI_Tier.dataDataSetTableAdapters.DangNhapTableAdapter();
            this.tableAdapterManager = new UI_Tier.dataDataSetTableAdapters.TableAdapterManager();
            this.giaoVienTableAdapter = new UI_Tier.dataDataSetTableAdapters.GiaoVienTableAdapter();
            this.dangNhapBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dangNhapBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmagiaovien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmatkhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphanquyennguoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingNavigator)).BeginInit();
            this.dangNhapBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangNhapBindingSource
            // 
            this.dangNhapBindingSource.DataMember = "DangNhap";
            this.dangNhapBindingSource.DataSource = this.dataDataSet;
            // 
            // dangNhapTableAdapter
            // 
            this.dangNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DangNhapTableAdapter = this.dangNhapTableAdapter;
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
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // dangNhapBindingNavigator
            // 
            this.dangNhapBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dangNhapBindingNavigator.BindingSource = this.dangNhapBindingSource;
            this.dangNhapBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dangNhapBindingNavigator.CountItemFormat = "/{0}";
            this.dangNhapBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dangNhapBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripButton1,
            this.bindingNavigatorDeleteItem,
            this.dangNhapBindingNavigatorSaveItem});
            this.dangNhapBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dangNhapBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dangNhapBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dangNhapBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dangNhapBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dangNhapBindingNavigator.Name = "dangNhapBindingNavigator";
            this.dangNhapBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dangNhapBindingNavigator.Size = new System.Drawing.Size(667, 25);
            this.dangNhapBindingNavigator.TabIndex = 0;
            this.dangNhapBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(26, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dangNhapBindingNavigatorSaveItem
            // 
            this.dangNhapBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dangNhapBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dangNhapBindingNavigatorSaveItem.Image")));
            this.dangNhapBindingNavigatorSaveItem.Name = "dangNhapBindingNavigatorSaveItem";
            this.dangNhapBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dangNhapBindingNavigatorSaveItem.Text = "Save Data";
            this.dangNhapBindingNavigatorSaveItem.Click += new System.EventHandler(this.dangNhapBindingNavigatorSaveItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.giaoVienBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            this.gridControl1.Size = new System.Drawing.Size(667, 289);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.dataDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmagiaovien,
            this.colmatkhau,
            this.colphanquyennguoidung,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colmagiaovien
            // 
            this.colmagiaovien.Caption = "Mã giáo viên";
            this.colmagiaovien.ColumnEdit = this.repositoryItemComboBox1;
            this.colmagiaovien.FieldName = "magiaovien";
            this.colmagiaovien.Name = "colmagiaovien";
            this.colmagiaovien.Visible = true;
            this.colmagiaovien.VisibleIndex = 0;
            this.colmagiaovien.Width = 227;
            // 
            // colmatkhau
            // 
            this.colmatkhau.FieldName = "matkhau";
            this.colmatkhau.Name = "colmatkhau";
            // 
            // colphanquyennguoidung
            // 
            this.colphanquyennguoidung.Caption = "Phân quyền";
            this.colphanquyennguoidung.ColumnEdit = this.repositoryItemComboBox2;
            this.colphanquyennguoidung.FieldName = "phanquyennguoidung";
            this.colphanquyennguoidung.Name = "colphanquyennguoidung";
            this.colphanquyennguoidung.Visible = true;
            this.colphanquyennguoidung.VisibleIndex = 2;
            this.colphanquyennguoidung.Width = 261;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên giáo viên";
            this.gridColumn1.FieldName = "tengiaovien";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 168;
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
            // quanlynguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 314);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dangNhapBindingNavigator);
            this.Name = "quanlynguoidung";
            this.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.quanlynguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingNavigator)).EndInit();
            this.dangNhapBindingNavigator.ResumeLayout(false);
            this.dangNhapBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource dangNhapBindingSource;
        private dataDataSetTableAdapters.DangNhapTableAdapter dangNhapTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dangNhapBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dangNhapBindingNavigatorSaveItem;
        private dataDataSetTableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmagiaovien;
        private DevExpress.XtraGrid.Columns.GridColumn colmatkhau;
        private DevExpress.XtraGrid.Columns.GridColumn colphanquyennguoidung;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
    }
}