namespace ktrasonguyento
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
            txtnhapso = new TextBox();
            label2 = new Label();
            btnKtra = new Button();
            label3 = new Label();
            txtdayso = new TextBox();
            label4 = new Label();
            txtTongday = new TextBox();
            lblKQ = new Label();
            btnThoat = new Button();
            label5 = new Label();
            txtdenso = new TextBox();
            btnDaynt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(438, 30);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH KIỂM TRA SỐ NGUYÊN TỐ";
            // 
            // txtnhapso
            // 
            txtnhapso.Location = new Point(128, 94);
            txtnhapso.Name = "txtnhapso";
            txtnhapso.Size = new Size(222, 23);
            txtnhapso.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(23, 89);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 0;
            label2.Text = "Nhập số:";
            // 
            // btnKtra
            // 
            btnKtra.Location = new Point(370, 87);
            btnKtra.Name = "btnKtra";
            btnKtra.Size = new Size(75, 34);
            btnKtra.TabIndex = 1;
            btnKtra.Text = "Kiểm tra";
            btnKtra.UseVisualStyleBackColor = true;
            btnKtra.Click += btnKtra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(23, 199);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 0;
            label3.Text = "Dãy số nguyên tố:";
            // 
            // txtdayso
            // 
            txtdayso.Location = new Point(191, 204);
            txtdayso.Name = "txtdayso";
            txtdayso.ReadOnly = true;
            txtdayso.Size = new Size(259, 23);
            txtdayso.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(23, 257);
            label4.Name = "label4";
            label4.Size = new Size(259, 25);
            label4.TabIndex = 0;
            label4.Text = "Tổng số nguyên tố trong dãy:";
            // 
            // txtTongday
            // 
            txtTongday.Location = new Point(279, 259);
            txtTongday.Name = "txtTongday";
            txtTongday.ReadOnly = true;
            txtTongday.Size = new Size(171, 23);
            txtTongday.TabIndex = 4;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Segoe UI", 14F);
            lblKQ.Location = new Point(23, 315);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(17, 25);
            lblKQ.TabIndex = 0;
            lblKQ.Text = " ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(370, 315);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 34);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(23, 155);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 0;
            label5.Text = "Từ 1 đến:";
            // 
            // txtdenso
            // 
            txtdenso.Location = new Point(128, 155);
            txtdenso.Name = "txtdenso";
            txtdenso.Size = new Size(222, 23);
            txtdenso.TabIndex = 0;
            // 
            // btnDaynt
            // 
            btnDaynt.Location = new Point(370, 148);
            btnDaynt.Name = "btnDaynt";
            btnDaynt.Size = new Size(75, 34);
            btnDaynt.TabIndex = 5;
            btnDaynt.Text = "Kiểm tra";
            btnDaynt.UseVisualStyleBackColor = true;
            btnDaynt.Click += btnDaynt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 366);
            Controls.Add(btnDaynt);
            Controls.Add(btnThoat);
            Controls.Add(btnKtra);
            Controls.Add(txtTongday);
            Controls.Add(txtdayso);
            Controls.Add(txtdenso);
            Controls.Add(txtnhapso);
            Controls.Add(lblKQ);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnhapso;
        private Label label2;
        private Button btnKtra;
        private Label label3;
        private TextBox txtdayso;
        private Label label4;
        private TextBox txtTongday;
        private Label lblKQ;
        private Button btnThoat;
        private Label label5;
        private TextBox txtdenso;
        private Button btnDaynt;
    }
}
