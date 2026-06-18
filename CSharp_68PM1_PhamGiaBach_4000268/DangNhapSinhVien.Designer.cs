namespace Quanlisinhvien
{
    partial class DangNhapSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();

            this.pnlBackground.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // ── pnlBackground: nền xanh toàn form ──
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlBackground.Controls.Add(this.pnlCard);

            // ── pnlCard: thẻ trắng căn giữa ──
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Size = new System.Drawing.Size(420, 490);
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;

            // ── lblTieuDe ──
            this.lblTieuDe.Text = "ĐĂNG NHẬP";
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 35);
            this.lblTieuDe.Size = new System.Drawing.Size(420, 50);

            // ── lblPhuDe ──
            this.lblPhuDe.Text = "Hệ thống Quản lý Sinh viên";
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblPhuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhuDe.Location = new System.Drawing.Point(0, 85);
            this.lblPhuDe.Size = new System.Drawing.Size(420, 25);

            // ── lblUsername ──
            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblUsername.Location = new System.Drawing.Point(40, 130);
            this.lblUsername.AutoSize = true;

            // ── txtUsername ──
            this.txtUsername.Location = new System.Drawing.Point(40, 152);
            this.txtUsername.Size = new System.Drawing.Size(340, 30);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);

            // ── lblPassword ──
            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblPassword.Location = new System.Drawing.Point(40, 205);
            this.lblPassword.AutoSize = true;

            // ── txtPassword ──
            this.txtPassword.Location = new System.Drawing.Point(40, 227);
            this.txtPassword.Size = new System.Drawing.Size(340, 30);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);

            // ── chkHienMatKhau ──
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.chkHienMatKhau.Location = new System.Drawing.Point(40, 268);
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);

            // ── lblThongBao ──
            this.lblThongBao.Text = "";
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblThongBao.Location = new System.Drawing.Point(40, 298);
            this.lblThongBao.Size = new System.Drawing.Size(340, 20);
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── btnDangNhap ──
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.Location = new System.Drawing.Point(40, 328);
            this.btnDangNhap.Size = new System.Drawing.Size(340, 50);
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);

            // ── lblCopyright ──
            this.lblCopyright.Text = "© 2026  Pham Gia Bach – MSSV: 4000268";
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopyright.Location = new System.Drawing.Point(0, 435);
            this.lblCopyright.Size = new System.Drawing.Size(420, 30);

            // Thêm controls vào card
            this.pnlCard.Controls.Add(this.lblTieuDe);
            this.pnlCard.Controls.Add(this.lblPhuDe);
            this.pnlCard.Controls.Add(this.lblUsername);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.chkHienMatKhau);
            this.pnlCard.Controls.Add(this.lblThongBao);
            this.pnlCard.Controls.Add(this.btnDangNhap);
            this.pnlCard.Controls.Add(this.lblCopyright);

            // ── Form ──
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DangNhapSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập – Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form_Load);

            this.pnlBackground.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblCopyright;
    }
}
