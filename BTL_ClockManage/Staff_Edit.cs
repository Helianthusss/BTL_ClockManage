using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace BTL_ClockManage
{
    public partial class Staff_Edit : Form
    {
        private int borderRadius = 25;
        private int borderSize = 1;
        private Color borderColor = Color.CornflowerBlue;
        public Staff_Edit()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }

        //Drag form: kéo thả form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = 0x20000;
                return cp;
            }
        }

        private void Staff_Edit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Button close
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button minimize
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //If TextBox is not null, Label will be null  
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                lbl_id_empty.Text = "";
            }
            else
            {
                lbl_id_empty.Text = "* ID is empty!";
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
                lbl_name_empty.Text = "";
            }
            else
            {
                lbl_name_empty.Text = "* Name is empty!";
            }
        }

        private void txt_id_card_TextChanged(object sender, EventArgs e)
        {
            if (txt_id_card.Text != "")
            {
                lbl_id_card_empty.Text = "";
            }
            else
            {
                lbl_id_card_empty.Text = "* ID Card is empty!";
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_phone.Text != "")
            {
                lbl_phone_empty.Text = "";
            }
            else
            {
                lbl_phone_empty.Text = "* Phone is empty!";
            }
        }

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {
            if (txt_salary.Text != "")
            {
                lbl_salary_empty.Text = "";
            }
            else
            {
                lbl_salary_empty.Text = "* Salary is empty!";
            }
        }

        private void cb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_position.Text != "")
            {
                lbl_position_empty.Text = "";
            }
            else
            {
                lbl_position_empty.Text = "* Position is empty!";
            }
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            if (txt_address.Text != "")
            {
                lbl_address_empty.Text = "";
            }
            else
            {
                lbl_address_empty.Text = "* Address is empty!";
            }
        }
    }
}
