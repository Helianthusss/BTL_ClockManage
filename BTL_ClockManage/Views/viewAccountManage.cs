using BTL_ClockManage.Models;
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
    public partial class viewAccountManage : Form
    {
        public viewAccountManage()
        {
            InitializeComponent();
        }
        private void viewAccountManage_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> nv = Program.context.NHANVIENs.Where(n => n.ACCOUNT != null).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Tên", typeof(string));
            table.Columns.Add("Chức vụ", typeof(string));
            table.Columns.Add("Account", typeof(string));
            nv.ForEach(x =>
            {
                var rowDT = table.NewRow();
                rowDT["Id"] = x.MANV;
                rowDT["Tên"] = x.TENNV;
                rowDT["Chức vụ"] = x.CHUCVU;
                rowDT["Account"] = x.ACCOUNT;
                table.Rows.Add(rowDT);
            });
            tbl.DataSource = table;
        }
        private void tbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
