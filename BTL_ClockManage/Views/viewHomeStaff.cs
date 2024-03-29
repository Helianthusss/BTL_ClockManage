﻿using System;
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
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new viewBillPaying());
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new viewMainHomeManager());
        }
        private Guna.UI2.WinForms.Guna2GradientButton buttonHienHanh;
        private void voHieuHoaButton(Guna.UI2.WinForms.Guna2Panel panel)
        {
            foreach (Control truocButton in panel.Controls)
            {
                if (truocButton.GetType() == typeof(Guna.UI2.WinForms.Guna2GradientButton))
                {
                    Guna.UI2.WinForms.Guna2GradientButton a;
                    a = (Guna.UI2.WinForms.Guna2GradientButton)truocButton;
                    truocButton.ForeColor = Color.Black;
                    a.FillColor = Color.FromArgb(85, 103, 201);
                    a.FillColor2 = Color.FromArgb(85, 103, 201);
                }
            }
        }
        private void buttonHoatDong(object btnSender, Guna.UI2.WinForms.Guna2Panel panel)
        {
            if (btnSender != null)
            {
                if (buttonHienHanh != (Guna.UI2.WinForms.Guna2GradientButton)btnSender)
                {
                    voHieuHoaButton(panel);
                    buttonHienHanh = (Guna.UI2.WinForms.Guna2GradientButton)btnSender;
                    buttonHienHanh.FillColor = Color.FromArgb(72, 87, 171);
                    buttonHienHanh.FillColor2 = Color.FromArgb(72, 87, 171);
                    buttonHienHanh.ForeColor = Color.White;
                }
            }
        }
        private void Close_Menu_ChildStaff()
        {
            panelChildForm.Height -= 110;
            if (panelChildForm.Height == panelChildForm.MinimumSize.Height)
            {
                Timer_Staff.Stop();
            }
        }
        private void Show_Child_Form(Form ChildForm)
        {
            if (current != null)
            {
                current.Close();
            }
            current = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            panelChildForm.BringToFront();
            ChildForm.Show();

        }
        private Form current;
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Close_Menu_ChildStaff();
            buttonHoatDong(sender, guna2Panel_Control_Big);
            Show_Child_Form(new FormReportStaff());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
