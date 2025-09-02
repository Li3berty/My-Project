namespace StudentInfo
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
            txtName = new TextBox();
            numAge = new NumericUpDown();
            cboClass = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnDel = new Button();
            btnSearch = new Button();
            btnStudentByClass = new Button();
            lstStudents = new ListBox();
            lblResult = new Label();
            lblCount = new Label();
            btnSort = new Button();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(125, 28);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 25);
            txtName.TabIndex = 0;
            // 
            // numAge
            // 
            numAge.Font = new Font("Segoe UI", 10F);
            numAge.Location = new Point(125, 81);
            numAge.Margin = new Padding(5, 8, 5, 8);
            numAge.Name = "numAge";
            numAge.Size = new Size(40, 25);
            numAge.TabIndex = 1;
            // 
            // cboClass
            // 
            cboClass.Font = new Font("Segoe UI", 10F);
            cboClass.FormattingEnabled = true;
            cboClass.Items.AddRange(new object[] { "CNTT", "HTTT", "KHDL" });
            cboClass.Location = new Point(125, 137);
            cboClass.Margin = new Padding(4, 5, 4, 5);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(175, 25);
            cboClass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(22, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 3;
            label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(22, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 3;
            label2.Text = "Tuổi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(22, 137);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 3;
            label3.Text = "Lớp:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(333, 18);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(464, 19);
            btnDel.Margin = new Padding(4, 5, 4, 5);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(96, 35);
            btnDel.TabIndex = 4;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(333, 63);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 35);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnStudentByClass
            // 
            btnStudentByClass.Location = new Point(464, 64);
            btnStudentByClass.Margin = new Padding(4, 5, 4, 5);
            btnStudentByClass.Name = "btnStudentByClass";
            btnStudentByClass.Size = new Size(96, 35);
            btnStudentByClass.TabIndex = 4;
            btnStudentByClass.Text = "Đếm";
            btnStudentByClass.UseVisualStyleBackColor = true;
            btnStudentByClass.Click += btnStudentByClass_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 23;
            lstStudents.Location = new Point(22, 186);
            lstStudents.Margin = new Padding(4, 5, 4, 5);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(311, 165);
            lstStudents.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13F);
            lblResult.Location = new Point(333, 156);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 3;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 13F);
            lblCount.Location = new Point(22, 365);
            lblCount.Margin = new Padding(4, 0, 4, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 25);
            lblCount.TabIndex = 3;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(333, 106);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(96, 35);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sắp xếp";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 398);
            Controls.Add(btnSort);
            Controls.Add(lstStudents);
            Controls.Add(btnStudentByClass);
            Controls.Add(btnDel);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(lblCount);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboClass);
            Controls.Add(numAge);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private NumericUpDown numAge;
        private ComboBox cboClass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnDel;
        private Button btnSearch;
        private Button btnStudentByClass;
        private ListBox lstStudents;
        private Label lblResult;
        private Label lblCount;
        private Button btnSort;
    }
}
