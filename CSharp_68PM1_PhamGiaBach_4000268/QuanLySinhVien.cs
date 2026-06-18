using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CSharp_68PM1_PhamGiaBach_4000268;

namespace Quanlisinhvien
{
    public partial class QuanliSinhVien_Page : UserControl
    {
        private DataClasses1DataContext db;
        private const int pageSize = 10;
        private int currentPage = 1;
        private int totalPages = 1;
        private System.Collections.Generic.List<sinhvien> danhSach = new System.Collections.Generic.List<sinhvien>();

        public QuanliSinhVien_Page()
        {
            InitializeComponent();
            LoadLopHoc();
            LoadDanhSach();
        }

        public void SetFilter(string maLop)
        {
            txtTimKiem.Text = maLop;
            currentPage = 1;
            LoadDanhSach(maLop);
        }

        private void LoadLopHoc()
        {
            try
            {
                db = new DataClasses1DataContext();
                var lops = db.lophocs
                    .Select(l => new { id = l.id, display = l.malop + " – " + l.tenlop })
                    .ToList();
                cboLop.DataSource = lops;
                cboLop.DisplayMember = "display";
                cboLop.ValueMember = "id";
                cboLop.SelectedIndex = -1;
            }
            catch { }
        }

        private void LoadDanhSach(string keyword = "")
        {
            try
            {
                db = new DataClasses1DataContext();
                var query = db.sinhviens.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    string kw = keyword.Trim().ToLower();
                    query = query.Where(s =>
                        (s.hoten != null && s.hoten.ToLower().Contains(kw)) ||
                        (s.masv != null && s.masv.ToLower().Contains(kw)) ||
                        (s.lophoc != null && s.lophoc.malop.ToLower().Contains(kw)));
                }

                danhSach = query.ToList();
                int total = danhSach.Count;
                totalPages = Math.Max(1, (int)Math.Ceiling(total / (double)pageSize));
                if (currentPage > totalPages) currentPage = totalPages;

                var page = danhSach
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                dgvSinhVien.Rows.Clear();
                foreach (var sv in page)
                {
                    string tenLop = sv.lophoc?.malop ?? "";
                    dgvSinhVien.Rows.Add(
                        sv.masv,
                        sv.hoten,
                        sv.gioitinh,
                        sv.ngaysinh?.ToString("dd/MM/yyyy"),
                        tenLop);
                }

                lblTrang.Text = $"Trang {currentPage}/{totalPages}  |  {total} bản ghi";
            }
            catch (Exception ex)
            {
                lblTrang.Text = "Lỗi tải dữ liệu";
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamMoiForm()
        {
            txtMaSV.Clear();
            txtMaSV.ReadOnly = false;
            txtMaSV.BackColor = System.Drawing.Color.White;
            txtHoTen.Clear();
            dtNgaySinh.Value = DateTime.Now;
            if (cboGioiTinh.Items.Count > 0) cboGioiTinh.SelectedIndex = 0;
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvSinhVien.Rows[e.RowIndex];
            txtMaSV.Text = row.Cells[0].Value?.ToString();
            txtMaSV.ReadOnly = true;
            txtMaSV.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            txtHoTen.Text = row.Cells[1].Value?.ToString();
            cboGioiTinh.Text = row.Cells[2].Value?.ToString();
            string nsStr = row.Cells[3].Value?.ToString();
            if (DateTime.TryParseExact(nsStr, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
                dtNgaySinh.Value = dt;
            // Chọn lớp tương ứng
            string maLop = row.Cells[4].Value?.ToString();
            try
            {
                db = new DataClasses1DataContext();
                var lop = db.lophocs.FirstOrDefault(l => l.malop == maLop);
                if (lop != null) cboLop.SelectedValue = lop.id;
            }
            catch { }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db = new DataClasses1DataContext();
                if (db.sinhviens.Any(s => s.masv == txtMaSV.Text.Trim()))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var sv = new sinhvien
                {
                    masv = txtMaSV.Text.Trim(),
                    hoten = txtHoTen.Text.Trim(),
                    gioitinh = cboGioiTinh.Text,
                    ngaysinh = dtNgaySinh.Value.Date,
                    lophoc_id = cboLop.SelectedValue != null
                        ? (int?)Convert.ToInt32(cboLop.SelectedValue)
                        : null
                };
                db.sinhviens.InsertOnSubmit(sv);
                db.SubmitChanges();
                MessageBox.Show("Thêm sinh viên thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach(txtTimKiem.Text);
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db = new DataClasses1DataContext();
                var sv = db.sinhviens.FirstOrDefault(s => s.masv == txtMaSV.Text.Trim());
                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sv.hoten = txtHoTen.Text.Trim();
                sv.gioitinh = cboGioiTinh.Text;
                sv.ngaysinh = dtNgaySinh.Value.Date;
                sv.lophoc_id = cboLop.SelectedValue != null
                    ? (int?)Convert.ToInt32(cboLop.SelectedValue)
                    : null;
                db.SubmitChanges();
                MessageBox.Show("Sửa sinh viên thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach(txtTimKiem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
