namespace studenmanager
{
    partial class Form1
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
            this.btnOpenStudentForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenStudentForm
            // 
            this.btnOpenStudentForm.Location = new System.Drawing.Point(135, 135);
            this.btnOpenStudentForm.Name = "btnOpenStudentForm";
            this.btnOpenStudentForm.Size = new System.Drawing.Size(255, 179);
            this.btnOpenStudentForm.TabIndex = 0;
            this.btnOpenStudentForm.Text = "Open Student Form";
            this.btnOpenStudentForm.UseVisualStyleBackColor = true;
            this.btnOpenStudentForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenStudentForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenStudentForm;
    }
}

