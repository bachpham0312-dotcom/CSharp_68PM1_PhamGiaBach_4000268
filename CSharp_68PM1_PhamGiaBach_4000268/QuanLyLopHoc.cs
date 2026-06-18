using System;
using System.Linq;
using System.Windows.Forms;
using CSharp_68PM1_PhamGiaBach_4000268;

namespace Quanlisinhvien
{
    public partial class QuanliLopHoc_Page : UserControl
    {
        private DataClasses1DataContext db;
        private const int pageSize = 10;
        private int currentPage = 1;
        private int totalPages = 1;
        private System.Collections.Generic.List<lophoc> danhSach = new System.Collections.Generic.List<lophoc>();

        public event EventHandler<string> XemSinhVienRequest;

        public QuanliLopHoc_Page()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        // ─── Load danh sách lớp học ───────────────────────────────────────────
        private void LoadDanhSach(string keyword = "")
        {
            try
            {
                db = new DataClasses1DataContext();
                var query = db.lophocs.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    string kw = keyword.Trim().ToLower();
                    query = query.Where(l =>
                        l.id.ToString().Contains(kw) ||
                        (l.malop != null && l.malop.ToLower().Contains(kw)) ||
                        (l.tenlop != null && l.tenlop.ToLower().Contains(kw)));
                }

                danhSach = query.ToList();
                int total = danhSach.Count;
                totalPages = Math.Max(1, (int)Math.Ceiling(total / (double)pageSize));
                if (currentPage > totalPages) currentPage = totalPages;

                var page = danhSach
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                dgvLopHoc.Rows.Clear();
                foreach (var lop in page)
                    dgvLopHoc.Rows.Add(lop.id, lop.malop, lop.tenlop, lop.ghichu);

                lblTrang.Text = $"Trang {currentPage}/{totalPages}  |  {total} bản ghi";

                // Reset phần sinh viên
                dgvSinhVienCuaLop.Rows.Clear();
                lblSinhVienCuaLop.Text = "Danh sách sinh viên – chọn một lớp để xem";
            }
            catch (Exception ex)
            {
                lblTrang.Text = "Lỗi tải dữ liệu";
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Load sinh viên của lớp được chọn ────────────────────────────────
        private void LoadSinhVienCuaLop(int lopId, string tenLop)
        {
            try
            {
                db = new DataClasses1DataContext();
                var dsSv = db.sinhviens.Where(s => s.lophoc_id == lopId).ToList();

                dgvSinhVienCuaLop.Rows.Clear();
                int stt = 1;
                foreach (var sv in dsSv)
                    dgvSinhVienCuaLop.Rows.Add(stt++, sv.masv, sv.hoten, sv.gioitinh,
                        sv.ngaysinh?.ToString("dd/MM/yyyy"));

                lblSinhVienCuaLop.Text =
                    $"Danh sách sinh viên – Lớp: {tenLop}  ({dsSv.Count} sinh viên)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Làm mới form nhập ───────────────────────────────────────────────
        private void LamMoiForm()
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtMaLop.ReadOnly = false;
            txtMaLop.BackColor = System.Drawing.Color.White;
            txtTenLop.Clear();
            txtGhiChu.Clear();
        }

        // ─── Thêm ────────────────────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp và Tên lớp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db = new DataClasses1DataContext();
                if (db.lophocs.Any(l => l.malop == txtMaLop.Text.Trim()))
                {
                    MessageBox.Show("Mã lớp đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int newId = db.lophocs.Any() ? db.lophocs.Max(l => l.id) + 1 : 1;
                var lop = new lophoc
                {
                    id     = newId,
                    malop  = txtMaLop.Text.Trim(),
                    tenlop = txtTenLop.Text.Trim(),
                    ghichu = txtGhiChu.Text.Trim()
                };
                db.lophocs.InsertOnSubmit(lop);
                db.SubmitChanges();
                MessageBox.Show("Thêm lớp học thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach(txtTimKiem.Text);
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Sửa ─────────────────────────────────────────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaID.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtMaID.Text, out int id)) return;
            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên lớp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db = new DataClasses1DataContext();
                var lop = db.lophocs.FirstOrDefault(l => l.id == id);
                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy lớp học.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lop.tenlop = txtTenLop.Text.Trim();
                lop.ghichu = txtGhiChu.Text.Trim();
                db.SubmitChanges();
                MessageBox.Show("Sửa lớp học thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach(txtTimKiem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Xóa ─────────────────────────────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaID.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtMaID.Text, out int id)) return;
            if (MessageBox.Show(
                    $"Bạn có chắc muốn xóa lớp '{txtTenLop.Text}'?\nCác sinh viên thuộc lớp này sẽ bị mất liên kết.",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                db = new DataClasses1DataContext();
                var svList = db.sinhviens.Where(s => s.lophoc_id == id).ToList();
                foreach (var sv in svList) sv.lophoc_id = null;
                db.SubmitChanges();

                var lop = db.lophocs.FirstOrDefault(l => l.id == id);
                if (lop == null) return;
                db.lophocs.DeleteOnSubmit(lop);
                db.SubmitChanges();
                MessageBox.Show("Xóa lớp học thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach(txtTimKiem.Text);
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Làm mới ─────────────────────────────────────────────────────────
        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoiForm();

        // ─── Tìm kiếm ────────────────────────────────────────────────────────
        private void btnTim_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadDanhSach(txtTimKiem.Text);
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTim_Click(sender, e);
        }

        // ─── Click dòng lớp học → điền form + hiện sinh viên của lớp ─────────
        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvLopHoc.Rows[e.RowIndex];

            txtMaID.Text   = row.Cells[0].Value?.ToString();
            txtMaLop.Text  = row.Cells[1].Value?.ToString();
            txtMaLop.ReadOnly  = true;
            txtMaLop.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            txtTenLop.Text = row.Cells[2].Value?.ToString();
            txtGhiChu.Text = row.Cells[3].Value?.ToString();

            // Hiện sinh viên của lớp ngay bên dưới
            if (int.TryParse(txtMaID.Text, out int id))
                LoadSinhVienCuaLop(id, txtTenLop.Text);
        }

        // ─── Xem toàn trang sinh viên (chuyển sang tab SV với filter) ────────
        private void btnXemSinhVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            XemSinhVienRequest?.Invoke(this, txtMaLop.Text.Trim());
        }

        // ─── Phân trang ──────────────────────────────────────────────────────
        private void btnFirst_Click(object sender, EventArgs e)
        { currentPage = 1; LoadDanhSach(txtTimKiem.Text); }

        private void btnPrev_Click(object sender, EventArgs e)
        { if (currentPage > 1) { currentPage--; LoadDanhSach(txtTimKiem.Text); } }

        private void btnNext_Click(object sender, EventArgs e)
        { if (currentPage < totalPages) { currentPage++; LoadDanhSach(txtTimKiem.Text); } }

        private void btnLast_Click(object sender, EventArgs e)
        { currentPage = totalPages; LoadDanhSach(txtTimKiem.Text); }
    }
}
