using DevExpress.Utils.DPI;
using studenmanager.Code.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
            LoadFromFile();
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
            }
            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.AddRange(new string[] { "Giỏi", "Khá", "Trung bình" });
            }
            if (comboBox3.Items.Count == 0)
            {
                comboBox3.Items.AddRange(new string[] { "2020", "2021", "2022", "2023", "2024" });
            }
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            LoadStudentData();
        }

        // ✔️ Load dữ liệu ra DataGridView
        private void LoadStudentData()
        {
           if(studentList.Count==0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
           else
            {
                dgvStudentList.DataSource = null;
                dgvStudentList.DataSource = studentList;
            }
            
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                dgvStudentList.Rows[e.RowIndex].Selected = true;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();   // kiểm tra đúng textbox
            string lop = txtLop.Text.Trim();
            double Diem;
            if (!double.TryParse(txtPoint.Text.Trim(),
           System.Globalization.NumberStyles.Any,
           System.Globalization.CultureInfo.InvariantCulture,out Diem))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ.",
                                "Lỗi Nhập Liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            string gioitinh = comboBox1.SelectedIndex !=-1 ? comboBox1.SelectedItem.ToString() : "";
            string loai= comboBox2.SelectedIndex !=-1 ? comboBox2.SelectedItem.ToString() : "";
            string nam= comboBox3.SelectedIndex !=-1 ? comboBox3.SelectedItem.ToString() : "";
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
            savefile();

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




        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvStudentList.CurrentRow == null || dgvStudentList.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sữa.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = dgvStudentList.CurrentRow;
            if (row.Cells.Count <8)
            {
                MessageBox.Show("Dữ liệu trong bảng không đầy đủ",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            
            txtMaSV.Text = row.Cells[0].Value?.ToString() ?? "";
            txtTenSV.Text = row.Cells[1].Value?.ToString() ?? "";
            txtLop.Text = row.Cells[4].Value?.ToString() ?? "";
            txtPoint.Text = row.Cells[5].Value?.ToString() ?? "";
          string gt = row.Cells[2].Value?.ToString();
            int idx1=comboBox1.FindStringExact(gt);
            comboBox1.SelectedIndex = idx1>=0 ? idx1 : -1;
            string loai = row.Cells[6].Value?.ToString();
            int idx2 = comboBox2.FindStringExact(loai);
            comboBox2.SelectedIndex = idx2 >= 0 ? idx2 : -1;
            string nam = row.Cells[7].Value?.ToString();
            int idx3 = comboBox3.FindStringExact(nam);
            comboBox3.SelectedIndex = idx3 >= 0 ? idx3 : -1;
            string ngaysinh = row.Cells[3].Value?.ToString() ;
            if(DateTime.TryParse(ngaysinh,out DateTime dt)) { 
                dateTimePicker1.Value = dt;
            }
            txtMaSV.Enabled = false; // Khóa Mã SV để không thể sửa
            MessageBox.Show("Bạn có thể sửa thông tin sinh viên và nhấn Cập Nhật.",
                            "Chỉnh Sửa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

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

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên để cập nhật.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if(!double.TryParse(txtPoint.Text.Trim(),out double Diem))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ.",
                                "Lỗi Nhập Liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if(comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin giới tính, loại và năm.",
                                "Lỗi Nhập Liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            Student sv = studentList.Find(s => s.MSSV==txtMaSV.Text.Trim());
            if(sv == null)
            {
                MessageBox.Show($"Không tìm thấy sinh viên với Mã Sinh Viên '{txtMaSV.Text.Trim()}'.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            sv.Tên = txtTenSV.Text.Trim();
            sv.Lớp = txtLop.Text.Trim();
            sv.Điểm = Diem;
            sv.GiớiTính = comboBox1.SelectedItem.ToString();
            sv.Loại = comboBox2.SelectedItem.ToString();
            sv.Năm = comboBox3.SelectedItem.ToString();
            sv.Sinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            LoadStudentData();
            txtMaSV.Enabled = true;
            MessageBox.Show("Đã cập nhật thông tin sinh viên thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }
        private void savefile()
        {
            string filepath = @"D:\baitapnhomsoftware\clone2\student.txt";
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (var student in studentList)
                {
                    writer.WriteLine($"{student.MSSV},{student.Tên},{student.GiớiTính},{student.Sinh},{student.Lớp},{student.Điểm},{student.Loại},{student.Năm}");
                }    
                       
            }
                MessageBox.Show("Đã lưu dữ liệu sinh viên vào file student.txt",
                                "Lưu File",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
        private void btnLuufile_Click(object sender, EventArgs e)
        {
            savefile();
        }
        private void LoadFromFile()
        {
            string filepath = @"D:\baitapnhomsoftware\clone2\student.txt";
            if (!File.Exists(filepath))
            {
                MessageBox.Show("File student.txt không tồn tại.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            studentList.Clear();
            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8)
                    {
                        Student sv = new Student
                        {
                            MSSV = parts[0],
                            Tên = parts[1],
                            GiớiTính = parts[2],
                            Sinh = parts[3],
                            Lớp = parts[4],
                            Điểm = double.Parse(parts[5]),
                            Loại = parts[6],
                            Năm = parts[7]
                        };
                        studentList.Add(sv);
                    }
                }
            }
            LoadStudentData();
            MessageBox.Show("Đã tải dữ liệu sinh viên từ file student.txt",
                            "Tải File",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

    }

}
