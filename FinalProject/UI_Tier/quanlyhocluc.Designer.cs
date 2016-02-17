namespace UI_Tier
{
    partial class quanlyhocluc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlyhocluc));
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahocsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhocluc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhanhkiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit5 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit6 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit7 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mahocsinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoclucTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.hoclucTextEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.hoclucTextEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.hoclucTextEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingNavigator)).BeginInit();
            this.danhGiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahocsinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit3.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.danhGiaBindingNavigator.CountItemFormat = "/{0}";
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
            this.danhGiaBindingNavigator.Size = new System.Drawing.Size(946, 25);
            this.danhGiaBindingNavigator.TabIndex = 0;
            this.danhGiaBindingNavigator.Text = "bindingNavigator1";
            this.danhGiaBindingNavigator.RefreshItems += new System.EventHandler(this.danhGiaBindingNavigator_RefreshItems);
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.danhGiaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(946, 408);
            this.gridControl1.TabIndex = 1;
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
            this.colhocluc.Caption = "Học lực";
            this.colhocluc.ColumnEdit = this.repositoryItemComboBox1;
            this.colhocluc.FieldName = "hocluc";
            this.colhocluc.Name = "colhocluc";
            this.colhocluc.Visible = true;
            this.colhocluc.VisibleIndex = 1;
            this.colhocluc.Width = 661;
            // 
            // colhanhkiem
            // 
            this.colhanhkiem.FieldName = "hanhkiem";
            this.colhanhkiem.Name = "colhanhkiem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học lực";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(580, 5);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(551, 0);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 6;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(521, 0);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit4.Size = new System.Drawing.Size(100, 20);
            this.textEdit4.TabIndex = 7;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(533, 0);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit5.Size = new System.Drawing.Size(100, 20);
            this.textEdit5.TabIndex = 8;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(551, 4);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit6.Size = new System.Drawing.Size(100, 20);
            this.textEdit6.TabIndex = 9;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(533, 3);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit7.Size = new System.Drawing.Size(100, 20);
            this.textEdit7.TabIndex = 10;
            // 
            // mahocsinhTextEdit
            // 
            this.mahocsinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "mahocsinh", true));
            this.mahocsinhTextEdit.Location = new System.Drawing.Point(379, 3);
            this.mahocsinhTextEdit.Name = "mahocsinhTextEdit";
            this.mahocsinhTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mahocsinhTextEdit.TabIndex = 13;
            // 
            // hoclucTextEdit
            // 
            this.hoclucTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "hocluc", true));
            this.hoclucTextEdit.Location = new System.Drawing.Point(533, 3);
            this.hoclucTextEdit.Name = "hoclucTextEdit";
            this.hoclucTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hoclucTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hoclucTextEdit.TabIndex = 15;
            // 
            // hoclucTextEdit1
            // 
            this.hoclucTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "hocluc", true));
            this.hoclucTextEdit1.Location = new System.Drawing.Point(533, 3);
            this.hoclucTextEdit1.Name = "hoclucTextEdit1";
            this.hoclucTextEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hoclucTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.hoclucTextEdit1.TabIndex = 18;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // hoclucTextEdit2
            // 
            this.hoclucTextEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "hocluc", true));
            this.hoclucTextEdit2.Location = new System.Drawing.Point(533, 3);
            this.hoclucTextEdit2.Name = "hoclucTextEdit2";
            this.hoclucTextEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hoclucTextEdit2.Size = new System.Drawing.Size(100, 20);
            this.hoclucTextEdit2.TabIndex = 21;
            // 
            // hoclucTextEdit3
            // 
            this.hoclucTextEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "hocluc", true));
            this.hoclucTextEdit3.Location = new System.Drawing.Point(0, 2);
            this.hoclucTextEdit3.Name = "hoclucTextEdit3";
            this.hoclucTextEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hoclucTextEdit3.Size = new System.Drawing.Size(100, 20);
            this.hoclucTextEdit3.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hoclucTextEdit3);
            this.groupBox1.Location = new System.Drawing.Point(533, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 22);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // quanlyhocluc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mahocsinhTextEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.danhGiaBindingNavigator);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.hoclucTextEdit);
            this.Controls.Add(this.hoclucTextEdit1);
            this.Controls.Add(this.hoclucTextEdit2);
            this.Name = "quanlyhocluc";
            this.Text = "QUẢN LÝ HỌC LỰC";
            this.Load += new System.EventHandler(this.quanlyhocluc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingNavigator)).EndInit();
            this.danhGiaBindingNavigator.ResumeLayout(false);
            this.danhGiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahocsinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit3.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmahocsinh;
        private DevExpress.XtraGrid.Columns.GridColumn colhocluc;
        private DevExpress.XtraGrid.Columns.GridColumn colhanhkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit3;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit4;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit5;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit6;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit mahocsinhTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit hoclucTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit hoclucTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.ComboBoxEdit hoclucTextEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit hoclucTextEdit3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}