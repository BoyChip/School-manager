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
    public partial class hocsinh : DevExpress.XtraEditors.XtraForm
    {
        public hocsinh()
        {
            InitializeComponent();
        }

        private void hocsinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.HocKy_NamHoc' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dataDataSet.HocSinh' table. You can move, or remove it, as needed.
            this.hocSinhTableAdapter.Fill(this.dataDataSet.HocSinh);
  

        }

        private void hocSinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hocSinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void mahocsinhTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tenhocsinhLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.hocSinhBindingSource.CancelEdit();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void diachiLabel_Click(object sender, EventArgs e)
        {

        }

       
    }
}