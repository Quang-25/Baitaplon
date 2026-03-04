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
    public partial class DangNhap : Form
    {
        // Chuỗi kết nối database - SỬA THEO SERVER CỦA BẠN
        string connectionString = @"Data Source=LAPTOP-VN022S39\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True";

        // Biến lưu thông tin người dùng hiện tại
        public static string Username { get; set; } = "";
        public static string Role { get; set; } = "";
        public static string HoTen { get; set; } = "";
        public static string MaKH { get; set; } = "";
        public static string MaNV { get; set; } = "";

        public DangNhap()
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

                // Kiểm tra đăng nhập
                string query = @"SELECT Username, Role, HoTen, MaKH, MaNV, TrangThai 
                               FROM Users 
                               WHERE Username = @Username AND Password = @Password AND TrangThai = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lưu thông tin đăng nhập
                            Username = reader["Username"].ToString();
                            Role = reader["Role"].ToString();
                            HoTen = reader["HoTen"] != DBNull.Value ? reader["HoTen"].ToString() : username;
                            MaKH = reader["MaKH"] != DBNull.Value ? reader["MaKH"].ToString() : "";
                            MaNV = reader["MaNV"] != DBNull.Value ? reader["MaNV"].ToString() : "";

                            // Đóng reader trước khi thực hiện truy vấn khác
                            reader.Close();

                            // Ghi log đăng nhập
                            GhiLogDangNhap(username, Role, conn);

                            MessageBox.Show($"Đăng nhập thành công!\nChào mừng {HoTen} - {Role}",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            // Đóng reader trước khi kiểm tra tài khoản bị khóa
                            reader.Close();

                            // Kiểm tra tài khoản có tồn tại nhưng bị khóa
                            string checkQuery = "SELECT TrangThai FROM Users WHERE Username = @Username";
                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@Username", username);
                                object result = checkCmd.ExecuteScalar();
                                if (result != null && (bool)result == false)
                                {
                                    MessageBox.Show("Tài khoản đã bị khóa! Vui lòng liên hệ Admin.",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            txtMatKhau.Clear();
                            txtTenDangNhap.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database: " + ex.Message + "\n\nVui lòng kiểm tra server name!",
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

        private void GhiLogDangNhap(string username, string role, SqlConnection conn)
        {
            try
            {
                string query = @"INSERT INTO LogDangNhap (Username, Role, ThoiGian, IPAddress) 
                               VALUES (@Username, @Role, GETDATE(), @IP)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@IP", "Local");
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                // Bỏ qua lỗi ghi log
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '•';
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên để được cấp tài khoản!\nHotline: 1900.1234",
                "Đăng ký tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên để lấy lại mật khẩu!\nEmail: admin@quanlybanhang.com",
                "Quên mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Phương thức đăng xuất
        public static void Logout()
        {
            Username = "";
            Role = "";
            HoTen = "";
            MaKH = "";
            MaNV = "";
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}