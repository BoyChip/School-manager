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
    public partial class quanlyhocluc : DevExpress.XtraEditors.XtraForm
    {
        public quanlyhocluc()
        {
            InitializeComponent();
        }

        private void danhGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.danhGiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void quanlyhocluc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.DanhGia' table. You can move, or remove it, as needed.
            this.danhGiaTableAdapter.Fill(this.dataDataSet.DanhGia);

        }
    }
}