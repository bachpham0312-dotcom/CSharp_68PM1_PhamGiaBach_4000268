namespace Quanlisinhvien
{
    partial class QuanliSinhVien_Page
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.pnlPaging = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblTrang = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();

            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.pnlPaging.SuspendLayout();
            this.SuspendLayout();

            // grpThongTin
            this.grpThongTin.Text = "Thông tin sinh viên";
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(10, 10);
            this.grpThongTin.Size = new System.Drawing.Size(435, 640);
            this.grpThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Bottom;
            this.grpThongTin.BackColor = System.Drawing.Color.WhiteSmoke;

            // lblMaSV
            this.lblMaSV.Text = "Mã sinh viên:";
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaSV.Location = new System.Drawing.Point(18, 30);
            this.lblMaSV.AutoSize = true;

            // txtMaSV
            this.txtMaSV.Location = new System.Drawing.Point(18, 52);
            this.txtMaSV.Size = new System.Drawing.Size(395, 28);
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblHoTen
            this.lblHoTen.Text = "Họ và tên:";
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(18, 100);
            this.lblHoTen.AutoSize = true;

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(18, 122);
            this.txtHoTen.Size = new System.Drawing.Size(395, 28);
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblNgaySinh
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgaySinh.Location = new System.Drawing.Point(18, 170);
            this.lblNgaySinh.AutoSize = true;

            // dtNgaySinh
            this.dtNgaySinh.Location = new System.Drawing.Point(18, 192);
            this.dtNgaySinh.Size = new System.Drawing.Size(395, 28);
            this.dtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblGioiTinh
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.Location = new System.Drawing.Point(18, 240);
            this.lblGioiTinh.AutoSize = true;

            // cboGioiTinh
            this.cboGioiTinh.Location = new System.Drawing.Point(18, 262);
            this.cboGioiTinh.Size = new System.Drawing.Size(395, 28);
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.SelectedIndex = 0;

            // lblLop
            this.lblLop.Text = "Lớp:";
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLop.Location = new System.Drawing.Point(18, 310);
            this.lblLop.AutoSize = true;

            // cboLop
            this.cboLop.Location = new System.Drawing.Point(18, 332);
            this.cboLop.Size = new System.Drawing.Size(395, 28);
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnThem
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(18, 490);
            this.btnThem.Size = new System.Drawing.Size(190, 55);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(222, 490);
            this.btnSua.Size = new System.Drawing.Size(190, 55);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(18, 560);
            this.btnXoa.Size = new System.Drawing.Size(190, 55);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(222, 560);
            this.btnLamMoi.Size = new System.Drawing.Size(190, 55);
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.grpThongTin.Controls.Add(this.lblMaSV);
            this.grpThongTin.Controls.Add(this.txtMaSV);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtNgaySinh);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.lblLop);
            this.grpThongTin.Controls.Add(this.cboLop);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnLamMoi);

            // lblTimKiem
            this.lblTimKiem.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimKiem.Location = new System.Drawing.Point(460, 12);
            this.lblTimKiem.AutoSize = true;

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(460, 35);
            this.txtTimKiem.Size = new System.Drawing.Size(320, 28);
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);

            // btnTim
            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(792, 30);
            this.btnTim.Size = new System.Drawing.Size(110, 38);
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // dgvSinhVien
            this.dgvSinhVien.Location = new System.Drawing.Point(460, 80);
            this.dgvSinhVien.Size = new System.Drawing.Size(900, 560);
            this.dgvSinhVien.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right
                | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.ColumnCount = 5;
            this.dgvSinhVien.Columns[0].Name = "Mã SV";
            this.dgvSinhVien.Columns[0].FillWeight = 15;
            this.dgvSinhVien.Columns[1].Name = "Họ và Tên";
            this.dgvSinhVien.Columns[1].FillWeight = 30;
            this.dgvSinhVien.Columns[2].Name = "Giới Tính";
            this.dgvSinhVien.Columns[2].FillWeight = 15;
            this.dgvSinhVien.Columns[3].Name = "Ngày Sinh";
            this.dgvSinhVien.Columns[3].FillWeight = 20;
            this.dgvSinhVien.Columns[4].Name = "Lớp";
            this.dgvSinhVien.Columns[4].FillWeight = 20;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            // pnlPaging
            this.pnlPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPaging.Height = 55;
            this.pnlPaging.BackColor = System.Drawing.Color.WhiteSmoke;

            // btnFirst
            this.btnFirst.Text = "<<";
            this.btnFirst.Location = new System.Drawing.Point(460, 8);
            this.btnFirst.Size = new System.Drawing.Size(55, 38);
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);

            // btnPrev
            this.btnPrev.Text = "<";
            this.btnPrev.Location = new System.Drawing.Point(518, 8);
            this.btnPrev.Size = new System.Drawing.Size(55, 38);
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);

            // lblTrang
            this.lblTrang.Text = "Trang 1/1  |  0 bản ghi";
            this.lblTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrang.Location = new System.Drawing.Point(640, 17);
            this.lblTrang.AutoSize = true;

            // btnNext
            this.btnNext.Text = ">";
            this.btnNext.Location = new System.Drawing.Point(900, 8);
            this.btnNext.Size = new System.Drawing.Size(55, 38);
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // btnLast
            this.btnLast.Text = ">>";
            this.btnLast.Location = new System.Drawing.Point(958, 8);
            this.btnLast.Size = new System.Drawing.Size(55, 38);
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);

            this.pnlPaging.Controls.Add(this.btnFirst);
            this.pnlPaging.Controls.Add(this.btnPrev);
            this.pnlPaging.Controls.Add(this.lblTrang);
            this.pnlPaging.Controls.Add(this.btnNext);
            this.pnlPaging.Controls.Add(this.btnLast);

            // QuanliSinhVien_Page
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Size = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.pnlPaging);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvSinhVien);

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.pnlPaging.ResumeLayout(false);
            this.pnlPaging.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Panel pnlPaging;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}
