using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studenmanager.Code.Forms
{
    public partial class StudentForm : Form
    {
        // ✔️ Chỉ khai báo 1 lần
        private List<Student> studentList = new List<Student>();

        // ✔️ Class mô tả sinh viên
        public class Student
        {
            public string StudentID { get; set; }
            public string FullName { get; set; }
            public string ClassName { get; set; }
        }

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        // ✔️ Load dữ liệu ra DataGridView
        private void LoadStudentData()
        {
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = studentList;
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();   // kiểm tra đúng textbox
            string lop = txtLop.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên và Tên đầy đủ.",
                                "Lỗi Nhập Liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (studentList.Exists(s => s.StudentID.Equals(maSV, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Mã sinh viên '{maSV}' đã tồn tại trong danh sách.",
                                "Lỗi Trùng Lặp",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Student newStudent = new Student
            {
                StudentID = maSV,
                FullName = tenSV,
                ClassName = lop
            };

            studentList.Add(newStudent);

            LoadStudentData();

            txtMaSV.Clear();
            txtTenSV.Clear();
            txtLop.Clear();
            txtMaSV.Focus();

            MessageBox.Show("Đã thêm sinh viên thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            // test push
        }
    }
}
