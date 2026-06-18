namespace Quanlisinhvien
{
    partial class QuanliHome_Page
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuQlsignVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQllopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuQlsignVien, this.menuQllopHoc, this.menuDangXuat });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1371, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Top;

            // menuQlsignVien
            this.menuQlsignVien.Name = "menuQlsignVien";
            this.menuQlsignVien.Text = "Quản Lý Sinh Viên";
            this.menuQlsignVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuQlsignVien.Click += new System.EventHandler(this.menuQlsignVien_Click);

            // menuQllopHoc
            this.menuQllopHoc.Name = "menuQllopHoc";
            this.menuQllopHoc.Text = "Quản Lý Lớp Học";
            this.menuQllopHoc.Click += new System.EventHandler(this.menuQllopHoc_Click);

            // menuDangXuat
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.ForeColor = System.Drawing.Color.Red;
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);

            // panel1
            this.panel1.Name = "panel1";
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;

            // QuanliHome_Page
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1371, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "QuanliHome_Page";
            this.Text = "Quản Lý Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanliHome_Page_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuQlsignVien;
        private System.Windows.Forms.ToolStripMenuItem menuQllopHoc;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.Panel panel1;
    }
}
