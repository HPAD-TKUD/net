using Microsoft.VisualBasic;

namespace BaiTapThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void Xuly_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;

            MessageBox.Show($"Xin chào bạn {tenDaNhap}, Rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
