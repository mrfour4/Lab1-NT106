namespace Lab1
{
    partial class Dashboard
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
            this.btnBai1 = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCovertHDB = new System.Windows.Forms.Button();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBai1
            // 
            this.btnBai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBai1.Location = new System.Drawing.Point(113, 105);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new System.Drawing.Size(207, 70);
            this.btnBai1.TabIndex = 0;
            this.btnBai1.Text = "Bài 1";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMinMax.Location = new System.Drawing.Point(493, 105);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(207, 70);
            this.btnMinMax.TabIndex = 1;
            this.btnMinMax.Text = "Bài 2";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(116, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bài 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCovertHDB
            // 
            this.btnCovertHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCovertHDB.Location = new System.Drawing.Point(493, 237);
            this.btnCovertHDB.Name = "btnCovertHDB";
            this.btnCovertHDB.Size = new System.Drawing.Size(207, 70);
            this.btnCovertHDB.TabIndex = 4;
            this.btnCovertHDB.Text = "Bài 4";
            this.btnCovertHDB.UseVisualStyleBackColor = true;
            this.btnCovertHDB.Click += new System.EventHandler(this.btnCovertHDB_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnManageStudent.Location = new System.Drawing.Point(116, 356);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(207, 70);
            this.btnManageStudent.TabIndex = 5;
            this.btnManageStudent.Text = "Bài 5";
            this.btnManageStudent.UseVisualStyleBackColor = true;
            this.btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(359, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lab 1";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(112, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 60);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lưu ý: chương trình sẽ hoạt động không chính xác nếu như ngôn ngữ nhập của bạn kh" +
    "ông phải tiếng Anh";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManageStudent);
            this.Controls.Add(this.btnCovertHDB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnBai1);
            this.Name = "Dashboard";
            this.Text = "Lab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCovertHDB;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

