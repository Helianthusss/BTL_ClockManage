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
    public partial class viewEmployeeManage : Form
    {
        public viewEmployeeManage()
        {
            InitializeComponent();
        }
        public void initTable()
        {
            //tbl.DataSource = null;
            List<NHANVIEN> nv = null;
            if (txtFindId.Text != "")
            {
                nv = Program.context.NHANVIENs.Where(n => n.MANV.Contains(txtFindId.Text) || n.TENNV.Contains(txtFindId.Text)).OrderBy(n => n.TENNV).ToList();
            }
            else nv = Program.context.NHANVIENs.OrderBy(n => n.TENNV).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Tên", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(DateTime));
            table.Columns.Add("SĐT", typeof(string));
            table.Columns.Add("Chức vụ", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));
            table.Columns.Add("Ngày vào", typeof(DateTime));
            table.Columns.Add("Lương", typeof(decimal));
            nv.ForEach(x =>
            {
                var rowDT = table.NewRow();
                rowDT["Id"] = x.MANV;
                rowDT["Tên"] = x.TENNV;
                rowDT["Ngày sinh"] = x.NGAYSINH;
                rowDT["SĐT"] = x.SDT;
                rowDT["Chức vụ"] = x.CHUCVU;
                rowDT["Địa chỉ"] = x.DIACHI;
                rowDT["Ngày vào"] = x.NGAYVAOLAM;
                rowDT["Lương"] = x.LUONG;
                table.Rows.Add(rowDT);
            });
            tbl.DataSource = table;
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if(txtId.TextLength > 10)
            {
                MessageBox.Show("Không hơn 10 kí tự");
                txtId.Text = "";
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.TextLength > 200)
            {
                MessageBox.Show("Không hơn 200 kí tự");
                txtName.Text = "";
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.TextLength > 11)
            {
                MessageBox.Show("Không hơn 11 số");
                txtPhone.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtFindId_TextChanged(object sender, EventArgs e)
        {
            initTable();
        }

        private void viewEmployeeManage_Load(object sender, EventArgs e)
        {
            initTable();
        }
    }
}
