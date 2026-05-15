using System;
using System.Windows.Forms;

namespace QLSV
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
            LoadDuLieuMau();
        }

        private void LoadDuLieuMau()
        {
            dgvSinhVien.Rows.Add("1", "Hieu", "Nam", "11/03/2026", "68PM1");
            dgvSinhVien.Rows.Add("2", "Nguyễn Văn B", "Nam", "11/03/2026", "68PM2");
            dgvSinhVien.Rows.Add("3", "Trần Văn C", "Nam", "21/03/2026", "68PM2");
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvSinhVien.Rows.Add(txtMaSV.Text, txtHoTen.Text, cboGioiTinh.Text, dtNgaySinh.Text, cboLop.Text);
            MessageBox.Show("Thêm sinh viên thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                dgvSinhVien.Rows.Remove(dgvSinhVien.CurrentRow);
                MessageBox.Show("Xóa sinh viên thành công");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;
            dtNgaySinh.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                dgvSinhVien.CurrentRow.Cells[0].Value = txtMaSV.Text;
                dgvSinhVien.CurrentRow.Cells[1].Value = txtHoTen.Text;
                dgvSinhVien.CurrentRow.Cells[2].Value = cboGioiTinh.Text;
                dgvSinhVien.CurrentRow.Cells[3].Value = dtNgaySinh.Text;
                dgvSinhVien.CurrentRow.Cells[4].Value = cboLop.Text;
                MessageBox.Show("Sửa sinh viên thành công");
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value?.ToString();
                txtHoTen.Text = row.Cells[1].Value?.ToString();
                cboGioiTinh.Text = row.Cells[2].Value?.ToString();
                dtNgaySinh.Text = row.Cells[3].Value?.ToString();
                cboLop.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.ToLower();
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    string hoten = row.Cells[1].Value.ToString().ToLower();
                    if (hoten.Contains(tukhoa))
                    {
                        row.Selected = true;
                        dgvSinhVien.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }
            MessageBox.Show("Không tìm thấy sinh viên");
        }

  

        private void menuLopHoc_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bạn vừa nhấn vào Quản lý Lớp Học");
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}