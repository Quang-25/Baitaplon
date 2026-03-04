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

            // Kiểm tra đã đăng nhập chưa
            if (string.IsNullOrEmpty(DangNhap.Username))
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            // Hiển thị tên đăng nhập hiện tại
            txtTenDangNhap.Text = DangNhap.Username;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhauCu))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauCu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            if (matKhauCu == matKhauMoi)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra mật khẩu cũ
                    string checkQuery = @"SELECT COUNT(*) FROM Users 
                                         WHERE Username = @Username 
                                         AND Password = @Password";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", tenDangNhap);
                        checkCmd.Parameters.AddWithValue("@Password", matKhauCu);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatKhauCu.Clear();
                            txtMatKhauCu.Focus();
                            return;
                        }
                    }

                    // Cập nhật mật khẩu mới
                    string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@Username", tenDangNhap);
                        updateCmd.Parameters.AddWithValue("@NewPassword", matKhauMoi);

                        int result = updateCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
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
            }
            else
            {
                txtMatKhauCu.PasswordChar = '•';
                txtMatKhauMoi.PasswordChar = '•';
            }
        }
    }
}