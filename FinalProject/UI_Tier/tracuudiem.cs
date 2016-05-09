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
    public partial class tracuudiem : DevExpress.XtraEditors.XtraForm
    {
        public tracuudiem()
        {
            InitializeComponent();
        }

        private void tracuudiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.DataTable1' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.dataDataSet.DataTable1,this.textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}