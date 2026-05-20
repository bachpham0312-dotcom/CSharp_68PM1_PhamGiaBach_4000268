using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLySinhVien
{
    public partial class QuanLyLopHoc : Form
    {
        public QuanLyLopHoc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Add("1", "68PM1", "Lớp 68PM1", "abc");
            dataGridView1.Rows.Add("2", "68PM2", "Lớp 68PM2", "xyz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show("Thêm thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textBox4.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox5.Text;
                MessageBox.Show("Sửa thành công");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("Xóa thành công");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tuKhoa = textBox3.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    bool timThay = row.Cells[0].Value.ToString().ToLower().Contains(tuKhoa) ||
                                   row.Cells[1].Value.ToString().ToLower().Contains(tuKhoa) ||
                                   row.Cells[2].Value.ToString().ToLower().Contains(tuKhoa);
                    row.Visible = timThay;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danh sách sinh viên");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value?.ToString();
                textBox2.Text = row.Cells[1].Value?.ToString();
                textBox4.Text = row.Cells[2].Value?.ToString();
                textBox5.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void menuSinhVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}