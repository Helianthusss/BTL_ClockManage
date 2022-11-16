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
    public partial class CF_DealProduct : Form
    {
        public CF_DealProduct()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            DataGridView_Product_Inventory.Visible = true;
            DataGridView_Product_Deal.Visible = false;
            btnNewprice.Visible = true;
        }

        private void btnListdeal_Click(object sender, EventArgs e)
        {
            DataGridView_Product_Inventory.Visible = false;
            DataGridView_Product_Deal.Visible = true;
            btnNewprice.Visible = false;
        }

        private void btnNewprice_Click(object sender, EventArgs e)
        {
            Form fm = new Update_New_Price();
            fm.Show();
        }
    }
}
