namespace UI_Tier
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.group_thongtindangnhap = new DevExpress.XtraEditors.GroupControl();
            this.text_taikhoan = new System.Windows.Forms.TextBox();
            this.text_matkhau = new System.Windows.Forms.TextBox();
            this.label_thongbao = new DevExpress.XtraEditors.LabelControl();
            this.label_matkhau = new DevExpress.XtraEditors.LabelControl();
            this.label_taikhoan = new DevExpress.XtraEditors.LabelControl();
            this.button_dangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.button_nhaplai = new DevExpress.XtraEditors.SimpleButton();
            this.button_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.group_thongtindangnhap)).BeginInit();
            this.group_thongtindangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_thongtindangnhap
            // 
            this.group_thongtindangnhap.Controls.Add(this.text_taikhoan);
            this.group_thongtindangnhap.Controls.Add(this.text_matkhau);
            this.group_thongtindangnhap.Controls.Add(this.label_thongbao);
            this.group_thongtindangnhap.Controls.Add(this.label_matkhau);
            this.group_thongtindangnhap.Controls.Add(this.label_taikhoan);
            this.group_thongtindangnhap.Location = new System.Drawing.Point(288, 29);
            this.group_thongtindangnhap.Name = "group_thongtindangnhap";
            this.group_thongtindangnhap.Size = new System.Drawing.Size(259, 172);
            this.group_thongtindangnhap.TabIndex = 0;
            this.group_thongtindangnhap.Text = "Thông tin đăng nhập";
            // 
            // text_taikhoan
            // 
            this.text_taikhoan.Location = new System.Drawing.Point(99, 37);
            this.text_taikhoan.Name = "text_taikhoan";
            this.text_taikhoan.Size = new System.Drawing.Size(100, 21);
            this.text_taikhoan.TabIndex = 6;
            // 
            // text_matkhau
            // 
            this.text_matkhau.Location = new System.Drawing.Point(99, 78);
            this.text_matkhau.Name = "text_matkhau";
            this.text_matkhau.PasswordChar = '*';
            this.text_matkhau.Size = new System.Drawing.Size(100, 21);
            this.text_matkhau.TabIndex = 5;
            // 
            // label_thongbao
            // 
            this.label_thongbao.Location = new System.Drawing.Point(5, 135);
            this.label_thongbao.Name = "label_thongbao";
            this.label_thongbao.Size = new System.Drawing.Size(63, 13);
            this.label_thongbao.TabIndex = 4;
            this.label_thongbao.Text = "labelControl1";
            // 
            // label_matkhau
            // 
            this.label_matkhau.Location = new System.Drawing.Point(6, 86);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(44, 13);
            this.label_matkhau.TabIndex = 1;
            this.label_matkhau.Text = "Mật khẩu";
            // 
            // label_taikhoan
            // 
            this.label_taikhoan.Location = new System.Drawing.Point(6, 45);
            this.label_taikhoan.Name = "label_taikhoan";
            this.label_taikhoan.Size = new System.Drawing.Size(46, 13);
            this.label_taikhoan.TabIndex = 0;
            this.label_taikhoan.Text = "Tài khoản";
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Location = new System.Drawing.Point(288, 239);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.button_dangnhap.TabIndex = 1;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // button_nhaplai
            // 
            this.button_nhaplai.Location = new System.Drawing.Point(370, 239);
            this.button_nhaplai.Name = "button_nhaplai";
            this.button_nhaplai.Size = new System.Drawing.Size(75, 23);
            this.button_nhaplai.TabIndex = 2;
            this.button_nhaplai.Text = "Nhập lại";
            this.button_nhaplai.Click += new System.EventHandler(this.button_nhaplai_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(452, 239);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(75, 23);
            this.button_thoat.TabIndex = 3;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_nhaplai);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.group_thongtindangnhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.group_thongtindangnhap)).EndInit();
            this.group_thongtindangnhap.ResumeLayout(false);
            this.group_thongtindangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl group_thongtindangnhap;
        private DevExpress.XtraEditors.LabelControl label_matkhau;
        private DevExpress.XtraEditors.LabelControl label_taikhoan;
        private DevExpress.XtraEditors.SimpleButton button_dangnhap;
        private DevExpress.XtraEditors.SimpleButton button_nhaplai;
        private DevExpress.XtraEditors.SimpleButton button_thoat;
        private DevExpress.XtraEditors.LabelControl label_thongbao;
        private System.Windows.Forms.TextBox text_matkhau;
        private System.Windows.Forms.TextBox text_taikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

