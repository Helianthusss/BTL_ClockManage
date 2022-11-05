using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//width = 205
//width = 63
namespace BTL_ClockManage.Views
{
    public partial class viewHomeStaff : Form
    {
        public viewHomeStaff()
        {
            InitializeComponent();
        }

        private void viewHomeStaff_Load(object sender, EventArgs e)
        {

        }
        bool enumExpended = false;
        private void DetectMouse_Tick(object sender, EventArgs e)
        {
            if (!guna2Transition1.IsCompleted) return;
            if (panelMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!enumExpended)
                {
                    enumExpended = true;
                    panelMenu.Width = 190;
                }
            }
            else
            {
                if (enumExpended)
                {
                    enumExpended = false;
                    panelMenu.Visible = false;
                    panelMenu.Width = 63;
                    guna2Transition1.Show(panelMenu);
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            //tabHomeStaff1.Visible = true;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
           // tabHomeStaff1.Visible = false;
        }

        private void tabHomeStaff1_Load(object sender, EventArgs e)
        {

        }
    }
}
