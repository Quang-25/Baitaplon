using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlybanhang.giupdo;
using Quanlybanhang.Danhmucdon;
using Quanlybanhang.Xemdanhmuc;

using Quanlybanhang.Danhmuctheonhom;


namespace Quanlybanhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void danhMụcThànhPhốToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Danhmucthanhpho pho = new Danhmucthanhpho();
            this.Hide();
            pho.ShowDialog();
            this.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Danhmuckhachhang pho = new Danhmuckhachhang();
            this.Hide();
            pho.ShowDialog();
            this.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void danhMụcSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Danhmucsanpham pho = new Danhmucsanpham();
            this.Hide();
            pho.ShowDialog();
            this.Show();
        }

        private void danhMụcHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Danhmuchoadon danhmuchoadon = new Danhmuchoadon();
            this.Hide();
            danhmuchoadon.ShowDialog();
            this.Show();
        }

        private void danhMụcChiTiếtHóaĐơn_Click(object sender, EventArgs e)
        {
            Danhmucchitiethoadon danhmucchitiethoadon = new Danhmucchitiethoadon();
            this.Hide();
            danhmucchitiethoadon.ShowDialog();
            this.Show();

        }

        private void danhMụcNhânViênToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Danhmucnhanvien nhanvien = new Danhmucnhanvien();
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
        }


        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhPho thanhpho = new ThanhPho();
            this.Hide();
            thanhpho.intDM = 1;
            thanhpho.ShowDialog();
            this.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo Form ThanhPho từ namespace Xemdanhmuc
            ThanhPho frmKhachHang = new ThanhPho();

            // 2. Truyền giá trị 2 để switch case nhảy vào "Danh mục Khách hàng"
            frmKhachHang.intDM = 2;

            // 3. Hiển thị Form
            this.Hide();
            frmKhachHang.ShowDialog();
            this.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhPho frm = new ThanhPho();
            frm.intDM = 3; // Giá trị 3 dành cho Nhân viên
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhPho frm = new ThanhPho();
            frm.intDM = 4; // Giá trị 4 dành cho Sản phẩm
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhPho frm = new ThanhPho();
            frm.intDM = 5; // Giá trị 5 dành cho Hóa đơn
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void danhMụcChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhPho frm = new ThanhPho();
            frm.intDM = 6; // Giá trị 5 dành cho Hóa đơn
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huongdan frm = new huongdan();
            frm.ShowDialog();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tacgia frm = new Tacgia();
            frm.ShowDialog();
        }

        private void kháchHàngTheoThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachtheoTP f = new frmKhachtheoTP();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoKH f = new frmHoaDonTheoKH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoSP f = new frmHoaDonTheoSP();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoNV f = new frmHoaDonTheoNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chiTiếtHóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietTheoNV f = new frmChiTietTheoNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void dangNhapAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DangNhapAdmin frm = new DangNhapAdmin())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cauHinhHeThongToolStripMenuItem.Visible = true;
                    dangNhapAdminToolStripMenuItem.Text = $"Admin: {DangNhapAdmin.AdminName}";
                    dangNhapAdminToolStripMenuItem.Enabled = false;

                    MessageBox.Show("Đăng nhập Admin thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cauHinhHeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DangNhapAdmin.IsAdmin)
            {
                MessageBox.Show("Bạn cần đăng nhập Admin để sử dụng chức năng này!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form cấu hình hệ thống (đã xóa phần đổi mật khẩu)
            // Mở form cấu hình hệ thống
            CauHinhHeThong frm = new CauHinhHeThong();
            frm.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã đăng nhập chưa
            if (string.IsNullOrEmpty(DangNhap.Username))
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi đổi mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form đổi mật khẩu (cho phép tất cả các vai trò)
            DoiMatKhau frm = new DoiMatKhau();

            // Nếu đăng xuất được yêu cầu (khi đổi mật khẩu thành công và chọn đăng nhập lại)
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Ẩn menu Cấu hình hệ thống
                cauHinhHeThongToolStripMenuItem.Visible = false;

                // Reset menu Đăng nhập Admin
                dangNhapAdminToolStripMenuItem.Text = "Đăng nhập Admin";
                dangNhapAdminToolStripMenuItem.Enabled = true;

                // Quay về màn hình đăng nhập
                this.Hide();
                DangNhap frmDangNhap = new DangNhap();

                if (frmDangNhap.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật lại trạng thái menu nếu đăng nhập Admin
                    if (DangNhapAdmin.IsAdmin)
                    {
                        cauHinhHeThongToolStripMenuItem.Visible = true;
                        dangNhapAdminToolStripMenuItem.Text = $"Admin: {DangNhapAdmin.AdminName}";
                        dangNhapAdminToolStripMenuItem.Enabled = false;
                    }
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận đăng xuất
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn đăng xuất?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                // Đăng xuất Admin nếu đang đăng nhập
                if (DangNhapAdmin.IsAdmin)
                {
                    DangNhapAdmin.Logout();
                }

                // Đăng xuất người dùng thường
                DangNhap.Logout();

                // Ẩn menu Cấu hình hệ thống
                cauHinhHeThongToolStripMenuItem.Visible = false;

                // Reset menu Đăng nhập Admin
                dangNhapAdminToolStripMenuItem.Text = "Đăng nhập Admin";
                dangNhapAdminToolStripMenuItem.Enabled = true;

                // Quay về màn hình đăng nhập
                this.Hide();
                DangNhap frmDangNhap = new DangNhap();

                // Nếu đăng nhập lại thành công thì hiển thị Form1, nếu không thì thoát
                if (frmDangNhap.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật lại trạng thái menu nếu đăng nhập Admin
                    if (DangNhapAdmin.IsAdmin)
                    {
                        cauHinhHeThongToolStripMenuItem.Visible = true;
                        dangNhapAdminToolStripMenuItem.Text = $"Admin: {DangNhapAdmin.AdminName}";
                        dangNhapAdminToolStripMenuItem.Enabled = false;
                    }
                    this.Show();
                }
                else
                {
                    // Nếu không đăng nhập thì thoát ứng dụng
                    Application.Exit();
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DangNhapAdmin.IsAdmin)
            {
                MessageBox.Show("Chỉ Admin mới có quyền quản lý người dùng!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            QuanLyNguoiDung frm = new QuanLyNguoiDung();
            frm.ShowDialog();
        }
    }
}
