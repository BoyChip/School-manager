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
            System.Windows.Forms.Label mahocsinhLabel;
            System.Windows.Forms.Label hoclucLabel;
            this.dataDataSet = new UI_Tier.dataDataSet();
            this.danhGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhGiaTableAdapter = new UI_Tier.dataDataSetTableAdapters.DanhGiaTableAdapter();
            this.tableAdapterManager = new UI_Tier.dataDataSetTableAdapters.TableAdapterManager();
            this.danhGiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.danhGiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahocsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhocluc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhanhkiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.mahocsinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoclucTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            mahocsinhLabel = new System.Windows.Forms.Label();
            hoclucLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingNavigator)).BeginInit();
            this.danhGiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahocsinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit.Properties)).BeginInit();
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
            this.bindingNavigatorDeleteItem,
            this.danhGiaBindingNavigatorSaveItem});
            this.danhGiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.danhGiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.danhGiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.danhGiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.danhGiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.danhGiaBindingNavigator.Name = "danhGiaBindingNavigator";
            this.danhGiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.danhGiaBindingNavigator.Size = new System.Drawing.Size(624, 25);
            this.danhGiaBindingNavigator.TabIndex = 0;
            this.danhGiaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // danhGiaBindingNavigatorSaveItem
            // 
            this.danhGiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.danhGiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("danhGiaBindingNavigatorSaveItem.Image")));
            this.danhGiaBindingNavigatorSaveItem.Name = "danhGiaBindingNavigatorSaveItem";
            this.danhGiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.danhGiaBindingNavigatorSaveItem.Text = "Save Data";
            this.danhGiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.danhGiaBindingNavigatorSaveItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.danhGiaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(416, 305);
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
            this.colmahocsinh.FieldName = "mahocsinh";
            this.colmahocsinh.Name = "colmahocsinh";
            this.colmahocsinh.Visible = true;
            this.colmahocsinh.VisibleIndex = 0;
            // 
            // colhocluc
            // 
            this.colhocluc.FieldName = "hocluc";
            this.colhocluc.Name = "colhocluc";
            this.colhocluc.Visible = true;
            this.colhocluc.VisibleIndex = 1;
            // 
            // colhanhkiem
            // 
            this.colhanhkiem.FieldName = "hanhkiem";
            this.colhanhkiem.Name = "colhanhkiem";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 25);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton5);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton4);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(mahocsinhLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.mahocsinhTextEdit);
            this.splitContainerControl1.Panel1.Controls.Add(hoclucLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.hoclucTextEdit);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(624, 305);
            this.splitContainerControl1.SplitterPosition = 203;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // mahocsinhLabel
            // 
            mahocsinhLabel.AutoSize = true;
            mahocsinhLabel.Location = new System.Drawing.Point(12, 25);
            mahocsinhLabel.Name = "mahocsinhLabel";
            mahocsinhLabel.Size = new System.Drawing.Size(61, 13);
            mahocsinhLabel.TabIndex = 0;
            mahocsinhLabel.Text = "mahocsinh:";
            // 
            // mahocsinhTextEdit
            // 
            this.mahocsinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "mahocsinh", true));
            this.mahocsinhTextEdit.Location = new System.Drawing.Point(79, 22);
            this.mahocsinhTextEdit.Name = "mahocsinhTextEdit";
            this.mahocsinhTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mahocsinhTextEdit.TabIndex = 1;
            // 
            // hoclucLabel
            // 
            hoclucLabel.AutoSize = true;
            hoclucLabel.Location = new System.Drawing.Point(12, 51);
            hoclucLabel.Name = "hoclucLabel";
            hoclucLabel.Size = new System.Drawing.Size(41, 13);
            hoclucLabel.TabIndex = 2;
            hoclucLabel.Text = "hocluc:";
            // 
            // hoclucTextEdit
            // 
            this.hoclucTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhGiaBindingSource, "hocluc", true));
            this.hoclucTextEdit.Location = new System.Drawing.Point(79, 48);
            this.hoclucTextEdit.Name = "hoclucTextEdit";
            this.hoclucTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hoclucTextEdit.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 85);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Thêm";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(93, 85);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Sửa";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(93, 114);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Xóa";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(12, 143);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Hủy";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(12, 114);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 8;
            this.simpleButton5.Text = "Lưu";
            // 
            // quanlyhocluc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 330);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.danhGiaBindingNavigator);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mahocsinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucTextEdit.Properties)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmahocsinh;
        private DevExpress.XtraGrid.Columns.GridColumn colhocluc;
        private DevExpress.XtraGrid.Columns.GridColumn colhanhkiem;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit mahocsinhTextEdit;
        private DevExpress.XtraEditors.TextEdit hoclucTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}