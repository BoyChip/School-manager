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
    public partial class quanlynguoidung : DevExpress.XtraEditors.XtraForm
    {
        public quanlynguoidung()
        {
            InitializeComponent();
        }

        private void dangNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dangNhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void quanlynguoidung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.dataDataSet.GiaoVien);
            // TODO: This line of code loads data into the 'dataDataSet.DangNhap' table. You can move, or remove it, as needed.
            this.dangNhapTableAdapter.Fill(this.dataDataSet.DangNhap);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.giaoVienBindingSource.CancelEdit();
            this.dangNhapBindingSource.CancelEdit();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}