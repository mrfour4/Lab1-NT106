namespace Lab1
{
    partial class ManageStudent
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.Label();
            this.txtRanked = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxScore = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnpass = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInput.Location = new System.Drawing.Point(217, 88);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(541, 27);
            this.txtInput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLayout);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(51, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.groupBox1.Size = new System.Drawing.Size(707, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học và điểm";
            // 
            // txtLayout
            // 
            this.txtLayout.AutoScroll = true;
            this.txtLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLayout.ForeColor = System.Drawing.Color.Brown;
            this.txtLayout.Location = new System.Drawing.Point(0, 40);
            this.txtLayout.Margin = new System.Windows.Forms.Padding(10);
            this.txtLayout.Name = "txtLayout";
            this.txtLayout.Padding = new System.Windows.Forms.Padding(10);
            this.txtLayout.Size = new System.Drawing.Size(707, 144);
            this.txtLayout.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrint.Location = new System.Drawing.Point(217, 154);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 41);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Xuất";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phần mềm quản lý điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(47, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(57, 455);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Điểm trung bình:";
            // 
            // txtAvg
            // 
            this.txtAvg.AutoSize = true;
            this.txtAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAvg.Location = new System.Drawing.Point(213, 455);
            this.txtAvg.Margin = new System.Windows.Forms.Padding(3);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(45, 22);
            this.txtAvg.TabIndex = 6;
            this.txtAvg.Text = "7.33";
            this.txtAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRanked
            // 
            this.txtRanked.AutoSize = true;
            this.txtRanked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRanked.Location = new System.Drawing.Point(607, 455);
            this.txtRanked.Margin = new System.Windows.Forms.Padding(3);
            this.txtRanked.Name = "txtRanked";
            this.txtRanked.Size = new System.Drawing.Size(45, 22);
            this.txtRanked.TabIndex = 8;
            this.txtRanked.Text = "7.33";
            this.txtRanked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(440, 455);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Xếp loại học lực:";
            // 
            // txtMinScore
            // 
            this.txtMinScore.AutoSize = true;
            this.txtMinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMinScore.Location = new System.Drawing.Point(673, 504);
            this.txtMinScore.Margin = new System.Windows.Forms.Padding(3);
            this.txtMinScore.Name = "txtMinScore";
            this.txtMinScore.Size = new System.Drawing.Size(45, 22);
            this.txtMinScore.TabIndex = 12;
            this.txtMinScore.Text = "7.33";
            this.txtMinScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(440, 504);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Môn có điểm thấp nhất:";
            // 
            // txtMaxScore
            // 
            this.txtMaxScore.AutoSize = true;
            this.txtMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaxScore.Location = new System.Drawing.Point(276, 504);
            this.txtMaxScore.Margin = new System.Windows.Forms.Padding(3);
            this.txtMaxScore.Name = "txtMaxScore";
            this.txtMaxScore.Size = new System.Drawing.Size(45, 22);
            this.txtMaxScore.TabIndex = 10;
            this.txtMaxScore.Text = "7.33";
            this.txtMaxScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(57, 504);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Môn có điểm cao nhất:";
            // 
            // txtUnpass
            // 
            this.txtUnpass.AutoSize = true;
            this.txtUnpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUnpass.ForeColor = System.Drawing.Color.Firebrick;
            this.txtUnpass.Location = new System.Drawing.Point(641, 549);
            this.txtUnpass.Margin = new System.Windows.Forms.Padding(3);
            this.txtUnpass.Name = "txtUnpass";
            this.txtUnpass.Size = new System.Drawing.Size(45, 22);
            this.txtUnpass.TabIndex = 16;
            this.txtUnpass.Text = "7.33";
            this.txtUnpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(440, 549);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 22);
            this.label12.TabIndex = 15;
            this.label12.Text = "Số môn không đậu: ";
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.ForeColor = System.Drawing.Color.Green;
            this.txtPass.Location = new System.Drawing.Point(202, 549);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(45, 22);
            this.txtPass.TabIndex = 14;
            this.txtPass.Text = "7.33";
            this.txtPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(57, 549);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 22);
            this.label14.TabIndex = 13;
            this.label14.Text = "Số môn đậu: ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(611, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 41);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDel.Location = new System.Drawing.Point(422, 154);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(147, 41);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 619);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUnpass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMinScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaxScore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRanked);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInput);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel txtLayout;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtAvg;
        private System.Windows.Forms.Label txtRanked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtMinScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtMaxScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtUnpass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
    }
}