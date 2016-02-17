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
    public partial class quanlylop : DevExpress.XtraEditors.XtraForm
    {
        public quanlylop()
        {
            InitializeComponent();
        }

        private void quanlylop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.dataDataSet.Lop);
            // TODO: This line of code loads data into the 'dataDataSet.Lop' table. You can move, or remove it, as needed.
        }

        private void lopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.lopBindingSource.CancelEdit();
        }
    }
}