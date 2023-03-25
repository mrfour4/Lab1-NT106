namespace Lab1
{
    partial class ConverHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverHDB));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.selectTypeNum = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFrom = new System.Windows.Forms.ComboBox();
            this.btnConver = new System.Windows.Forms.Button();
            this.selectTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.labelTypeNum = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.titleTypeNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.selectTypeNum);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectFrom);
            this.groupBox1.Controls.Add(this.btnConver);
            this.groupBox1.Controls.Add(this.selectTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.labelTypeNum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(109, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(652, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // selectTypeNum
            // 
            this.selectTypeNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTypeNum.FormattingEnabled = true;
            this.selectTypeNum.Items.AddRange(new object[] {
            "Số nguyên",
            "Số thập phân"});
            this.selectTypeNum.Location = new System.Drawing.Point(202, 49);
            this.selectTypeNum.Name = "selectTypeNum";
            this.selectTypeNum.Size = new System.Drawing.Size(161, 30);
            this.selectTypeNum.TabIndex = 9;
            this.selectTypeNum.SelectedIndexChanged += new System.EventHandler(this.selectTypeNum_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDel.Location = new System.Drawing.Point(439, 279);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(162, 42);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn kiểu số";
            // 
            // selectFrom
            // 
            this.selectFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFrom.FormattingEnabled = true;
            this.selectFrom.Items.AddRange(new object[] {
            "Decimal",
            "Hexadecimal",
            "Binary"});
            this.selectFrom.Location = new System.Drawing.Point(303, 192);
            this.selectFrom.Name = "selectFrom";
            this.selectFrom.Size = new System.Drawing.Size(183, 30);
            this.selectFrom.TabIndex = 7;
            // 
            // btnConver
            // 
            this.btnConver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConver.Location = new System.Drawing.Point(202, 278);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(200, 43);
            this.btnConver.TabIndex = 6;
            this.btnConver.Text = "Thực hiện";
            this.btnConver.UseVisualStyleBackColor = false;
            this.btnConver.Click += new System.EventHandler(this.btnConver_Click);
            // 
            // selectTo
            // 
            this.selectTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTo.FormattingEnabled = true;
            this.selectTo.Items.AddRange(new object[] {
            "Decimal",
            "Hexadecimal",
            "Binary"});
            this.selectTo.Location = new System.Drawing.Point(604, 192);
            this.selectTo.Name = "selectTo";
            this.selectTo.Size = new System.Drawing.Size(183, 30);
            this.selectTo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInput.Location = new System.Drawing.Point(202, 127);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(623, 30);
            this.txtInput.TabIndex = 1;
            // 
            // labelTypeNum
            // 
            this.labelTypeNum.AutoSize = true;
            this.labelTypeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTypeNum.Location = new System.Drawing.Point(70, 127);
            this.labelTypeNum.Name = "labelTypeNum";
            this.labelTypeNum.Size = new System.Drawing.Size(111, 22);
            this.labelTypeNum.TabIndex = 0;
            this.labelTypeNum.Text = "Nhập một số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(190, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả";
            // 
            // txtResult
            // 
            this.txtResult.AllowDrop = true;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtResult.Location = new System.Drawing.Point(311, 536);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(629, 55);
            this.txtResult.TabIndex = 7;
            // 
            // titleTypeNum
            // 
            this.titleTypeNum.AutoSize = true;
            this.titleTypeNum.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.titleTypeNum.Location = new System.Drawing.Point(236, 68);
            this.titleTypeNum.Name = "titleTypeNum";
            this.titleTypeNum.Size = new System.Drawing.Size(506, 46);
            this.titleTypeNum.TabIndex = 8;
            this.titleTypeNum.Text = "CHUYỂN ĐỔI SỐ NGUYÊN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(307, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(561, 80);
            this.label5.TabIndex = 9;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // ConverHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleTypeNum);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConverHDB";
            this.Text = "Convert Hex, Dec, Bin";
            this.Load += new System.EventHandler(this.ConverHDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label labelTypeNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox selectTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox selectFrom;
        private System.Windows.Forms.Label titleTypeNum;
        private System.Windows.Forms.ComboBox selectTypeNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
    }
}