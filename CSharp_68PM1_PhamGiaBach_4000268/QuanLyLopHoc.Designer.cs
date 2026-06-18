namespace Quanlisinhvien
{
    partial class QuanliLopHoc_Page
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
            this.lblMaID = new System.Windows.Forms.Label();
            this.txtMaID = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXemSinhVien = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.pnlPaging = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblTrang = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();

            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.pnlPaging.SuspendLayout();
            this.SuspendLayout();

            // grpThongTin
            this.grpThongTin.Text = "Thông tin lớp học";
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(10, 10);
            this.grpThongTin.Size = new System.Drawing.Size(435, 640);
            this.grpThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Bottom;
            this.grpThongTin.BackColor = System.Drawing.Color.WhiteSmoke;

            // lblMaID
            this.lblMaID.Text = "Mã ID:";
            this.lblMaID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaID.Location = new System.Drawing.Point(18, 30);
            this.lblMaID.AutoSize = true;

            // txtMaID
            this.txtMaID.Location = new System.Drawing.Point(18, 52);
            this.txtMaID.Size = new System.Drawing.Size(395, 28);
            this.txtMaID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaID.ReadOnly = true;
            this.txtMaID.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.txtMaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblMaLop
            this.lblMaLop.Text = "Mã lớp:";
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaLop.Location = new System.Drawing.Point(18, 100);
            this.lblMaLop.AutoSize = true;

            // txtMaLop
            this.txtMaLop.Location = new System.Drawing.Point(18, 122);
            this.txtMaLop.Size = new System.Drawing.Size(395, 28);
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblTenLop
            this.lblTenLop.Text = "Tên lớp:";
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenLop.Location = new System.Drawing.Point(18, 170);
            this.lblTenLop.AutoSize = true;

            // txtTenLop
            this.txtTenLop.Location = new System.Drawing.Point(18, 192);
            this.txtTenLop.Size = new System.Drawing.Size(395, 28);
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblGhiChu
            this.lblGhiChu.Text = "Ghi chú:";
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.Location = new System.Drawing.Point(18, 240);
            this.lblGhiChu.AutoSize = true;

            // txtGhiChu
            this.txtGhiChu.Location = new System.Drawing.Point(18, 262);
            this.txtGhiChu.Size = new System.Drawing.Size(395, 28);
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnThem
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(18, 400);
            this.btnThem.Size = new System.Drawing.Size(190, 50);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(222, 400);
            this.btnSua.Size = new System.Drawing.Size(190, 50);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(18, 465);
            this.btnXoa.Size = new System.Drawing.Size(190, 50);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(222, 465);
            this.btnLamMoi.Size = new System.Drawing.Size(190, 50);
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // btnXemSinhVien
            this.btnXemSinhVien.Text = "Xem danh sách sinh viên";
            this.btnXemSinhVien.Location = new System.Drawing.Point(18, 530);
            this.btnXemSinhVien.Size = new System.Drawing.Size(395, 50);
            this.btnXemSinhVien.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnXemSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnXemSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemSinhVien.FlatAppearance.BorderSize = 0;
            this.btnXemSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemSinhVien.Click += new System.EventHandler(this.btnXemSinhVien_Click);

            this.grpThongTin.Controls.Add(this.lblMaID);
            this.grpThongTin.Controls.Add(this.txtMaID);
            this.grpThongTin.Controls.Add(this.lblMaLop);
            this.grpThongTin.Controls.Add(this.txtMaLop);
            this.grpThongTin.Controls.Add(this.lblTenLop);
            this.grpThongTin.Controls.Add(this.txtTenLop);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXemSinhVien);

            // lblTimKiem
            this.lblTimKiem.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimKiem.Location = new System.Drawing.Point(460, 12);
            this.lblTimKiem.AutoSize = true;

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(460, 35);
            this.txtTimKiem.Size = new System.Drawing.Size(320, 28);
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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

            // dgvLopHoc
            this.dgvLopHoc.Location = new System.Drawing.Point(460, 80);
            this.dgvLopHoc.Size = new System.Drawing.Size(900, 560);
            this.dgvLopHoc.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right
                | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvLopHoc.AllowUserToAddRows = false;
            this.dgvLopHoc.ReadOnly = true;
            this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHoc.MultiSelect = false;
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvLopHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.ColumnCount = 4;
            this.dgvLopHoc.Columns[0].Name = "Mã ID";
            this.dgvLopHoc.Columns[0].FillWeight = 15;
            this.dgvLopHoc.Columns[1].Name = "Mã lớp";
            this.dgvLopHoc.Columns[1].FillWeight = 20;
            this.dgvLopHoc.Columns[2].Name = "Tên lớp";
            this.dgvLopHoc.Columns[2].FillWeight = 40;
            this.dgvLopHoc.Columns[3].Name = "Ghi chú";
            this.dgvLopHoc.Columns[3].FillWeight = 25;
            this.dgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellClick);

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

            // QuanliLopHoc_Page
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Size = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.pnlPaging);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvLopHoc);

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.pnlPaging.ResumeLayout(false);
            this.pnlPaging.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaID;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXemSinhVien;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Panel pnlPaging;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}
