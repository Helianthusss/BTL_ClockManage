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
            txtSearch.Visible = true;
            txtNewprice.Visible = false;
            DataGridView_Product_Inventory.Visible = true;
            DataGridView_Product_Deal.Visible = false;
        }

        private void btnListdeal_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            txtNewprice.Visible = true;
            DataGridView_Product_Inventory.Visible = false;
            DataGridView_Product_Deal.Visible = true;
        }

        private void btnNewprice_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
