using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> StudentInfo = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numAge.Value > 30)
            {
                DialogResult result = MessageBox.Show(
                "Tuổi lớn hơn 30, bạn có chắc muốn thêm không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; // Hủy thao tác thêm
                }
            }
            string Name = txtName.Text;
            Name = FormatName(Name);
            string Age = numAge.Value.ToString();
            string Class = cboClass.SelectedItem.ToString();
            string Info = $"{Name} - {Age} - {Class}";
            StudentInfo.Add(Info);
            lstStudents.Items.Clear();
            lstStudents.Items.AddRange(StudentInfo.ToArray());
            lblCount.Text = "Số lượng sinh viên: " + lstStudents.Items.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cboClass.Items.Count > 0)
            {
                cboClass.SelectedIndex = 0;
                cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtName.Text.Trim().ToLower();
            var result = new List<string>();
            foreach (var student in StudentInfo)
            {
                if (student.Trim().ToLower().Contains(keyword))
                {
                    result.Add(student);
                }
            }
            if (result.Any())
            {
                lblResult.Text = "Kết quả: \n" + string.Join("\n", result);
            }
            else
            {
                lblResult.Text = "Không tìm thấy";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                StudentInfo.RemoveAt(lstStudents.SelectedIndex);
                lstStudents.Items.Remove(lstStudents.SelectedItem);
                lblCount.Text = "Số lượng sinh viên: " + lstStudents.Items.Count;
                string keyword = txtName.Text.Trim().ToLower();
                var result = new List<string>();
                foreach (var student in StudentInfo)
                {
                    if (student.Trim().ToLower().Contains(keyword))
                    {
                        result.Add(student);
                    }
                }
                if (result.Any())
                {
                    lblResult.Text = "Kết quả: \n" + string.Join("\n", result);
                }
                else
                {
                    lblResult.Text = "Không tìm thấy";
                }
            }
        }

        private void btnStudentByClass_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> classCount = new Dictionary<string, int>
            {
                { "CNTT", 0 },
                { "HTTT", 0 },
                { "KHDL", 0 }
            };

            // Duyệt danh sách sinh viên
            foreach (var student in StudentInfo)
            {
                foreach (var key in classCount.Keys.ToList())
                {
                    if (student.Contains(key))
                    {
                        classCount[key]++;
                    }
                }
            }

            // Hiển thị kết quả
            lblResult.Text = string.Join("\n",
                classCount.Select(c => $"{c.Key}: {c.Value} Sinh viên"));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            StudentInfo.Sort();
            lstStudents.Items.Clear();
            lstStudents.Items.AddRange(StudentInfo.ToArray());
        }
        private string FormatName(string name)
        {
            // Bỏ khoảng trắng dư, viết thường toàn bộ
            name = name.Trim().ToLower();

            // Dùng CultureInfo để viết hoa chữ cái đầu mỗi từ
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(name);
        }

    }
}
