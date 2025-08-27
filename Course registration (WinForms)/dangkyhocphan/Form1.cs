namespace dangkyhocphan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (lsthocphan.Items.Count > 0)
            {
                var chon = lsthocphan.SelectedItem;
                if (chon != null)
                {
                    lstdangky.Items.Add(chon);
                    lsthocphan.Items.Remove(chon);
                }
            }
        }

        private void btnAR_Click(object sender, EventArgs e)
        {
            if (lsthocphan.Items.Count > 0)
            {
                lstdangky.Items.AddRange(lsthocphan.Items.Cast<Object>().ToArray());
                lsthocphan.Items.Clear();
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (lstdangky.Items.Count > 0)
            {
                var chon = lstdangky.SelectedItem;
                if (chon != null)
                {
                    lsthocphan.Items.Add(chon);
                    lstdangky.Items.Remove(chon);
                }
            }
        }

        private void btnAL_Click(object sender, EventArgs e)
        {
            if (lstdangky.Items.Count > 0)
            {
                lsthocphan.Items.AddRange(lstdangky.Items.Cast<Object>().ToArray());
                lstdangky.Items.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hoten = txtName.Text;
            string mssv = txtStudencode.Text;
            string lop = cbbClass.SelectedItem.ToString();
            string gioitinh = rbtMale.Checked ? "Nam" : "Nữ";
            if (CheckInfo())
            {
                txtInfo.Text = $"Họ tên: {hoten}{Environment.NewLine}" +
                                $"MSSV: {mssv}{Environment.NewLine}" +
                                $"Giới tính: {gioitinh}{Environment.NewLine}" +
                                $"Lớp: {lop}{Environment.NewLine}";
                if (lstdangky.Items.Count > 0)
                {
                    txtInfo.Text += "Các học phần đăng ký: " + Environment.NewLine +
                    string.Join(Environment.NewLine, lstdangky.Items.Cast<string>());
                }
            }
        }
        bool CheckInfo()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtName.Focus();
                return false;
            }
            if (txtStudencode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập MSSV");
                txtStudencode.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (cbbClass.Items.Count > 0)
            {
                cbbClass.SelectedIndex = 0;
                cbbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
    }
}
