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
                        (l.id.ToString().Contains(kw)) ||
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
            }
            catch (Exception ex)
            {
                lblTrang.Text = "Lỗi tải dữ liệu";
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
