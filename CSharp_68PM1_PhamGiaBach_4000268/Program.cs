using System;
using System.Windows.Forms;

namespace CSharp_68PM1_PhamGiaBach_4000268
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanLySinhVien());
        }
    }
}