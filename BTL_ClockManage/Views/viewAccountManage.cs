using BTL_ClockManage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            List<NHANVIEN> idnv = Program.context.NHANVIENs.ToList();
            idnv.ForEach(x =>
            {
                cbId.Items.Add(x.MANV);
            });
            initTable();
        }
        public void initTable()
        {
            tbl.DataSource = null;
            List<NHANVIEN> nv = Program.context.NHANVIENs.Where(n => n.ACCOUNT != null).OrderBy(n => n.TENNV).ToList();
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
            cbId.SelectedItem = tbl.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = tbl.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPosition.Text = tbl.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAccount.Text = tbl.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            NHANVIEN nv = Program.context.NHANVIENs.FirstOrDefault(n=>n.MANV == cbId.SelectedItem.ToString());
            txtName.Text = nv.TENNV;
            txtPosition.Text = nv.CHUCVU;
            txtAccount.Text = nv.ACCOUNT;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Program.context.Database.ExecuteSqlCommand("TK_ADDACCOUNT @Manv, @code", 
                new SqlParameter("@Manv",cbId.SelectedItem.ToString()), 
                new SqlParameter("@code",txtAccount.Text));
            MessageBox.Show("Thêm thành công");
            initTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.context.Database.ExecuteSqlCommand("TK_DELETEACC @Manv",
                new SqlParameter("@Manv", cbId.SelectedItem.ToString()));
            MessageBox.Show("Xóa thành công");
            initTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Program.context.Database.ExecuteSqlCommand("TK_ADDACCOUNT @Manv, @code",
                new SqlParameter("@Manv", cbId.SelectedItem.ToString()),
                new SqlParameter("@code", txtAccount.Text));
            MessageBox.Show("Sửa thành công");
            initTable();
        }
    }
}
