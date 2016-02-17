namespace UI_Tier
{
    partial class quanlyhanhkiem
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
            System.Windows.Forms.Label mahocsinhLabel;
            System.Windows.Forms.Label hanhkiemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlyhanhkiem));
            this.dataDataSet = new UI_Tier.dataDataSet();
            this.danhGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhGiaTableAdapter = new UI_Tier.dataDataSetTableAdapters.DanhGiaTableAdapter();
            this.tableAdapterManager = new UI_Tier.dataDataSetTableAdapters.TableAdapterManager();
            this.danhGiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.danhGiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mahocsinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hanhkiemTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahocsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhocluc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhanhkiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            mahocsinhLabel = new System.Windows.Forms.Label();
            hanhkiemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingNavigator)).BeginInit();
            this.danhGiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahocsinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanhkiemTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mahocsinhLabel
            // 
            mahocsinhLabel.AutoSize = true;
            mahocsinhLabel.Location = new System.Drawing.Point(311, 5);
            mahocsinhLabel.Name = "mahocsinhLabel";
            mahocsinhLabel.Size = new System.Drawing.Size(63, 13);
            mahocsinhLabel.TabIndex = 1;
            mahocsinhLabel.Text = "Mã học sinh";
            // 
            // hanhkiemLabel
            // 
            hanhkiemLabel.AutoSize = true;
            hanhkiemLabel.Location = new System.Drawing.Point(486, 5);
            hanhkiemLabel.Name = "hanhkiemLabel";
            hanhkiemLabel.Size = new System.Drawing.Size(56, 13);
            hanhkiemLabel.TabIndex = 5;
            hanhkiemLabel.Text = "Hạnh kiểm";
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhGiaBindingSource
            // 
            this.danhGiaBindingSource.DataMember = "DanhGia";
            this.danhGiaBindingSource.DataSource = this.dataDataSet;
            // 
            // danhGiaTableAdapter
            // 
            this.danhGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DangNhapTableAdapter = null;
            this.tableAdapterManager.DanhGiaTableAdapter = this.danhGiaTableAdapter;
            this.tableAdapterManager.DiemTableAdapter = null;
            this.tableAdapterManager.GiaoVienTableAdapter = null;
            this.tableAdapterManager.HocKy_NamHocTableAdapter = null;
            this.tableAdapterManager.HocSinhTableAdapter = null;
            this.tableAdapterManager.KhoiTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.ToBoMonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UI_Tier.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // danhGiaBindingNavigator
            // 
            this.danhGiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.danhGiaBindingNavigator.BindingSource = this.danhGiaBindingSource;
            this.danhGiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.danhGiaBindingNavigator.CountItemFormat = "/ {0}";
            this.danhGiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.danhGiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.danhGiaBindingNavigatorSaveItem});
            this.danhGiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.danhGiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.danhGiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.danhGiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.danhGiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.danhGiaBindingNavigator.Name = "danhGiaBindingNavigator";
            this.danhGiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.danhGiaBindingNavigator.Size = new System.Drawing.Size(736, 25);
            this.danhGiaBindingNavigator.TabIndex = 0;
            this.danhGiaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
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
            // danhGiaBindingNavigatorSaveItem
            // 
            this.danhGiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.danhGiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("danhGiaBindingNavigatorSaveItem.Image")));
            this.danhGiaBindingNavigatorSaveItem.Name = "danhGiaBindingNavigatorSaveItem";
            this.danhGiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.danhGiaBindingNavigatorSaveItem.Text = "Save Data";
            this.danhGiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.danhGiaBindingNavigatorSaveItem_Click);
            // 
            // mahocsinhTextEdit
            // 
            this.mahocsinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "mahocsinh", true));
            this.mahocsinhTextEdit.Location = new System.Drawing.Point(380, 2);
            this.mahocsinhTextEdit.Name = "mahocsinhTextEdit";
            this.mahocsinhTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mahocsinhTextEdit.TabIndex = 2;
            // 
            // hanhkiemTextEdit
            // 
            this.hanhkiemTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "hanhkiem", true));
            this.hanhkiemTextEdit.Location = new System.Drawing.Point(548, 2);
            this.hanhkiemTextEdit.Name = "hanhkiemTextEdit";
            this.hanhkiemTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hanhkiemTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hanhkiemTextEdit.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.danhGiaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(736, 301);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmahocsinh,
            this.colhocluc,
            this.colhanhkiem});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // colhocluc
            // 
            this.colhocluc.FieldName = "hocluc";
            this.colhocluc.Name = "colhocluc";
            // 
            // colhanhkiem
            // 
            this.colhanhkiem.Caption = "Hạnh kiểm";
            this.colhanhkiem.ColumnEdit = this.repositoryItemComboBox1;
            this.colhanhkiem.FieldName = "hanhkiem";
            this.colhanhkiem.Name = "colhanhkiem";
            this.colhanhkiem.Visible = true;
            this.colhanhkiem.VisibleIndex = 1;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // quanlyhanhkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 326);
            this.Controls.Add(mahocsinhLabel);
            this.Controls.Add(this.hanhkiemTextEdit);
            this.Controls.Add(hanhkiemLabel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.mahocsinhTextEdit);
            this.Controls.Add(this.danhGiaBindingNavigator);
            this.Name = "quanlyhanhkiem";
            this.Text = "QUẢN LÝ HẠNH KIỂM";
            this.Load += new System.EventHandler(this.quanlyhanhkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingNavigator)).EndInit();
            this.danhGiaBindingNavigator.ResumeLayout(false);
            this.danhGiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahocsinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanhkiemTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource danhGiaBindingSource;
        private dataDataSetTableAdapters.DanhGiaTableAdapter danhGiaTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator danhGiaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton danhGiaBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit mahocsinhTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit hanhkiemTextEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colmahocsinh;
        private DevExpress.XtraGrid.Columns.GridColumn colhocluc;
        private DevExpress.XtraGrid.Columns.GridColumn colhanhkiem;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}