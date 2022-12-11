using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_ClockManage.Models;

namespace BTL_ClockManage.Views
{
    public partial class FormReportStaff : Form
    {
        public DashBoard model;
        //constructor
        public FormReportStaff()
        {
            InitializeComponent();
            //default - last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btn7NgayTruoc.Select();
            model = new DashBoard();
            LoadData();
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
                    a.FillColor = Color.FromArgb(229, 217, 242);
                    a.FillColor2 = Color.FromArgb(229, 217, 242);
                    a.CustomBorderColor = a.FillColor2 = Color.FromArgb(229, 217, 242);
                    a.BorderColor= Color.FromArgb(229, 217, 242);


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
                    buttonHienHanh.FillColor = Color.FromArgb(115, 113, 252);
                    buttonHienHanh.FillColor2 = Color.FromArgb(115,113,252);
                    buttonHienHanh.ForeColor = Color.White;
                    buttonHienHanh.CustomBorderColor = Color.FromArgb(115, 113, 252);
                    buttonHienHanh.BorderColor = Color.FromArgb(115, 113, 252);

                }
            }
        }
        //private methods
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);

            if (refreshData == true)
            {
                lblNumberDonHang.Text = model.NumOrders.ToString();
                lblNumberDoanhthu.Text = model.TotalRevenue.ToString();

                chartTongDoanhThu.DataSource = model.GrossRevenueList;
                chartTongDoanhThu.Series[0].XValueMember = "Date";
                chartTongDoanhThu.Series[0].YValueMembers = "TotalAmount";
                chartTongDoanhThu.DataBind();

                chartTop10SanPham.DataSource = model.TopProductsList;
                chartTop10SanPham.Series[0].XValueMember = "Key";
                chartTop10SanPham.Series[0].YValueMembers = "Value";
                chartTop10SanPham.DataBind();
                Console.WriteLine("Loaded view:)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            guna2PictureBox1.Visible = false;
        }
        //Event methods



        private void lblNumberDonHang_Click(object sender, EventArgs e)
        {

        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnThongThuong_Click_1(object sender, EventArgs e)
        {
            buttonHoatDong(sender, guna2Panel1);
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            guna2PictureBox1.Visible = true;
        }

        private void btnHomNay_Click_1(object sender, EventArgs e)
        {
            buttonHoatDong(sender, guna2Panel1);
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btn7NgayTruoc_Click_1(object sender, EventArgs e)
        {
            buttonHoatDong(sender, guna2Panel1); 
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btn30NgayTruoc_Click_1(object sender, EventArgs e)
        {
            buttonHoatDong(sender, guna2Panel1);
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThangTruoc_Click_1(object sender, EventArgs e)
        {
            buttonHoatDong(sender, guna2Panel1); 
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpStartDate.Value = dtpStartDate.Value.AddMonths(-1);
            dtpEndDate.Value = dtpStartDate.Value.AddMonths(+1).AddDays(-1);
            LoadData();
            DisableCustomDates();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

