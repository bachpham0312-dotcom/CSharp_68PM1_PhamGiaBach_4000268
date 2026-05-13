using System;
using System.Windows.Forms;

namespace CSharp_68PM1_PhamGiaBach_4000268
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string studentEmail = "4000268@st.huce.edu.vn";
            string studentMSSV = "4000268";

            if (email == studentEmail && password == studentMSSV)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}