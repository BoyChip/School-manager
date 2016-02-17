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
    public partial class thongkedanhsachhocsinh : DevExpress.XtraEditors.XtraForm
    {
        public thongkedanhsachhocsinh()
        {
            InitializeComponent();
        }

        private void thongkedanhsachhocsinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.HocSinh' table. You can move, or remove it, as needed.
            this.HocSinhTableAdapter.Fill(this.dataDataSet.HocSinh);

            this.reportViewer1.RefreshReport();
        }
    }
}