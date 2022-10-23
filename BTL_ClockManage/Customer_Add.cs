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
    public partial class Customer_Add : Form
    {
        private int borderRadius = 25;
        private int borderSize = 1;
        private Color borderColor = Color.CornflowerBlue;
        public Customer_Add()
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

        private void Customer_Add_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Eidit border form
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        
        //Button Close
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button Minimize
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Button Id
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

        //Button Name
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

        //Button Address
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

        //Button Phone
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
    }
}
