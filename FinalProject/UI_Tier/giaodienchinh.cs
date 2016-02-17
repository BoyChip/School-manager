using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace UI_Tier
{
    public partial class giaodienchinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Thread thr;

        public giaodienchinh()
        {
            InitializeComponent();
        }

        private void button_quanlyhocsinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {          
            hocsinh _hs = new hocsinh();
            _hs.MdiParent = this;
            _hs.Show();
        }

        public void load_form_dangnhap(object obj)
        {
            Application.Run(new dangnhap());
        }

        /// <summary>
        /// Sự kiện nút thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_thoat_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.Close();
                System.Windows.Forms.Application.Exit();
            }
        }
        /// <summary>
        /// Mở lại giao diện đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                thr = new Thread(load_form_dangnhap);
                thr.SetApartmentState(ApartmentState.STA);
                thr.Start();
            }
        }

        private void button_phanlop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlyphanlophocsinh _phanlop = new quanlyphanlophocsinh();
            _phanlop.Show();
        }

        private void giaodienchinh_Load(object sender, EventArgs e)
        {

        }

        private void button_giaovien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlygiaovien _ql_giaovien = new quanlygiaovien();
            _ql_giaovien.MdiParent = this;
            _ql_giaovien.Show();
        }

        private void button_phancong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlyphanconggiaovien _ql_phancong_giaovien = new quanlyphanconggiaovien();
            _ql_phancong_giaovien.MdiParent = this;
            _ql_phancong_giaovien.Show();
        }

        private void button_to_bomon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlytobomon _ql_tobomon = new quanlytobomon();
            _ql_tobomon.Show();
        }

        private void button_monhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlymonhoc _ql_monhoc = new quanlymonhoc();
            _ql_monhoc.Show();
        }

        private void button_diem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlydiemhocsinh _ql_diemhocsinh = new quanlydiemhocsinh();
            _ql_diemhocsinh.MdiParent = this;
            _ql_diemhocsinh.Show();
        }

        private void button_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlylop _ql_lop = new quanlylop();
            _ql_lop.Show();
        }

        private void button_khoilop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlykhoilop _ql_khoilop = new quanlykhoilop();
            _ql_khoilop.Show();
        }

        private void button_hocky_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlyhocky _ql_hocky = new quanlyhocky();
            _ql_hocky.Show();
        }

          private void button_hocluc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlyhocluc _ql_hocluc = new quanlyhocluc();
            _ql_hocluc.MdiParent = this;
            _ql_hocluc.Show();
        }

        private void button_hanhkiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quanlyhanhkiem _ql_hanhkiem = new quanlyhanhkiem();
            _ql_hanhkiem.MdiParent = this;
            _ql_hanhkiem.Show();
        }

        private void button_thongke_hocky_theolop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timkiemhocsinh _timkiemhocsinh = new timkiemhocsinh();
            _timkiemhocsinh.MdiParent = this;
            _timkiemhocsinh.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timkiemgiaovien _timkiemgiaovien = new timkiemgiaovien();
            _timkiemgiaovien.MdiParent = this;
            _timkiemgiaovien.Show();
        }

        private void button_doimatkhau_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            doimatkhau _doimatkhau = new doimatkhau();
            _doimatkhau.Show();
        }

        private void button_quanlynguoidung_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            quanlynguoidung _ql_nguoidung = new quanlynguoidung();
            _ql_nguoidung.Show();
        }

        private void button_danhsach_hocsinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thongkedanhsachhocsinh _tk_danhsachhocsinh = new thongkedanhsachhocsinh();
            _tk_danhsachhocsinh.MdiParent = this;
            _tk_danhsachhocsinh.Show();
        }

        private void button_danhsach_giaovien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thongkedanhsachgiaovien _tk_danhsachgiaovien = new thongkedanhsachgiaovien();
            _tk_danhsachgiaovien.MdiParent = this;
            _tk_danhsachgiaovien.Show();
        }

        private void button_danhsach_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thongkedanhsachlop _tk_danhsachlop = new thongkedanhsachlop();
            _tk_danhsachlop.MdiParent = this;
            _tk_danhsachlop.Show();
        }
    }
}