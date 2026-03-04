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
    public partial class DoiMatKhau : Form
    {
        string connectionString = @"Data Source=DESKTOP-ACVJ7GL;Initial Catalog=quanlybanhang;Integrated Security=True";

        public DoiMatKhau()
        {
            InitializeComponent();

            // Hiển thị tên Admin
            if (DangNhapAdmin.IsAdmin)
            {
                txtTaiKhoan.Text = DangNhapAdmin.AdminName;
            }
            else
            {
                // Nếu không phải Admin thì tự động đóng form
                MessageBox.Show("Bạn không có quyền truy cập!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            txtTaiKhoan.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhanMK = txtXacNhanMatKhau.Text;

            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != xacNhanMK)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra mật khẩu cũ của Admin
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND Role = 'Admin'";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", DangNhapAdmin.AdminName);
                        checkCmd.Parameters.AddWithValue("@Password", matKhauCu);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatKhauCu.Clear();
                            txtMatKhauCu.Focus();
                            return;
                        }
                    }

                    // Cập nhật mật khẩu mới cho Admin
                    string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username AND Role = 'Admin'";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@Username", DangNhapAdmin.AdminName);
                        updateCmd.Parameters.AddWithValue("@NewPassword", matKhauMoi);

                        int result = updateCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu Admin thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhauCu.PasswordChar = '\0';
                txtMatKhauMoi.PasswordChar = '\0';
                txtXacNhanMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.PasswordChar = '•';
                txtMatKhauMoi.PasswordChar = '•';
                txtXacNhanMatKhau.PasswordChar = '•';
            }
        }
    }
}