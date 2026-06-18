using System;
using System.Windows.Forms;

namespace Quanlisinhvien
{
    public partial class DangNhapSinhVien : Form
    {
        private const string DUNG_USERNAME = "4000268@st.huce.edu.vn";
        private const string DUNG_PASSWORD = "4000268";

        public DangNhapSinhVien()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblThongBao.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                lblThongBao.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                return;
            }

            if (username == DUNG_USERNAME && password == DUNG_PASSWORD)
            {
                this.Hide();
                var mainForm = new QuanliHome_Page();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                lblThongBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                lblThongBao.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CenterCard();
            txtUsername.Focus();
        }

        private void CenterCard()
        {
            pnlCard.Location = new System.Drawing.Point(
                (pnlBackground.Width - pnlCard.Width) / 2,
                (pnlBackground.Height - pnlCard.Height) / 2);
        }
    }
}
