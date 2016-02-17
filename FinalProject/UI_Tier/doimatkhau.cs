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
    public partial class doimatkhau : DevExpress.XtraEditors.XtraForm
    {
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("Bạn đã đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}