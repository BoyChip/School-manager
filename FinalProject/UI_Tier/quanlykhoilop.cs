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
    public partial class quanlykhoilop : DevExpress.XtraEditors.XtraForm
    {
        public quanlykhoilop()
        {
            InitializeComponent();
        }

        private void khoiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void quanlykhoilop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.Khoi' table. You can move, or remove it, as needed.
            this.khoiTableAdapter.Fill(this.dataDataSet.Khoi);

        }
    }
}