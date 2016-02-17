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
    public partial class thongkedanhsachgiaovien : DevExpress.XtraEditors.XtraForm
    {
        public thongkedanhsachgiaovien()
        {
            InitializeComponent();
        }

        private void thongkedanhsachgiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.GiaoVien' table. You can move, or remove it, as needed.
            this.GiaoVienTableAdapter.Fill(this.dataDataSet.GiaoVien);

            this.reportViewer1.RefreshReport();
        }
    }
}