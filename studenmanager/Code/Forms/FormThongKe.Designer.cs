namespace studenmanager.Code.Forms
{
    partial class FormThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblKha = new System.Windows.Forms.Label();
            this.lblNu = new System.Windows.Forms.Label();
            this.lblKhongdat = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblDat = new System.Windows.Forms.Label();
            this.lblGioi = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblYeu = new System.Windows.Forms.Label();
            this.btnQuaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(49, 12);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1147, 542);
            this.dgvThongKe.TabIndex = 0;
            this.dgvThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongKe_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiemTB);
            this.groupBox1.Controls.Add(this.lblKha);
            this.groupBox1.Controls.Add(this.lblNu);
            this.groupBox1.Controls.Add(this.lblKhongdat);
            this.groupBox1.Controls.Add(this.lblTong);
            this.groupBox1.Controls.Add(this.lblDat);
            this.groupBox1.Controls.Add(this.lblGioi);
            this.groupBox1.Controls.Add(this.lblTB);
            this.groupBox1.Controls.Add(this.lblNam);
            this.groupBox1.Controls.Add(this.lblYeu);
            this.groupBox1.Location = new System.Drawing.Point(1202, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Kê";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(17, 377);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(101, 16);
            this.lblDiemTB.TabIndex = 8;
            this.lblDiemTB.Text = "Điểm trung bình:";
            // 
            // lblKha
            // 
            this.lblKha.AutoSize = true;
            this.lblKha.Location = new System.Drawing.Point(17, 120);
            this.lblKha.Name = "lblKha";
            this.lblKha.Size = new System.Drawing.Size(30, 16);
            this.lblKha.TabIndex = 4;
            this.lblKha.Text = "Khá";
            // 
            // lblNu
            // 
            this.lblNu.AutoSize = true;
            this.lblNu.Location = new System.Drawing.Point(17, 283);
            this.lblNu.Name = "lblNu";
            this.lblNu.Size = new System.Drawing.Size(24, 16);
            this.lblNu.TabIndex = 5;
            this.lblNu.Text = "Nữ";
            this.lblNu.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblKhongdat
            // 
            this.lblKhongdat.AutoSize = true;
            this.lblKhongdat.Location = new System.Drawing.Point(17, 351);
            this.lblKhongdat.Name = "lblKhongdat";
            this.lblKhongdat.Size = new System.Drawing.Size(67, 16);
            this.lblKhongdat.TabIndex = 7;
            this.lblKhongdat.Text = "Không đạt";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(17, 29);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(97, 16);
            this.lblTong.TabIndex = 2;
            this.lblTong.Text = "Tổng sinh viên:";
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new System.Drawing.Point(17, 313);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(27, 16);
            this.lblDat.TabIndex = 6;
            this.lblDat.Text = "Đạt";
            // 
            // lblGioi
            // 
            this.lblGioi.AutoSize = true;
            this.lblGioi.Location = new System.Drawing.Point(17, 69);
            this.lblGioi.Name = "lblGioi";
            this.lblGioi.Size = new System.Drawing.Size(31, 16);
            this.lblGioi.TabIndex = 3;
            this.lblGioi.Text = "Giỏi";
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Location = new System.Drawing.Point(17, 160);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(73, 16);
            this.lblTB.TabIndex = 2;
            this.lblTB.Text = "Trung bình:";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(17, 245);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(36, 16);
            this.lblNam.TabIndex = 4;
            this.lblNam.Text = "Nam";
            // 
            // lblYeu
            // 
            this.lblYeu.AutoSize = true;
            this.lblYeu.Location = new System.Drawing.Point(17, 203);
            this.lblYeu.Name = "lblYeu";
            this.lblYeu.Size = new System.Drawing.Size(34, 16);
            this.lblYeu.TabIndex = 3;
            this.lblYeu.Text = "Yếu:";
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(501, 586);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 23);
            this.btnQuaylai.TabIndex = 2;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 618);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "FormThongKe";
            this.Text = "Thongke";
            this.Load += new System.EventHandler(this.Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKha;
        private System.Windows.Forms.Label lblKhongdat;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.Label lblGioi;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblYeu;
        private System.Windows.Forms.Label lblNu;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Button btnQuaylai;
    }
}