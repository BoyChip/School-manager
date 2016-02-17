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
    }
}