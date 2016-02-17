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
    public partial class thongkedanhsachlop : DevExpress.XtraEditors.XtraForm
    {
        public thongkedanhsachlop()
        {
            InitializeComponent();
        }

        private void thongkedanhsachlop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.Lop' table. You can move, or remove it, as needed.
            this.LopTableAdapter.Fill(this.dataDataSet.Lop);

            this.reportViewer1.RefreshReport();
        }
    }
}