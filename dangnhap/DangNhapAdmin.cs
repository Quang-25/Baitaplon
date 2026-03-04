using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang
{
    public partial class DangNhapAdmin : Form
    {
        // Chuỗi kết nối database
        string connectionString = @"Data Source=LAPTOP-VN022S39\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True";

        // Biến kiểm tra quyền admin
        public static bool IsAdmin { get; private set; } = false;
        public static string AdminName { get; private set; } = "";

        public DangNhapAdmin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                // Kiểm tra đăng nhập với role = 'Admin'
                string query = @"SELECT Username, Role, HoTen 
                               FROM Users 
                               WHERE Username = @Username AND Password = @Password 
                               AND Role = 'Admin' AND TrangThai = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lưu thông tin admin
                            IsAdmin = true;
                            AdminName = reader["HoTen"].ToString();

                            MessageBox.Show($"Đăng nhập Admin thành công!\nChào mừng {AdminName}",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!\nHoặc tài khoản không có quyền Admin!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatKhau.Clear();
                            txtTenDangNhap.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '•';
        }

        // Phương thức đăng xuất
        public static void Logout()
        {
            IsAdmin = false;
            AdminName = "";
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}