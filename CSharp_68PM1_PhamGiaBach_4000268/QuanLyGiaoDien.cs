using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quanlisinhvien
{
    public partial class QuanliHome_Page : Form
    {
        public QuanliHome_Page()
        {
            InitializeComponent();
        }

        private void QuanliHome_Page_Load(object sender, EventArgs e)
        {
            LoadSinhVienPage();
        }

        private void menuQlsignVien_Click(object sender, EventArgs e)
        {
            LoadSinhVienPage();
            menuQlsignVien.Font = new Font(menuQlsignVien.Font, FontStyle.Bold);
            menuQllopHoc.Font = new Font(menuQllopHoc.Font, FontStyle.Regular);
        }

        private void menuQllopHoc_Click(object sender, EventArgs e)
        {
            LoadLopHocPage();
            menuQllopHoc.Font = new Font(menuQllopHoc.Font, FontStyle.Bold);
            menuQlsignVien.Font = new Font(menuQlsignVien.Font, FontStyle.Regular);
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoadSinhVienPage()
        {
            var page = new QuanliSinhVien_Page();
            page.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
        }

        private void LoadLopHocPage()
        {
            var page = new QuanliLopHoc_Page();
            page.Dock = DockStyle.Fill;
            page.XemSinhVienRequest += (s, maLop) =>
            {
                LoadSinhVienPageFiltered(maLop);
                menuQlsignVien.Font = new Font(menuQlsignVien.Font, FontStyle.Bold);
                menuQllopHoc.Font = new Font(menuQllopHoc.Font, FontStyle.Regular);
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
        }

        private void LoadSinhVienPageFiltered(string maLop)
        {
            var page = new QuanliSinhVien_Page();
            page.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.SetFilter(maLop);
        }
    }
}
