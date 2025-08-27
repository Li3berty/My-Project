namespace dangkyhocphan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            rbtMale = new RadioButton();
            cbbClass = new ComboBox();
            lsthocphan = new ListBox();
            btnSave = new Button();
            label2 = new Label();
            txtStudencode = new TextBox();
            label3 = new Label();
            rbtFemale = new RadioButton();
            label4 = new Label();
            btnR = new Button();
            label5 = new Label();
            label6 = new Label();
            lstdangky = new ListBox();
            btnAR = new Button();
            btnL = new Button();
            btnAL = new Button();
            txtInfo = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(61, 79);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13F);
            txtName.Location = new Point(144, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 31);
            txtName.TabIndex = 0;
            // 
            // rbtMale
            // 
            rbtMale.AutoSize = true;
            rbtMale.Checked = true;
            rbtMale.Font = new Font("Segoe UI", 13F);
            rbtMale.Location = new Point(144, 183);
            rbtMale.Name = "rbtMale";
            rbtMale.Size = new Size(68, 29);
            rbtMale.TabIndex = 2;
            rbtMale.TabStop = true;
            rbtMale.Text = "Nam";
            rbtMale.UseVisualStyleBackColor = true;
            // 
            // cbbClass
            // 
            cbbClass.Font = new Font("Segoe UI", 13F);
            cbbClass.FormattingEnabled = true;
            cbbClass.Items.AddRange(new object[] { "CNTT2411 - Công Nghệ Thông Tin 2024", "HTTT2411 - Hệ Thống Thông Tin 2024", "KTPM2411 - Kỹ Thuật Phần Mềm 2024", "KHMT2411 - Khoa Học Máy Tính 2024", "KHDL2411 - Khoa Học Dữ Liệu 2024" });
            cbbClass.Location = new Point(144, 235);
            cbbClass.Name = "cbbClass";
            cbbClass.Size = new Size(330, 31);
            cbbClass.TabIndex = 4;
            // 
            // lsthocphan
            // 
            lsthocphan.Font = new Font("Segoe UI", 10F);
            lsthocphan.FormattingEnabled = true;
            lsthocphan.ItemHeight = 17;
            lsthocphan.Items.AddRange(new object[] { "Toán rời rạc", "Kỹ thuật lập trình", "Đại số tuyến tính", "Anh văn căn bản", "Cấu trúc dữ liệu và giải thuật", "Lập trình hướng đối tượng", "Pháp luật đại cương", "Xác suất thống kê", "Cơ sở dữ liệu" });
            lsthocphan.Location = new Point(19, 315);
            lsthocphan.Name = "lsthocphan";
            lsthocphan.Size = new Size(200, 123);
            lsthocphan.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13F);
            btnSave.Location = new Point(399, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 35);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(69, 121);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 0;
            label2.Text = "MSSV:";
            // 
            // txtStudencode
            // 
            txtStudencode.Font = new Font("Segoe UI", 13F);
            txtStudencode.Location = new Point(144, 118);
            txtStudencode.Name = "txtStudencode";
            txtStudencode.Size = new Size(214, 31);
            txtStudencode.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(50, 182);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 0;
            label3.Text = "Giới tính:";
            // 
            // rbtFemale
            // 
            rbtFemale.AutoSize = true;
            rbtFemale.Font = new Font("Segoe UI", 13F);
            rbtFemale.Location = new Point(304, 183);
            rbtFemale.Name = "rbtFemale";
            rbtFemale.Size = new Size(54, 29);
            rbtFemale.TabIndex = 3;
            rbtFemale.Text = "Nữ";
            rbtFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(86, 238);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 0;
            label4.Text = "Lớp:";
            // 
            // btnR
            // 
            btnR.Font = new Font("Segoe UI", 11F);
            btnR.Location = new Point(234, 315);
            btnR.Name = "btnR";
            btnR.Size = new Size(75, 25);
            btnR.TabIndex = 6;
            btnR.Text = ">";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(45, 292);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 0;
            label5.Text = "Các học phần mở";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(375, 292);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 0;
            label6.Text = "Học phần đăng ký";
            // 
            // lstdangky
            // 
            lstdangky.Font = new Font("Segoe UI", 10F);
            lstdangky.FormattingEnabled = true;
            lstdangky.ItemHeight = 17;
            lstdangky.Location = new Point(330, 315);
            lstdangky.Name = "lstdangky";
            lstdangky.Size = new Size(200, 123);
            lstdangky.TabIndex = 5;
            // 
            // btnAR
            // 
            btnAR.Font = new Font("Segoe UI", 11F);
            btnAR.Location = new Point(234, 346);
            btnAR.Name = "btnAR";
            btnAR.Size = new Size(75, 25);
            btnAR.TabIndex = 7;
            btnAR.Text = ">>";
            btnAR.UseVisualStyleBackColor = true;
            btnAR.Click += btnAR_Click;
            // 
            // btnL
            // 
            btnL.Font = new Font("Segoe UI", 11F);
            btnL.Location = new Point(234, 382);
            btnL.Name = "btnL";
            btnL.Size = new Size(75, 25);
            btnL.TabIndex = 8;
            btnL.Text = "<";
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // btnAL
            // 
            btnAL.Font = new Font("Segoe UI", 11F);
            btnAL.Location = new Point(234, 413);
            btnAL.Name = "btnAL";
            btnAL.Size = new Size(75, 25);
            btnAL.TabIndex = 9;
            btnAL.Text = "<<";
            btnAL.UseVisualStyleBackColor = true;
            btnAL.Click += btnAL_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(558, 63);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(268, 375);
            txtInfo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(618, 35);
            label7.Name = "label7";
            label7.Size = new Size(168, 25);
            label7.TabIndex = 0;
            label7.Text = "Thông tin tổng hợp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(217, 27);
            label8.Name = "label8";
            label8.Size = new Size(257, 32);
            label8.TabIndex = 0;
            label8.Text = "ĐĂNG KÝ HỌC PHẦN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(txtInfo);
            Controls.Add(btnAL);
            Controls.Add(btnL);
            Controls.Add(btnAR);
            Controls.Add(btnR);
            Controls.Add(btnSave);
            Controls.Add(lstdangky);
            Controls.Add(lsthocphan);
            Controls.Add(cbbClass);
            Controls.Add(rbtFemale);
            Controls.Add(rbtMale);
            Controls.Add(txtStudencode);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private RadioButton rbtMale;
        private ComboBox cbbClass;
        private ListBox lsthocphan;
        private Button btnSave;
        private Label label2;
        private TextBox txtStudencode;
        private Label label3;
        private RadioButton rbtFemale;
        private Label label4;
        private Button btnR;
        private Label label5;
        private Label label6;
        private ListBox lstdangky;
        private Button btnAR;
        private Button btnL;
        private Button btnAL;
        private TextBox txtInfo;
        private Label label7;
        private Label label8;
    }
}
