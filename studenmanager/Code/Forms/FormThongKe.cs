using studenmanager.Code.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace studenmanager.Code.Forms
{
    public partial class FormThongKe : Form
    {
        public List<StudentForm.Student> students;
        public FormThongKe(List<StudentForm.Student>list)
        {
            InitializeComponent();
            students = list;
        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            
            students = students.OrderBy(s => s.Điểm).ToList();
            
            dgvThongKe.DataSource = students;
            HienThiThongKe();

        }
        private void HienThiThongKe ()
        {
            lblTong.Text = "Tổng số sinh viên: " + students.Count;
            lblGioi.Text = "Số sinh viên giỏi: " + students.Count(s => s.Điểm >= 8);
            lblKha.Text = "Số sinh viên khá: " + students.Count(s => s.Điểm >= 6.5 && s.Điểm < 8);
            lblTB.Text = "Số sinh viên trung bình: " + students.Count(s => s.Điểm >= 5 && s.Điểm < 6.5);
            lblYeu.Text = "Số sinh viên yếu: " + students.Count(s => s.Điểm < 5);
            lblNam.Text = "Số sinh viên nam: " + students.Count(s => s.GiớiTính == "Nam");
            lblNu.Text = "Số sinh viên nữ: " + students.Count(s => s.GiớiTính == "Nữ");
            lblDat.Text = "Số sinh viên đạt: " + students.Count(s => s.Điểm >= 5);

            lblKhongdat.Text = "Số sinh viên không đạt: " + students.Count(s => s.Điểm < 5);
            if(students.Count>0)
                lblDiemTB.Text = "Điểm trung bình: " + (students.Average(s => s.Điểm)).ToString("0.00");
            else
                lblDiemTB.Text = "Điểm trung bình: 0";



        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            StudentForm d = new StudentForm();
            d.Show();
            this.Hide();

        }
    }
}
