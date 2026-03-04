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
    public partial class QuanLyNguoiDung : Form
    {
        string connectionString = @"Data Source=DESKTOP-ACVJ7GL;Initial Catalog=quanlybanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        bool isEditing = false;

        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData("");
            LoadComboBox();
            SetControlsEnabled(false);
        }

        private void LoadData(string keyword)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                string query = @"SELECT Username, 
                                        Password,
                                        Role, 
                                        ISNULL(MaKH, '') as MaKH, 
                                        ISNULL(MaNV, '') as MaNV, 
                                        HoTen, 
                                        Email, 
                                        DienThoai, 
                                        TrangThai,
                                        NgayTao
                                 FROM Users 
                                 WHERE Username LIKE @keyword 
                                    OR HoTen LIKE @keyword 
                                    OR Email LIKE @keyword 
                                    OR DienThoai LIKE @keyword
                                 ORDER BY NgayTao DESC";

                da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;

                // Ẩn cột mật khẩu
                if (dgvUsers.Columns["Password"] != null)
                    dgvUsers.Columns["Password"].Visible = false;

                dgvUsers.AutoResizeColumns();
                lblTotal.Text = $"Tổng số: {dt.Rows.Count} người dùng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBox()
        {
            try
            {
                // Load Role
                cmbRole.Items.Clear();
                cmbRole.Items.Add("Admin");
                cmbRole.Items.Add("NhanVien");
                cmbRole.Items.Add("KhachHang");

                // Load danh sách khách hàng
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Load Khách hàng
                    string queryKH = "SELECT Makh, Tencty FROM khachhang ORDER BY Tencty";
                    SqlDataAdapter daKH = new SqlDataAdapter(queryKH, conn);
                    DataTable dtKH = new DataTable();
                    daKH.Fill(dtKH);

                    DataRow rowKH = dtKH.NewRow();
                    rowKH["Makh"] = "";
                    rowKH["Tencty"] = "-- Chọn khách hàng --";
                    dtKH.Rows.InsertAt(rowKH, 0);

                    cmbMaKH.DataSource = null;
                    cmbMaKH.DisplayMember = "Tencty";
                    cmbMaKH.ValueMember = "Makh";
                    cmbMaKH.DataSource = dtKH;

                    // Load Nhân viên
                    string queryNV = "SELECT Manv, Ho + ' ' + Ten as HoTen FROM nhanvien ORDER BY HoTen";
                    SqlDataAdapter daNV = new SqlDataAdapter(queryNV, conn);
                    DataTable dtNV = new DataTable();
                    daNV.Fill(dtNV);

                    DataRow rowNV = dtNV.NewRow();
                    rowNV["Manv"] = "";
                    rowNV["HoTen"] = "-- Chọn nhân viên --";
                    dtNV.Rows.InsertAt(rowNV, 0);

                    cmbMaNV.DataSource = null;
                    cmbMaNV.DisplayMember = "HoTen";
                    cmbMaNV.ValueMember = "Manv";
                    cmbMaNV.DataSource = dtNV;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetControlsEnabled(bool enabled)
        {
            txtUsername.Enabled = false; // Không cho sửa username
            txtPassword.Enabled = enabled;
            cmbRole.Enabled = enabled;
            cmbMaKH.Enabled = enabled && cmbRole.Text == "KhachHang";
            cmbMaNV.Enabled = enabled && cmbRole.Text == "NhanVien";
            txtHoTen.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtDienThoai.Enabled = enabled;
            chkTrangThai.Enabled = enabled;

            btnSua.Enabled = !enabled;
            btnXoa.Enabled = !enabled;
            btnLuu.Enabled = enabled;
            btnHuy.Enabled = enabled;
        }

        private void ClearInputs()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            chkTrangThai.Checked = true;
            cmbRole.SelectedIndex = -1;
            cmbMaKH.SelectedIndex = 0;
            cmbMaNV.SelectedIndex = 0;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem != null)
            {
                string role = cmbRole.SelectedItem.ToString();
                cmbMaKH.Enabled = (role == "KhachHang");
                cmbMaNV.Enabled = (role == "NhanVien");

                if (role != "KhachHang") cmbMaKH.SelectedIndex = 0;
                if (role != "NhanVien") cmbMaNV.SelectedIndex = 0;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                btnTimKiem.PerformClick();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isEditing = true;
            SetControlsEnabled(true);

            // Lấy dữ liệu từ dòng được chọn
            DataGridViewRow row = dgvUsers.CurrentRow;
            txtUsername.Text = row.Cells["Username"].Value.ToString();
            txtPassword.Text = row.Cells["Password"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
            chkTrangThai.Checked = row.Cells["TrangThai"].Value != DBNull.Value && (bool)row.Cells["TrangThai"].Value;

            string role = row.Cells["Role"].Value.ToString();
            cmbRole.Text = role;

            if (role == "KhachHang")
            {
                cmbMaKH.SelectedValue = row.Cells["MaKH"].Value;
            }
            else if (role == "NhanVien")
            {
                cmbMaNV.SelectedValue = row.Cells["MaNV"].Value;
            }

            txtPassword.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isEditing) return;

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Cập nhật thông tin người dùng
                    string updateQuery = @"UPDATE Users SET 
                                            Password = @Password,
                                            Role = @Role,
                                            MaKH = @MaKH,
                                            MaNV = @MaNV,
                                            HoTen = @HoTen,
                                            Email = @Email,
                                            DienThoai = @DienThoai,
                                            TrangThai = @TrangThai
                                          WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@MaKH", cmbRole.SelectedItem.ToString() == "KhachHang" ? cmbMaKH.SelectedValue : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaNV", cmbRole.SelectedItem.ToString() == "NhanVien" ? cmbMaNV.SelectedValue : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(txtEmail.Text) ? DBNull.Value : (object)txtEmail.Text);
                        cmd.Parameters.AddWithValue("@DienThoai", string.IsNullOrEmpty(txtDienThoai.Text) ? DBNull.Value : (object)txtDienThoai.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", chkTrangThai.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadData(txtTimKiem.Text.Trim());
                    SetControlsEnabled(false);
                    isEditing = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            // Không cho xóa tài khoản admin
            if (username == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản Admin mặc định!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xóa người dùng '{username}'?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM Users WHERE Username = @Username";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa người dùng thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(txtTimKiem.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControlsEnabled(false);
            isEditing = false;
            ClearInputs();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !isEditing)
            {
                // Chỉ hiển thị thông tin khi không ở chế độ sửa
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
            }
        }
    }
}