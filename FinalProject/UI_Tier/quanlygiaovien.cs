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
    public partial class quanlygiaovien : DevExpress.XtraEditors.XtraForm
    {
        public quanlygiaovien()
        {
            InitializeComponent();
        }



        private void quanlygiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.dataDataSet.GiaoVien);


        }

        private void giaoVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giaoVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.giaoVienBindingSource.CancelEdit();
        }

        private void tengiaovienLabel_Click(object sender, EventArgs e)
        {

        }

        private void hogiaovienTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}