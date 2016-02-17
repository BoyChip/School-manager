namespace UI_Tier
{
    partial class quanlytobomon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlytobomon));
            this.dataDataSet = new UI_Tier.dataDataSet();
            this.toBoMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toBoMonTableAdapter = new UI_Tier.dataDataSetTableAdapters.ToBoMonTableAdapter();
            this.tableAdapterManager = new UI_Tier.dataDataSetTableAdapters.TableAdapterManager();
            this.toBoMonBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toBoMonBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colma_to_bomon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten_to_bomon = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBoMonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBoMonBindingNavigator)).BeginInit();
            this.toBoMonBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toBoMonBindingSource
            // 
            this.toBoMonBindingSource.DataMember = "ToBoMon";
            this.toBoMonBindingSource.DataSource = this.dataDataSet;
            // 
            // toBoMonTableAdapter
            // 
            this.toBoMonTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KhoiTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.ToBoMonTableAdapter = this.toBoMonTableAdapter;
            this.tableAdapterManager.UpdateOrder = UI_Tier.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toBoMonBindingNavigator
            // 
            this.toBoMonBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.toBoMonBindingNavigator.BindingSource = this.toBoMonBindingSource;
            this.toBoMonBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.toBoMonBindingNavigator.CountItemFormat = "/{0}";
            this.toBoMonBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.toBoMonBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toBoMonBindingNavigatorSaveItem});
            this.toBoMonBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.toBoMonBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.toBoMonBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.toBoMonBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.toBoMonBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.toBoMonBindingNavigator.Name = "toBoMonBindingNavigator";
            this.toBoMonBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.toBoMonBindingNavigator.Size = new System.Drawing.Size(554, 25);
            this.toBoMonBindingNavigator.TabIndex = 0;
            this.toBoMonBindingNavigator.Text = "bindingNavigator1";
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
            // toBoMonBindingNavigatorSaveItem
            // 
            this.toBoMonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toBoMonBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("toBoMonBindingNavigatorSaveItem.Image")));
            this.toBoMonBindingNavigatorSaveItem.Name = "toBoMonBindingNavigatorSaveItem";
            this.toBoMonBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.toBoMonBindingNavigatorSaveItem.Text = "Save Data";
            this.toBoMonBindingNavigatorSaveItem.Click += new System.EventHandler(this.toBoMonBindingNavigatorSaveItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.toBoMonBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(554, 400);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colma_to_bomon,
            this.colten_to_bomon});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colma_to_bomon
            // 
            this.colma_to_bomon.Caption = "Mã tổ - bộ môn";
            this.colma_to_bomon.FieldName = "ma_to_bomon";
            this.colma_to_bomon.Name = "colma_to_bomon";
            this.colma_to_bomon.Visible = true;
            this.colma_to_bomon.VisibleIndex = 0;
            // 
            // colten_to_bomon
            // 
            this.colten_to_bomon.Caption = "Tên tổ - bộ môn";
            this.colten_to_bomon.FieldName = "ten_to_bomon";
            this.colten_to_bomon.Name = "colten_to_bomon";
            this.colten_to_bomon.Visible = true;
            this.colten_to_bomon.VisibleIndex = 1;
            // 
            // quanlytobomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 425);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toBoMonBindingNavigator);
            this.Name = "quanlytobomon";
            this.Text = "QUẢN LÝ TỔ - BỘ MÔN";
            this.Load += new System.EventHandler(this.quanlytobomon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBoMonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBoMonBindingNavigator)).EndInit();
            this.toBoMonBindingNavigator.ResumeLayout(false);
            this.toBoMonBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource toBoMonBindingSource;
        private dataDataSetTableAdapters.ToBoMonTableAdapter toBoMonTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator toBoMonBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton toBoMonBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colma_to_bomon;
        private DevExpress.XtraGrid.Columns.GridColumn colten_to_bomon;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}