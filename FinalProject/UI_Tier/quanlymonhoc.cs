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
    public partial class quanlymonhoc : DevExpress.XtraEditors.XtraForm
    {
        public quanlymonhoc()
        {
            InitializeComponent();
        }

        private void monHocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monHocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void quanlymonhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.dataDataSet.MonHoc);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}