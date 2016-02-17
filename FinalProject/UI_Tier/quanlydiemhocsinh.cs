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
    public partial class quanlydiemhocsinh : DevExpress.XtraEditors.XtraForm
    {
        public quanlydiemhocsinh()
        {
            InitializeComponent();
        }

   

        private void quanlydiemhocsinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.Diem' table. You can move, or remove it, as needed.
            this.diemTableAdapter.Fill(this.dataDataSet.Diem);
            // TODO: This line of code loads data into the 'dataDataSet.Diem' table. You can move, or remove it, as needed.
   

        }

        private void diemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            quanlymonhoc _ql_monhoc = new quanlymonhoc();
            _ql_monhoc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.diemBindingSource.CancelEdit();
        }
    }
}