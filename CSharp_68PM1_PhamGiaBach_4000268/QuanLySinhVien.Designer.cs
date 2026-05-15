namespace QLSV
{
    partial class QuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblLop;

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;

        private System.Windows.Forms.DateTimePicker dtNgaySinh;

        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ComboBox cboLop;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;

        private System.Windows.Forms.DataGridView dgvSinhVien;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();

            this.groupBox1 = new System.Windows.Forms.GroupBox();

            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();

            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();

            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();

            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua = new System.Windows.Forms.Button();
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSinhVien,
            this.menuLopHoc,
            this.menuDangXuat});

            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1500, 28);

            this.menuSinhVien.Text = "Quản Lý Sinh Viên";
            this.menuLopHoc.Click +=
            new System.EventHandler(this.menuLopHoc_Click);
            this.menuDangXuat.Click +=
            new System.EventHandler(this.menuDangXuat_Click);
            this.menuLopHoc.Text = "Quản Lý Lớp Học";
            this.menuDangXuat.Text = "Đăng xuất";

            this.groupBox1.Text = "Thông tin sinh viên";
            this.groupBox1.Location = new System.Drawing.Point(15, 50);
            this.groupBox1.Size = new System.Drawing.Size(450, 700);

            this.lblMaSV.Text = "Mã sinh viên:";
            this.lblMaSV.Location = new System.Drawing.Point(20, 40);

            this.txtMaSV.Location = new System.Drawing.Point(20, 70);
            this.txtMaSV.Size = new System.Drawing.Size(380, 25);

            this.lblHoTen.Text = "Họ và tên:";
            this.lblHoTen.Location = new System.Drawing.Point(20, 120);

            this.txtHoTen.Location = new System.Drawing.Point(20, 150);
            this.txtHoTen.Size = new System.Drawing.Size(380, 25);

            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 200);

            this.dtNgaySinh.Location = new System.Drawing.Point(20, 230);
            this.dtNgaySinh.Size = new System.Drawing.Size(380, 25);

            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 280);

            this.cboGioiTinh.Location = new System.Drawing.Point(20, 310);
            this.cboGioiTinh.Size = new System.Drawing.Size(380, 25);

            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});

            this.lblLop.Text = "Lớp:";
            this.lblLop.Location = new System.Drawing.Point(20, 360);

            this.cboLop.Location = new System.Drawing.Point(20, 390);
            this.cboLop.Size = new System.Drawing.Size(380, 25);

            this.cboLop.Items.AddRange(new object[] {
            "68PM1",
            "68PM2"});

            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(20, 500);
            this.btnThem.Size = new System.Drawing.Size(170, 50);

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(220, 500);
            this.btnSua.Size = new System.Drawing.Size(170, 50);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(20, 580);
            this.btnXoa.Size = new System.Drawing.Size(170, 50);

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(220, 580);
            this.btnLamMoi.Size = new System.Drawing.Size(170, 50);

            this.groupBox1.Controls.Add(this.lblMaSV);
            this.groupBox1.Controls.Add(this.txtMaSV);

            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtHoTen);

            this.groupBox1.Controls.Add(this.lblNgaySinh);
            this.groupBox1.Controls.Add(this.dtNgaySinh);

            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.cboGioiTinh);

            this.groupBox1.Controls.Add(this.lblLop);
            this.groupBox1.Controls.Add(this.cboLop);

            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLamMoi);

            this.txtTimKiem.Location = new System.Drawing.Point(550, 70);
            this.txtTimKiem.Size = new System.Drawing.Size(300, 25);

            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(880, 65);
            this.btnTim.Size = new System.Drawing.Size(120, 35);

            this.dgvSinhVien.Location = new System.Drawing.Point(550, 120);
            this.dgvSinhVien.Size = new System.Drawing.Size(850, 600);

            this.dgvSinhVien.ColumnCount = 5;

            this.dgvSinhVien.Columns[0].Name = "Mã SV";
            this.dgvSinhVien.Columns[1].Name = "Họ và Tên";
            this.dgvSinhVien.Columns[2].Name = "Giới Tính";
            this.dgvSinhVien.Columns[3].Name = "Ngày Sinh";
            this.dgvSinhVien.Columns[4].Name = "Lớp";

            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvSinhVien);

            this.MainMenuStrip = this.menuStrip1;

            this.ClientSize = new System.Drawing.Size(1500, 800);

            this.Text = "Quản Lý Sinh Viên";

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}