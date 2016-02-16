using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace UI_Tier
{
    public partial class dangnhap : DevExpress.XtraEditors.XtraForm
    {
        Thread thr;

        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button_dangnhap;
            this.text_taikhoan.Text = "admin";
            this.text_matkhau.Text = "admin";
            this.label_thongbao.Text = "Thong bao"; 
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            if (this.text_taikhoan.Text == "admin" && this.text_matkhau.Text == "admin")
            {
                this.Close();
                thr = new Thread(mo_giaodienchinh);
                thr.SetApartmentState(ApartmentState.STA);
                thr.Start();
            }
            else
            {
                this.label_thongbao.ForeColor = Color.Red;
                this.label_thongbao.Text = "Tài khoản hoặc mật khẩu sai!";
                this.text_taikhoan.Clear();
                this.text_matkhau.Clear();
                this.text_taikhoan.Focus();
            }
        }

        public void mo_giaodienchinh(object obj)
        {
            Application.Run(new giaodienchinh());
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button_nhaplai_Click(object sender, EventArgs e)
        {
            this.text_taikhoan.Clear();
            this.text_matkhau.Clear();
            this.text_taikhoan.Focus();
        }
    }
}
