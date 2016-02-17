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
    public partial class quanlyphanlophocsinh : DevExpress.XtraEditors.XtraForm
    {
        public quanlyphanlophocsinh()
        {
            InitializeComponent();
        }

        private void lopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void quanlyphanlophocsinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.HocSinh' table. You can move, or remove it, as needed.
            this.hocSinhTableAdapter.Fill(this.dataDataSet.HocSinh);
            // TODO: This line of code loads data into the 'dataDataSet.HocKy_NamHoc' table. You can move, or remove it, as needed.
            this.hocKy_NamHocTableAdapter.Fill(this.dataDataSet.HocKy_NamHoc);
            // TODO: This line of code loads data into the 'dataDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.dataDataSet.Lop);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}