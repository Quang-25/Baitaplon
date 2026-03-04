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

namespace Quanlybanhang.Xemdanhmuc
{
    public partial class ThanhPho : Form
    {
        string ketnoi = @"Data Source=DESKTOP-ACVJ7GL;Initial Catalog=quanlybanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public ThanhPho()
        {
            InitializeComponent();
        }

        public int intDM = 0; // Thêm dòng này ở trên hàm Constructor
        private void Danhmucthanhpho_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ketnoi);
                
                switch (intDM)
                {
                    case 1:
                        this.Text = "Danh mục Thành phố";
                        label1.Text = "Danh mục thành phố";
                        da = new SqlDataAdapter("select * from Thanhpho", conn);
                        break;
                    case 2:
                        this.Text = "Danh mục Khách hàng";
                        label1.Text = "Danh mục khách hàng";
                        da = new SqlDataAdapter("select * from Khachhang", conn);
                        break;
                    case 3:
                        this.Text = "Danh mục Nhân viên";
                        label1.Text = "Danh mục nhân viên";
                        da = new SqlDataAdapter("select * from Nhanvien", conn);
                        break;
                    case 4:
                        this.Text = "Danh mục Sản phẩm";
                        label1.Text = "Danh mục sản phẩm";
                        da = new SqlDataAdapter("select * from Sanpham", conn);
                        break;
                    case 5:
                        this.Text = "Danh mục Hóa đơn";
                        label1.Text = "Danh mục hóa đơn";
                        da = new SqlDataAdapter("select * from Hoadon", conn);
                        break;
                        case 6:
                            this.Text = "Danh mục Chi tiết hóa đơn";
                            label1.Text = "Danh mục chi tiết hóa đơn";
                            da = new SqlDataAdapter("select * from Chitiethoadon", conn);
                                break;
                    default:
                        break;

                }
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoResizeColumns();


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
