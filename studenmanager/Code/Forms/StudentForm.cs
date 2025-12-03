using DevExpress.Utils.DPI;
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
            public string MSSV { get; set; }
            public string Tên { get; set; }
            public string GiớiTính { get; set; }
            public string Sinh { get; set; }

            public string Lớp { get; set; }
            public double Điểm { get; set; } 
           
            public string Loại {get; set; }
            public string Năm { get; set; }

            
           
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
            double Diem=double.Parse(txtPoint.Text.Trim());
            string gioitinh = comboBox1.SelectedItem.ToString();
            string loai= comboBox2.SelectedItem.ToString();
            string nam= comboBox3.SelectedItem.ToString();
            string sinh= dateTimePicker1.Value.ToString("dd/MM/yyyy");





            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên và Tên đầy đủ.",
                                "Lỗi Nhập Liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (studentList.Exists(s => s.MSSV.Equals(maSV, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Mã sinh viên '{maSV}' đã tồn tại trong danh sách.",
                                "Lỗi Trùng Lặp",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Student newStudent = new Student
            {
                
                Tên = tenSV,
                MSSV = maSV,
                Lớp = lop,
                Điểm = Diem,
                GiớiTính = gioitinh,
                Loại = loai,
                Năm = nam,
                Sinh = sinh,



            };

            studentList.Add(newStudent);

            LoadStudentData();

            txtMaSV.Clear();
            txtTenSV.Clear();
            txtLop.Clear();
            txtPoint.Clear();
            comboBox1.SelectedIndex= -1;
            comboBox2.SelectedIndex= -1;
            comboBox3.SelectedIndex= -1;

            txtMaSV.Focus();

            MessageBox.Show("Đã thêm sinh viên thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // test push
        }


        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
