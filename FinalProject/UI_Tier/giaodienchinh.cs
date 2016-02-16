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

namespace UI_Tier
{
    public partial class giaodienchinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public giaodienchinh()
        {
            InitializeComponent();
        }

        private void button_quanlyhocsinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            hocsinh hs = new hocsinh();
            hs.MdiParent = this;
            hs.Show();
        }

        /// <summary>
        /// Sự kiện nút thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backstageViewTabItem5_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.Close();
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}