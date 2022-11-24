using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_ClockManage.Views
{
    public partial class viewBillPrint : Form
    {
        public viewBillPrint()
        {
            InitializeComponent();
        }

        private void viewBillPrint_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}
