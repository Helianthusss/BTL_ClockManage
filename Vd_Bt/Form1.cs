using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vd_Bt
{
    public partial class frmQLSinhVien : Form
    {
        public frmQLSinhVien()
        {
            InitializeComponent();
        }
        private void showListST()
        {
            StudentControlDB context = new StudentControlDB();
            List<Student> listStudent = context.Students.ToList();
            dgvSinhVien.DataSource = listStudent;

            List<Falculty> listFal = context.Falculties.ToList(); 
            cb_Khoa.DataSource = listFal;
            cb_Khoa.DisplayMember = "FacultyName";
            cb_Khoa.ValueMember = "FacultyID";
        }

        private void frmQLSinhVien_Load(object sender, EventArgs e)
        {
            showListST();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvSinhVien.Rows[e.RowIndex];
                txt_MaSoSV.Text = dgvRow.Cells[0].Value.ToString();
                txt_HoTen.Text = dgvRow.Cells[1].Value.ToString();
                txt_DiemTB.Text = dgvRow.Cells[2].Value.ToString();
                cb_Khoa.SelectedValue = dgvRow.Cells[3].Value;
            }
        }

        private bool SearchID(string id)
        {
            StudentControlDB context = new StudentControlDB();
            List<Student> listStudent = context.Students.ToList();
            int count = 0;
            foreach(Student st in listStudent)
            {
                if(st.StudentID.Trim() == id.Trim())
                {
                    count++;
                }
            }
            if (count > 0)
            {
                return true;
            }
            else 
                return false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(SearchID(txt_MaSoSV.Text) == false)
            {
                using(var context = new StudentControlDB())
                {
                    var st = new Student();
                    st.StudentID = txt_MaSoSV.Text;
                    st.FullName = txt_HoTen.Text;
                    st.AverageScore = int.Parse(txt_DiemTB.Text);
                    if (cb_Khoa.Text == "Công nghệ thông tin")
                    {
                        st.FacultyID = "1";
                    }
                    else
                        st.FacultyID = "2";
                    context.Students.Add(st);
                    context.SaveChanges();
                    showListST();
                }
            }
            else
            {
                using(var context = new StudentControlDB())
                {
                    var st = (from d in context.Students where d.StudentID == txt_MaSoSV.Text select d).FirstOrDefault();
                    st.FullName = txt_HoTen.Text;
                    st.AverageScore= int.Parse(txt_DiemTB.Text);
                    if (cb_Khoa.Text == "Công nghệ thông tin")
                    {
                        st.FacultyID = "1";
                    }
                    else
                        st.FacultyID = "2";
                    context.SaveChanges();
                    showListST();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using(var context = new StudentControlDB())
            {
                var st = (from d in context.Students where d.StudentID == txt_MaSoSV.Text select d).FirstOrDefault();
                context.Students.Remove(st);
                context.SaveChanges();
                showListST();
            }
        }
    }
}
