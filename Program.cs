using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DangNhap frmDangNhap = new DangNhap();

            // Nếu đăng nhập thành công (DialogResult = OK) thì mới chạy Form1
            if (frmDangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            else
            {
                // Nếu không đăng nhập (nhấn thoát hoặc đóng form) thì thoát ứng dụng
                Application.Exit();
            }
        }

    }
}
