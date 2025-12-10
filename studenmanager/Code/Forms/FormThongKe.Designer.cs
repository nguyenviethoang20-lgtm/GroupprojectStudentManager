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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(82, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1019, 568);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 618);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThongKe";
            this.Text = "Thongke";
            this.Load += new System.EventHandler(this.Thongke_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}