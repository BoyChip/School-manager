namespace UI_Tier
{
    partial class thongkedanhsachgiaovien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataDataSet = new UI_Tier.dataDataSet();
            this.GiaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GiaoVienTableAdapter = new UI_Tier.dataDataSetTableAdapters.GiaoVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GiaoVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI_Tier.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GiaoVienBindingSource
            // 
            this.GiaoVienBindingSource.DataMember = "GiaoVien";
            this.GiaoVienBindingSource.DataSource = this.dataDataSet;
            // 
            // GiaoVienTableAdapter
            // 
            this.GiaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // thongkedanhsachgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "thongkedanhsachgiaovien";
            this.Text = "DANH SÁCH GIÁO VIÊN";
            this.Load += new System.EventHandler(this.thongkedanhsachgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GiaoVienBindingSource;
        private dataDataSet dataDataSet;
        private dataDataSetTableAdapters.GiaoVienTableAdapter GiaoVienTableAdapter;
    }
}