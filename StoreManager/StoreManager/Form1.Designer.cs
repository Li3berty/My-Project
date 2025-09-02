namespace StoreManager
{
    partial class frmSM
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lstProducts = new ListBox();
            lstResult = new ListBox();
            chklnStock = new CheckBox();
            cboCategory = new ComboBox();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnStatistics = new Button();
            btnFind = new Button();
            btnClose = new Button();
            label8 = new Label();
            txtSearch = new TextBox();
            btnDel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 0;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 138);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 0;
            label4.Text = "Loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 175);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Còn hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 241);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 0;
            label6.Text = "Danh sách sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(355, 241);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 0;
            label7.Text = "Thông tin sản phẩm";
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(18, 259);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(311, 169);
            lstProducts.TabIndex = 10;
            // 
            // lstResult
            // 
            lstResult.FormattingEnabled = true;
            lstResult.ItemHeight = 15;
            lstResult.Location = new Point(355, 259);
            lstResult.Name = "lstResult";
            lstResult.Size = new Size(225, 169);
            lstResult.TabIndex = 11;
            // 
            // chklnStock
            // 
            chklnStock.AutoSize = true;
            chklnStock.Location = new Point(112, 176);
            chklnStock.Name = "chklnStock";
            chklnStock.Size = new Size(15, 14);
            chklnStock.TabIndex = 4;
            chklnStock.UseVisualStyleBackColor = true;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Điện tử", "Thời trang", "Đồ gia dụng", "Thực phẩm" });
            cboCategory.Location = new Point(112, 135);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(242, 23);
            cboCategory.TabIndex = 3;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(112, 34);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(154, 23);
            txtProductID.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(112, 68);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(242, 23);
            txtProductName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(112, 102);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(154, 23);
            txtPrice.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(415, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 28);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(415, 87);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(103, 28);
            btnStatistics.TabIndex = 6;
            btnStatistics.Text = "Thống kê";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(415, 141);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(103, 28);
            btnFind.TabIndex = 7;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(415, 195);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 28);
            btnClose.TabIndex = 8;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 210);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 11;
            label8.Text = "Tìm sản phẩm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(112, 207);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 23);
            txtSearch.TabIndex = 9;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(0, 0);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 0;
            // 
            // frmSM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 440);
            Controls.Add(btnDel);
            Controls.Add(label8);
            Controls.Add(btnClose);
            Controls.Add(btnFind);
            Controls.Add(btnStatistics);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtSearch);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(cboCategory);
            Controls.Add(chklnStock);
            Controls.Add(lstResult);
            Controls.Add(lstProducts);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ SẢN PHẨM TRONG CỬA HÀNG";
            Load += frmSM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox lstProducts;
        private ListBox lstResult;
        private CheckBox chklnStock;
        private ComboBox cboCategory;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnStatistics;
        private Button btnFind;
        private Button btnClose;
        private Label label8;
        private TextBox txtSearch;
        private Button btnDel;
    }
}
