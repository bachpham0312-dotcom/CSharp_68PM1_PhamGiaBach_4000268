using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp_68PM1_PhamGiaBach_4000268
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();

            TaoGiaoDienSinhVien();
        }

        private void TaoGiaoDienSinhVien()
        {
            Label lblMaSV = new Label();
            lblMaSV.Text = "Mã sinh viên";
            lblMaSV.Location = new Point(30, 60);

            TextBox txtMaSV = new TextBox();
            txtMaSV.Location = new Point(30, 90);
            txtMaSV.Width = 250;

            Label lblHoTen = new Label();
            lblHoTen.Text = "Họ và tên";
            lblHoTen.Location = new Point(30, 140);

            TextBox txtHoTen = new TextBox();
            txtHoTen.Location = new Point(30, 170);
            txtHoTen.Width = 250;

            Label lblNgaySinh = new Label();
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.Location = new Point(30, 220);

            DateTimePicker dtNgaySinh = new DateTimePicker();
            dtNgaySinh.Location = new Point(30, 250);
            dtNgaySinh.Width = 250;

            Label lblGioiTinh = new Label();
            lblGioiTinh.Text = "Giới tính";
            lblGioiTinh.Location = new Point(30, 300);

            ComboBox cboGioiTinh = new ComboBox();
            cboGioiTinh.Location = new Point(30, 330);
            cboGioiTinh.Width = 250;

            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            Label lblLop = new Label();
            lblLop.Text = "Lớp";
            lblLop.Location = new Point(30, 380);

            ComboBox cboLop = new ComboBox();
            cboLop.Location = new Point(30, 410);
            cboLop.Width = 250;

            cboLop.Items.Add("68PM1");
            cboLop.Items.Add("68PM2");

            Button btnThem = new Button();
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(30, 500);

            Button btnSua = new Button();
            btnSua.Text = "Sửa";
            btnSua.Location = new Point(120, 500);

            Button btnXoa = new Button();
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(210, 500);

            DataGridView dgv = new DataGridView();

            dgv.Location = new Point(350, 60);
            dgv.Size = new Size(700, 400);

            dgv.ColumnCount = 5;

            dgv.Columns[0].Name = "Mã SV";
            dgv.Columns[1].Name = "Họ tên";
            dgv.Columns[2].Name = "Ngày sinh";
            dgv.Columns[3].Name = "Giới tính";
            dgv.Columns[4].Name = "Lớp";

            dgv.Rows.Add("1", "Nguyễn Văn A", "11/03/2026", "Nam", "68PM1");

            btnThem.Click += (s, e) =>
            {
                dgv.Rows.Add(
                    txtMaSV.Text,
                    txtHoTen.Text,
                    dtNgaySinh.Text,
                    cboGioiTinh.Text,
                    cboLop.Text
                );
            };

            btnXoa.Click += (s, e) =>
            {
                if (dgv.CurrentRow != null)
                {
                    dgv.Rows.Remove(dgv.CurrentRow);
                }
            };

            this.Controls.Add(lblMaSV);
            this.Controls.Add(txtMaSV);

            this.Controls.Add(lblHoTen);
            this.Controls.Add(txtHoTen);

            this.Controls.Add(lblNgaySinh);
            this.Controls.Add(dtNgaySinh);

            this.Controls.Add(lblGioiTinh);
            this.Controls.Add(cboGioiTinh);

            this.Controls.Add(lblLop);
            this.Controls.Add(cboLop);

            this.Controls.Add(btnThem);
            this.Controls.Add(btnSua);
            this.Controls.Add(btnXoa);

            this.Controls.Add(dgv);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}