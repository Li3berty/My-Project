using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace StoreManager
{
    public partial class frmSM : Form
    {
        public frmSM()
        {
            InitializeComponent();
        }
        List<string> Products = new List<string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // mã sp phải có dạng P#### và không được rỗng
            string ProductID = txtProductID.Text.Trim();
            if (string.IsNullOrEmpty(ProductID) || !Regex.IsMatch(ProductID, @"^P\d{4}$"))
            {
                MessageBox.Show("Mã SP phải dạng P#### (ví dụ: P0001) và không được để trống.");
                return;
            }
            // tên sp phải hơn 2 từ 
            string ProductName = txtProductName.Text;
            int Count = ProductName.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            if (string.IsNullOrEmpty(ProductName) || Count < 2)
            {
                MessageBox.Show("Tên SP phải có ít nhất 2 từ và không được để trống.");
                return;
            }
            // giá phải là số và lớn hơn 0
            string Price = txtPrice.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(Price, NumberStyles.Number, CultureInfo.InvariantCulture, out var price) || price <= 0)
            {
                MessageBox.Show("Giá phải là số và lớn hơn 0.");
                return;
            }
            string Category = cboCategory.SelectedItem.ToString();
            string Checked = (chklnStock.Checked) ? "Còn" : "Hết";
            string add = $"{ProductID} - {ProductName} - {Category} - {Price} - {Checked}";
            lstProducts.Items.Clear();
            Products.Add(add);
            lstProducts.Items.AddRange(Products.ToArray());
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            chklnStock.Checked = false;
            txtProductID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string[] GenerateProductStats(ListBox productList)
        {
            int countDienTu = 0, countThoiTrang = 0, countDoGiaDung = 0, countThucPham = 0, countConHang = 0;
            double tongGia = 0;
            int tongSP = productList.Items.Count;
            // tìm trong list mã sp - tên sp - loại - giá - trạng thái
            foreach (var item in productList.Items)
            {
                string[] parts = item.ToString().Split('-');
                if (parts.Length < 5) continue;

                string loai = parts[2].Trim();
                double gia = double.Parse(parts[3].Trim());
                string trangThai = parts[4].Trim();

                // đếm theo loại
                switch (loai)
                {
                    case "Điện tử": countDienTu++; break;
                    case "Thời trang": countThoiTrang++; break;
                    case "Đồ gia dụng": countDoGiaDung++; break;
                    case "Thực phẩm": countThucPham++; break;
                }
                tongGia += gia;
                if (trangThai == "Còn")
                    countConHang++;
            }

            // tính giá TB
            double giaTB = tongSP > 0 ? tongGia / tongSP : 0;

            // xuất chuỗi kết quả
            return new[]
                        {
                            "THỐNG KÊ:",
                            $"- Điện tử: {countDienTu} sản phẩm",
                            $"- Thời trang: {countThoiTrang} sản phẩm",
                            $"- Đồ gia dụng: {countDoGiaDung} sản phẩm",
                            $"- Thực phẩm: {countThucPham} sản phẩm",
                            $"Giá TB: {Math.Round(giaTB, 1)}",
                            $"Còn hàng: {countConHang}"

                        };
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            lstResult.Items.AddRange(GenerateProductStats(lstProducts));
        }

        private void frmSM_Load(object sender, EventArgs e)
        {
            // mặc định để không dính lỗi không chọn
            cboCategory.SelectedIndex = 0;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        List<string> SearchProducts(ListBox productList, string keyword, bool searchByID)
        {
            List<string> result = new List<string>();
            foreach (var item in productList.Items)
            {
                string product = item.ToString();

                if (searchByID)
                {
                    // tìm chính xác theo mã sản phẩm
                    // StartsWith là để kiểm tra coi chuỗi product có bắt đầu bằng keyword hay hông
                    if (product.StartsWith(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(product);
                    }
                }
                else
                {
                    // tìm theo tên sản phẩm (không phân biệt hoa thường)
                    // dùng Index để đếm vị trí, bất kể đâu nếu phát hiện thì sẽ lớn hơn = 0 
                    if (product.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Add(product);
                    }
                }
            }
            return result;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo");
                return;
            }
            bool searchByID = keyword.StartsWith("P", StringComparison.OrdinalIgnoreCase);
            List<string> results = SearchProducts(lstProducts, keyword, searchByID);
            if (results.Count > 0)
            {
                string message = string.Join("\n", results);
                MessageBox.Show(message, "Kết quả tìm kiếm");
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm phù hợp", "Kết quả tìm kiếm");
            }
        }
    }
}