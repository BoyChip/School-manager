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
    public partial class quanlyhocky : DevExpress.XtraEditors.XtraForm
    {
        public quanlyhocky()
        {
            InitializeComponent();
        }


        private void quanlyhocky_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.HocKy_NamHoc' table. You can move, or remove it, as needed.
            this.hocKy_NamHocTableAdapter.Fill(this.dataDataSet.HocKy_NamHoc);
   
   

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void hocKy_NamHocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hocKy_NamHocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.hocKy_NamHocBindingSource.CancelEdit();
        }
    }
}