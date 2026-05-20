namespace QuanLySinhVien
{
    partial class QuanLyLopHoc
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

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPhanTrang = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlPhanTrang.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSinhVien,
            this.menuLopHoc,
            this.menuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1450, 30);

            this.menuSinhVien.Text = "Quản Lý Sinh Viên";
            this.menuSinhVien.Click += new System.EventHandler(this.menuSinhVien_Click);

            this.menuLopHoc.Text = "Quản Lý Lớp Học";
            this.menuLopHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.ForeColor = System.Drawing.Color.Red;
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);

            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Size = new System.Drawing.Size(420, 360);
            this.groupBox1.Text = "Thông tin lớp học";

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Text = "Mã ID:";

            this.textBox1.Location = new System.Drawing.Point(20, 55);
            this.textBox1.Size = new System.Drawing.Size(380, 26);
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.textBox1.ReadOnly = true;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Text = "Mã lớp:";

            this.textBox2.Location = new System.Drawing.Point(20, 125);
            this.textBox2.Size = new System.Drawing.Size(380, 26);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 170);
            this.label3.Text = "Tên lớp:";

            this.textBox4.Location = new System.Drawing.Point(20, 195);
            this.textBox4.Size = new System.Drawing.Size(380, 26);

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 240);
            this.label4.Text = "Ghi chú:";

            this.textBox5.Location = new System.Drawing.Point(20, 265);
            this.textBox5.Size = new System.Drawing.Size(380, 26);

            this.button1.Location = new System.Drawing.Point(20, 430);
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.Text = "Thêm";
            this.button1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.button2.Location = new System.Drawing.Point(240, 430);
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.Text = "Sửa";
            this.button2.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            this.button3.Location = new System.Drawing.Point(20, 500);
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.Text = "Xóa";
            this.button3.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Click += new System.EventHandler(this.button3_Click);

            this.button4.Location = new System.Drawing.Point(240, 500);
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.Text = "Làm mới";
            this.button4.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            this.button10.Location = new System.Drawing.Point(20, 570);
            this.button10.Size = new System.Drawing.Size(420, 50);
            this.button10.Text = "Xem danh sách sinh viên";
            this.button10.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Click += new System.EventHandler(this.button10_Click);

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 30);
            this.label5.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";

            this.textBox3.Location = new System.Drawing.Point(470, 60);
            this.textBox3.Size = new System.Drawing.Size(350, 26);

            this.button5.Location = new System.Drawing.Point(840, 55);
            this.button5.Size = new System.Drawing.Size(120, 35);
            this.button5.Text = "Tìm";
            this.button5.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Click += new System.EventHandler(this.button5_Click);

            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(470, 110);
            this.dataGridView1.Size = new System.Drawing.Size(950, 540);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            this.Column1.HeaderText = "Mã ID";
            this.Column2.HeaderText = "Mã lớp";
            this.Column3.HeaderText = "Tên lớp";
            this.Column4.HeaderText = "Ghi chú";

            this.pnlPhanTrang.Controls.Add(this.btnFirst);
            this.pnlPhanTrang.Controls.Add(this.btnPrev);
            this.pnlPhanTrang.Controls.Add(this.lblPageInfo);
            this.pnlPhanTrang.Controls.Add(this.btnNext);
            this.pnlPhanTrang.Controls.Add(this.btnLast);
            this.pnlPhanTrang.Location = new System.Drawing.Point(470, 660);
            this.pnlPhanTrang.Size = new System.Drawing.Size(950, 50);

            this.btnFirst.Location = new System.Drawing.Point(0, 5);
            this.btnFirst.Size = new System.Drawing.Size(60, 40);
            this.btnFirst.Text = "<<";

            this.btnPrev.Location = new System.Drawing.Point(65, 5);
            this.btnPrev.Size = new System.Drawing.Size(60, 40);
            this.btnPrev.Text = "<";

            this.lblPageInfo.Location = new System.Drawing.Point(130, 5);
            this.lblPageInfo.Size = new System.Drawing.Size(690, 40);
            this.lblPageInfo.Text = "Trang 1/1 | 2 bản ghi";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnNext.Location = new System.Drawing.Point(825, 5);
            this.btnNext.Size = new System.Drawing.Size(60, 40);
            this.btnNext.Text = ">";

            this.btnLast.Location = new System.Drawing.Point(890, 5);
            this.btnLast.Size = new System.Drawing.Size(60, 40);
            this.btnLast.Text = ">>";

            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlPhanTrang);
            this.Name = "QuanLyLopHoc";
            this.Text = "Quản Lý Lớp Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlPhanTrang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel pnlPhanTrang;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}