using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_ClockManage
{
    public partial class Customer_Manager : UserControl
    {
        public Customer_Manager()
        {
            InitializeComponent();
        }

        private void txt_find_customer_TextChanged(object sender, EventArgs e)
        {
            txt_find_customer.Text = "";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_find_customer.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_find_customer.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_find_customer.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_find_customer.Text = "";
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            txt_find_customer.Text = "";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_find_customer.Text = "";
        }
    }
}
