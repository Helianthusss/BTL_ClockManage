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
    public partial class CF_ProcductManage : Form
    {
        public CF_ProcductManage()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form fm = new Edit_Product();
            fm.Show();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Form fm = new New_Product();
            fm.Show();
        }
    }
}
