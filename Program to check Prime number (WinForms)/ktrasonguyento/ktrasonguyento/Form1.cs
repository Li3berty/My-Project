namespace ktrasonguyento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static bool Songuyento(int e)
        {
            if (e < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(e); i++)
            {
                if (e % i == 0)
                    return false;
            }
            return true;
        }
        int dayso;
        int tongday;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKtra_Click(object sender, EventArgs e)
        {
            int nhapso = int.Parse(txtnhapso.Text);
            txtnhapso.Text = nhapso.ToString().Trim();
            if (Songuyento(nhapso))
            {
                lblKQ.Text = nhapso + " là số nguyên tố";
                dayso = nhapso;
                txtdayso.Text += dayso.ToString().Trim() + " ";
                tongday += nhapso;
                txtTongday.Text = tongday.ToString().Trim();
            }
            else
            {
                lblKQ.Text = nhapso + " không phải là số nguyên tố";
            }
        }

        private void btnDaynt_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtdenso.Text);
            for (int num = 2; num <= n; num++)
            {
                int dem = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    dayso = num;
                    txtdayso.Text += dayso.ToString().Trim() + " ";
                    tongday += num;
                    txtTongday.Text = tongday.ToString().Trim();
                }
            }

        }
    }
}