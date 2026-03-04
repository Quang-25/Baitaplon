using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang.giupdo
{
    public partial class huongdan : Form
    {
        public huongdan()
        {
            InitializeComponent();
        }

        private void huongdan_Load(object sender, EventArgs e)
        {
            // 1. Nhóm Hệ thống
            TreeNode nodeHeThong = new TreeNode("1. Hệ thống");
            nodeHeThong.Nodes.Add("Cấu hình hệ thống");
            nodeHeThong.Nodes.Add("Quản lý người dùng");
            nodeHeThong.Nodes.Add("Đăng nhập");
            nodeHeThong.Nodes.Add("Đổi mật khẩu");
            

            // 2. Nhóm Xem danh mục
            TreeNode nodeDanhMuc = new TreeNode("2. Xem danh mục");
            nodeDanhMuc.Nodes.Add("Xem Thành phố");
            nodeDanhMuc.Nodes.Add("Xem Khách hàng");
            nodeDanhMuc.Nodes.Add("Xem Nhân viên"); // Thêm mới
            nodeDanhMuc.Nodes.Add("Xem Sản phẩm");   // Thêm mới
            nodeDanhMuc.Nodes.Add("Danh mục hóa đơn");
            nodeDanhMuc.Nodes.Add("Danh mục chi tiết hóa đơn");

            // 3. Nhóm Quản lý dữ liệu
            TreeNode nodeQuanLy = new TreeNode("3. Quản lý danh mục đơn"); // Thêm mới nhóm 3
            nodeQuanLy.Nodes.Add("Danh mục thành phố");
           
            nodeQuanLy.Nodes.Add("Danh mục khách hàng");
            nodeQuanLy.Nodes.Add("Danh mục nhân viên");
            nodeQuanLy.Nodes.Add("Danh mục sản phẩm ");
            nodeQuanLy.Nodes.Add("Danh mục Hóa đơn");
            nodeQuanLy.Nodes.Add("Danh mục Chi tiết hóa đơn");

            TreeNode nodeQuanLytheonhom = new TreeNode("4. Quản lý danh mục theo nhóm"); // Thêm mới nhóm 4
            nodeQuanLytheonhom.Nodes.Add("Khách hàng theo thành phố");
            nodeQuanLytheonhom.Nodes.Add("Hóa đơn theo khách hàng");
            nodeQuanLytheonhom.Nodes.Add("Hóa đơn theo sản phẩm ");
            nodeQuanLytheonhom.Nodes.Add("Hóa đơn theo nhân viên ");
            nodeQuanLytheonhom.Nodes.Add("Chi tiết hóa đơn theo nhân viên");
        

            // Thêm tất cả các nhóm vào TreeView
            treeView1.Nodes.Add(nodeHeThong);
            treeView1.Nodes.Add(nodeDanhMuc);
            treeView1.Nodes.Add(nodeQuanLy); // Đừng quên dòng này
            treeView1.Nodes.Add(nodeQuanLytheonhom);

            // Mở rộng để thấy hết các mục con
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNode = e.Node.Text;
            rtbNoiDung.Clear(); // Xóa nội dung cũ trước khi hiển thị nội dung mới

            switch (selectedNode)
            {
                // NHÓM 1: HỆ THỐNG
                case "Cấu hình hệ thống":
                    rtbNoiDung.SelectionFont = new Font(rtbNoiDung.Font, FontStyle.Bold);
                    rtbNoiDung.AppendText("HƯỚNG DẪN CẤU HÌNH HỆ THỐNG\n\n");
                    rtbNoiDung.AppendText("- Bước 1: - Vào menu Hệ thống -> Chọn 'Cấu hình hệ thống'.\n");
                    rtbNoiDung.AppendText("- Bước 2: - Thay đổi màu nền hoặc hình ảnh đại diện của đơn vị (Logo).\n");
                    rtbNoiDung.AppendText("- Bước 3: - Cập nhật tên trường học hoặc tên doanh nghiệp hiển thị trên màn hình chính.\n\n");
                    break;
                case "Quản lý người dùng":
                    rtbNoiDung.SelectionFont = new Font(rtbNoiDung.Font, FontStyle.Bold);
                    rtbNoiDung.AppendText("HƯỚNG DẪN QUẢN LÝ NGƯỜI DÙNG\n\n");
                    rtbNoiDung.AppendText("Chức năng này cho phép quản trị viên (Admin) kiểm soát danh sách tài khoản được phép truy cập vào phần mềm.\n");
                    rtbNoiDung.AppendText("\"1. Thêm tài khoản mới:\\n\" +\r\n        \"   - Nhập 'Tên đăng nhập' (không trùng lặp) và 'Mật khẩu' mặc định cho người dùng mới.\\n\" +\r\n        \"   - Chọn loại quyền (ví dụ: Admin hoặc Nhân viên) để giới hạn các chức năng được phép sử dụng.\\n\\n\"");
                   
                    break;
                case "Đăng nhập":
                    rtbNoiDung.SelectionFont = new Font(rtbNoiDung.Font, FontStyle.Bold);
                    rtbNoiDung.AppendText("HƯỚNG DẪN ĐĂNG NHẬP\n\n");
                    rtbNoiDung.AppendText("- Bước 1: Khởi động ứng dụng.\n");
                    rtbNoiDung.AppendText("- Bước 2: Nhập đúng 'Tên đăng nhập' và 'Mật khẩu' được cấp.\n");
                    rtbNoiDung.AppendText("- Bước 3: Nhấn 'Đăng nhập'. Nếu thành công, các chức năng trên Menu sẽ hiện lên.");
                    break;

                case "Đổi mật khẩu":
                    rtbNoiDung.SelectionFont = new Font(rtbNoiDung.Font, FontStyle.Bold);
                    rtbNoiDung.AppendText("HƯỚNG DẪN ĐỔI MẬT KHẨU\n\n");
                    rtbNoiDung.AppendText("- Vào menu Hệ thống -> Chọn 'Đổi mật khẩu'.\n");
                    rtbNoiDung.AppendText("- Nhập mật khẩu cũ, mật khẩu mới và xác nhận lại mật khẩu mới để đảm bảo tính bảo mật.");
                    break;

                // NHÓM 2: XEM DANH MỤC (SỬ DỤNG FORM DÙNG CHUNG THANHPHO)
                case "Xem Thành phố":
                case "Xem Khách hàng":
                case "Xem Nhân viên":
                case "Xem Sản phẩm":
                    rtbNoiDung.SelectionFont = new Font(rtbNoiDung.Font, FontStyle.Bold);
                    rtbNoiDung.AppendText($"HƯỚNG DẪN {selectedNode.ToUpper()}\n\n");
                    rtbNoiDung.AppendText($"- Bạn đang xem mục: {selectedNode}.\n");
                    rtbNoiDung.AppendText("- Chức năng này giúp bạn tra cứu nhanh danh sách dữ liệu từ cơ sở dữ liệu SQL Server.\n");
                    rtbNoiDung.AppendText("- Dữ liệu được hiển thị dưới dạng bảng (GridView). Bạn có thể nhấn nút 'Thoát' để quay lại màn hình chính.");
                    break;

                // NHÓM 3: QUẢN LÝ DỮ LIỆU (THÊM/SỬA/XÓA)
                case "Quản lý Hóa đơn":
                    rtbNoiDung.SelectionFont = new Font(rtbNoiDung.Font, FontStyle.Bold);
                    rtbNoiDung.AppendText("QUẢN LÝ HÓA ĐƠN\n\n");
                    rtbNoiDung.AppendText("- Thêm: Nhập đầy đủ thông tin hóa đơn và nhấn 'Thêm'.\n");
                    rtbNoiDung.AppendText("- Sửa: Chọn một dòng trong bảng, thay đổi thông tin và nhấn 'Sửa'.\n");
                    rtbNoiDung.AppendText("- Xóa: Chọn dòng cần xóa và nhấn nút 'Xóa' (Cần cẩn trọng khi sử dụng).");
                    break;

                case "Chi tiết hóa đơn":
                    rtbNoiDung.SelectionFont = new Font(rtbNoiDung.Font, FontStyle.Bold);
                    rtbNoiDung.AppendText("CHI TIẾT HÓA ĐƠN\n\n");
                    rtbNoiDung.AppendText("- Đây là nơi quản lý các mặt hàng có trong một hóa đơn cụ thể.\n");
                    rtbNoiDung.AppendText("- Bao gồm thông tin về: Mã hóa đơn, Mã sản phẩm, Số lượng và Đơn giá.");
                    break;

                default:
                    rtbNoiDung.Text = "Vui lòng chọn một mục ở bên trái để xem hướng dẫn chi tiết.";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
