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
    public partial class quanlytobomon : DevExpress.XtraEditors.XtraForm
    {
        public quanlytobomon()
        {
            InitializeComponent();
        }

        private void toBoMonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toBoMonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void quanlytobomon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.ToBoMon' table. You can move, or remove it, as needed.
            this.toBoMonTableAdapter.Fill(this.dataDataSet.ToBoMon);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.toBoMonBindingSource.CancelEdit();
        }
    }
}