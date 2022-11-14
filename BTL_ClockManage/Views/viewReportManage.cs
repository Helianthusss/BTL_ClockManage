using BTL_ClockManage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace BTL_ClockManage.Views
{
    public partial class viewReportManage : Form
    {
        public viewReportManage()
        {
            InitializeComponent();
        }

        private void viewReportManage_Load(object sender, EventArgs e)
        {
            initProduct();
        }
        public void initProduct()
        {
            List<SANPHAM> sp = null;
            sp = Program.context.SANPHAMs.ToList();
            sp.ForEach(n =>
            {
                productBarData.DataPoints.Add(n.MASP, n.SOLUONG);
                productPieData.DataPoints.Add(n.MASP, n.SOLUONG);
            });
        }
        public void initBill()
        {
            List<SANPHAM> sp = null;
            sp = Program.context.SANPHAMs.ToList();
            sp.ForEach(n =>
            {
                productBarData.DataPoints.Add(n.MASP, n.SOLUONG);
                productPieData.DataPoints.Add(n.MASP, n.SOLUONG);
            });
        }
    }
}
