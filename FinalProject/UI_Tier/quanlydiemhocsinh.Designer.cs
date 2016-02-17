namespace UI_Tier
{
    partial class quanlydiemhocsinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlydiemhocsinh));
            System.Windows.Forms.Label mahocsinhLabel;
            System.Windows.Forms.Label mamonhocLabel;
            System.Windows.Forms.Label hockyLabel;
            System.Windows.Forms.Label namhocLabel;
            System.Windows.Forms.Label diemLabel;
            System.Windows.Forms.Label hesoLabel;
            this.dataDataSet = new UI_Tier.dataDataSet();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemTableAdapter = new UI_Tier.dataDataSetTableAdapters.DiemTableAdapter();
            this.tableAdapterManager = new UI_Tier.dataDataSetTableAdapters.TableAdapterManager();
            this.diemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.diemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahocsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmamonhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhocky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnamhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colheso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mahocsinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diemSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.hesoSpinEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.hockyTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.namhocTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.mamonhocTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            mahocsinhLabel = new System.Windows.Forms.Label();
            mamonhocLabel = new System.Windows.Forms.Label();
            hockyLabel = new System.Windows.Forms.Label();
            namhocLabel = new System.Windows.Forms.Label();
            diemLabel = new System.Windows.Forms.Label();
            hesoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingNavigator)).BeginInit();
            this.diemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahocsinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namhocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamonhocTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            this.diemBindingSource.DataSource = this.dataDataSet;
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DangNhapTableAdapter = null;
            this.tableAdapterManager.DanhGiaTableAdapter = null;
            this.tableAdapterManager.DiemTableAdapter = this.diemTableAdapter;
            this.tableAdapterManager.GiaoVienTableAdapter = null;
            this.tableAdapterManager.HocKy_NamHocTableAdapter = null;
            this.tableAdapterManager.HocSinhTableAdapter = null;
            this.tableAdapterManager.KhoiTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.ToBoMonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UI_Tier.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // diemBindingNavigator
            // 
            this.diemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.diemBindingNavigator.BindingSource = this.diemBindingSource;
            this.diemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.diemBindingNavigator.CountItemFormat = "/{0}";
            this.diemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.diemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.diemBindingNavigatorSaveItem});
            this.diemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.diemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.diemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.diemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.diemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.diemBindingNavigator.Name = "diemBindingNavigator";
            this.diemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.diemBindingNavigator.Size = new System.Drawing.Size(890, 25);
            this.diemBindingNavigator.TabIndex = 0;
            this.diemBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(26, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // diemBindingNavigatorSaveItem
            // 
            this.diemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.diemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("diemBindingNavigatorSaveItem.Image")));
            this.diemBindingNavigatorSaveItem.Name = "diemBindingNavigatorSaveItem";
            this.diemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.diemBindingNavigatorSaveItem.Text = "Save Data";
            this.diemBindingNavigatorSaveItem.Click += new System.EventHandler(this.diemBindingNavigatorSaveItem_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 25);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(890, 334);
            this.splitContainerControl1.SplitterPosition = 397;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.diemBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3});
            this.gridControl1.Size = new System.Drawing.Size(488, 334);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmahocsinh,
            this.colmamonhoc,
            this.colhocky,
            this.colnamhoc,
            this.coldiem,
            this.colheso});
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
            // colmamonhoc
            // 
            this.colmamonhoc.Caption = "Mã môn học";
            this.colmamonhoc.ColumnEdit = this.repositoryItemComboBox3;
            this.colmamonhoc.FieldName = "mamonhoc";
            this.colmamonhoc.Name = "colmamonhoc";
            this.colmamonhoc.Visible = true;
            this.colmamonhoc.VisibleIndex = 1;
            // 
            // colhocky
            // 
            this.colhocky.Caption = "Học kỳ";
            this.colhocky.ColumnEdit = this.repositoryItemComboBox2;
            this.colhocky.FieldName = "hocky";
            this.colhocky.Name = "colhocky";
            this.colhocky.Visible = true;
            this.colhocky.VisibleIndex = 2;
            // 
            // colnamhoc
            // 
            this.colnamhoc.Caption = "Năm học";
            this.colnamhoc.ColumnEdit = this.repositoryItemComboBox1;
            this.colnamhoc.FieldName = "namhoc";
            this.colnamhoc.Name = "colnamhoc";
            this.colnamhoc.Visible = true;
            this.colnamhoc.VisibleIndex = 3;
            // 
            // coldiem
            // 
            this.coldiem.Caption = "Điểm";
            this.coldiem.FieldName = "diem";
            this.coldiem.Name = "coldiem";
            this.coldiem.Visible = true;
            this.coldiem.VisibleIndex = 5;
            // 
            // colheso
            // 
            this.colheso.Caption = "Hệ số điểm";
            this.colheso.FieldName = "heso";
            this.colheso.Name = "colheso";
            this.colheso.Visible = true;
            this.colheso.VisibleIndex = 4;
            // 
            // mahocsinhLabel
            // 
            mahocsinhLabel.AutoSize = true;
            mahocsinhLabel.Location = new System.Drawing.Point(18, 30);
            mahocsinhLabel.Name = "mahocsinhLabel";
            mahocsinhLabel.Size = new System.Drawing.Size(63, 13);
            mahocsinhLabel.TabIndex = 0;
            mahocsinhLabel.Text = "Mã học sinh";
            // 
            // mahocsinhTextEdit
            // 
            this.mahocsinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemBindingSource, "mahocsinh", true));
            this.mahocsinhTextEdit.Location = new System.Drawing.Point(86, 27);
            this.mahocsinhTextEdit.Name = "mahocsinhTextEdit";
            this.mahocsinhTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mahocsinhTextEdit.TabIndex = 1;
            // 
            // mamonhocLabel
            // 
            mamonhocLabel.AutoSize = true;
            mamonhocLabel.Location = new System.Drawing.Point(192, 30);
            mamonhocLabel.Name = "mamonhocLabel";
            mamonhocLabel.Size = new System.Drawing.Size(64, 13);
            mamonhocLabel.TabIndex = 2;
            mamonhocLabel.Text = "Mã môn học";
            // 
            // hockyLabel
            // 
            hockyLabel.AutoSize = true;
            hockyLabel.Location = new System.Drawing.Point(18, 59);
            hockyLabel.Name = "hockyLabel";
            hockyLabel.Size = new System.Drawing.Size(39, 13);
            hockyLabel.TabIndex = 4;
            hockyLabel.Text = "Học kỳ";
            // 
            // namhocLabel
            // 
            namhocLabel.AutoSize = true;
            namhocLabel.Location = new System.Drawing.Point(192, 59);
            namhocLabel.Name = "namhocLabel";
            namhocLabel.Size = new System.Drawing.Size(48, 13);
            namhocLabel.TabIndex = 6;
            namhocLabel.Text = "Năm học";
            // 
            // diemLabel
            // 
            diemLabel.AutoSize = true;
            diemLabel.Location = new System.Drawing.Point(192, 88);
            diemLabel.Name = "diemLabel";
            diemLabel.Size = new System.Drawing.Size(45, 13);
            diemLabel.TabIndex = 8;
            diemLabel.Text = "Điểm số";
            // 
            // diemSpinEdit
            // 
            this.diemSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemBindingSource, "diem", true));
            this.diemSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.diemSpinEdit.Location = new System.Drawing.Point(260, 85);
            this.diemSpinEdit.Name = "diemSpinEdit";
            this.diemSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.diemSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.diemSpinEdit.TabIndex = 9;
            // 
            // hesoLabel
            // 
            hesoLabel.AutoSize = true;
            hesoLabel.Location = new System.Drawing.Point(18, 88);
            hesoLabel.Name = "hesoLabel";
            hesoLabel.Size = new System.Drawing.Size(59, 13);
            hesoLabel.TabIndex = 10;
            hesoLabel.Text = "Hệ số điểm";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(mahocsinhLabel);
            this.groupControl1.Controls.Add(this.mahocsinhTextEdit);
            this.groupControl1.Controls.Add(hesoLabel);
            this.groupControl1.Controls.Add(mamonhocLabel);
            this.groupControl1.Controls.Add(this.diemSpinEdit);
            this.groupControl1.Controls.Add(diemLabel);
            this.groupControl1.Controls.Add(hockyLabel);
            this.groupControl1.Controls.Add(namhocLabel);
            this.groupControl1.Controls.Add(this.hesoSpinEdit);
            this.groupControl1.Controls.Add(this.hockyTextEdit);
            this.groupControl1.Controls.Add(this.namhocTextEdit);
            this.groupControl1.Controls.Add(this.mamonhocTextEdit);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(391, 123);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Thông tin điểm số";
            // 
            // hesoSpinEdit
            // 
            this.hesoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemBindingSource, "heso", true));
            this.hesoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hesoSpinEdit.Location = new System.Drawing.Point(86, 85);
            this.hesoSpinEdit.Name = "hesoSpinEdit";
            this.hesoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hesoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.hesoSpinEdit.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(363, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(23, 19);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // hockyTextEdit
            // 
            this.hockyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemBindingSource, "hocky", true));
            this.hockyTextEdit.Location = new System.Drawing.Point(86, 56);
            this.hockyTextEdit.Name = "hockyTextEdit";
            this.hockyTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hockyTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hockyTextEdit.TabIndex = 5;
            // 
            // namhocTextEdit
            // 
            this.namhocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemBindingSource, "namhoc", true));
            this.namhocTextEdit.Location = new System.Drawing.Point(260, 56);
            this.namhocTextEdit.Name = "namhocTextEdit";
            this.namhocTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.namhocTextEdit.Size = new System.Drawing.Size(100, 20);
            this.namhocTextEdit.TabIndex = 7;
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
            // mamonhocTextEdit
            // 
            this.mamonhocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemBindingSource, "mamonhoc", true));
            this.mamonhocTextEdit.Location = new System.Drawing.Point(260, 27);
            this.mamonhocTextEdit.Name = "mamonhocTextEdit";
            this.mamonhocTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mamonhocTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mamonhocTextEdit.TabIndex = 3;
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
            // quanlydiemhocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 359);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.diemBindingNavigator);
            this.Name = "quanlydiemhocsinh";
            this.Text = "QUẢN LÝ ĐIỂM HỌC SINH";
            this.Load += new System.EventHandler(this.quanlydiemhocsinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingNavigator)).EndInit();
            this.diemBindingNavigator.ResumeLayout(false);
            this.diemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahocsinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namhocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamonhocTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private dataDataSetTableAdapters.DiemTableAdapter diemTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator diemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton diemBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit mahocsinhTextEdit;
        private DevExpress.XtraEditors.SpinEdit diemSpinEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmahocsinh;
        private DevExpress.XtraGrid.Columns.GridColumn colmamonhoc;
        private DevExpress.XtraGrid.Columns.GridColumn colhocky;
        private DevExpress.XtraGrid.Columns.GridColumn colnamhoc;
        private DevExpress.XtraGrid.Columns.GridColumn coldiem;
        private DevExpress.XtraGrid.Columns.GridColumn colheso;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit hesoSpinEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit hockyTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit namhocTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit mamonhocTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;


    }
}