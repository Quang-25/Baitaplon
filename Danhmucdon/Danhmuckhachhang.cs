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

namespace Quanlybanhang.Danhmucdon
{
    public partial class Danhmuckhachhang : Form
    {
        string ketnoi = @"Data Source=LAPTOP-VN022S39\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        bool themmoi;

        void loadData()
        {
            try
            {
                conn = new SqlConnection(ketnoi);
                da = new SqlDataAdapter("select * from Khachhang", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvkhachhang.DataSource = dt;
                dgvkhachhang.AutoResizeColumns();
                this.txt_khachhang.ResetText();
                this.txt_tencty.ResetText();
                this.txt_diachi.ResetText();
                this.txt_thanhpho.ResetText();
                this.txt_dienthoai.ResetText();
                this.btn_lưu.Enabled = false;
                this.btn_huy.Enabled = false;
                this.panel1.Enabled = false;

                this.btn_them.Enabled = true;
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
                this.btn_thoát.Enabled = true;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Thành phố. Lỗi rồi!!!");

            }
        }
        public Danhmuckhachhang()
        {
            InitializeComponent();
        }
        private void Danhmuckhachhang_Load(object sender, EventArgs e)
        {
            loadData();

        }
        private void btn_reload_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            themmoi = true;
            this.txt_khachhang.Enabled = true;
            this.txt_tencty.Enabled = true;
            this.txt_diachi.Enabled = true;
            this.txt_thanhpho.Enabled = true;
            this.txt_dienthoai.Enabled = true;
            this.txt_khachhang.ResetText();
            this.txt_tencty.ResetText();
            this.txt_diachi.ResetText();
            this.txt_thanhpho.ResetText();
            this.txt_dienthoai.ResetText();

            this.btn_lưu.Enabled = true;
            this.btn_huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.txt_khachhang.Focus();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            this.panel1.Enabled = true;
            int r = dgvkhachhang.CurrentCell.RowIndex;
            this.txt_khachhang.Text = dgvkhachhang.Rows[r].Cells[0].Value.ToString();
            this.txt_tencty.Text = dgvkhachhang.Rows[r].Cells[1].Value.ToString();
            this.txt_diachi.Text = dgvkhachhang.Rows[r].Cells[2].Value.ToString();
            this.txt_thanhpho.Text = dgvkhachhang.Rows[r].Cells[3].Value.ToString();
            this.txt_dienthoai.Text = dgvkhachhang.Rows[r].Cells[4].Value.ToString();
            this.btn_lưu.Enabled = true;
            this.btn_huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_thoát.Enabled = true;
            this.txt_khachhang.Focus();

        }
        private void btn_lưu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (themmoi)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText ="Insert Into Khachhang(Makh, Tencty, Diachi, Thanhpho, Dienthoai) Values('"+ txt_khachhang.Text + "', N'"+ txt_tencty.Text + "', N'"+ txt_diachi.Text + "', '"+ txt_thanhpho.Text + "', '"  + txt_dienthoai.Text + "')";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    loadData();
                    MessageBox.Show("da them xong!");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong them duoc.Loi roi");
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvkhachhang.CurrentCell.RowIndex;
                string strthanhpho = dgvkhachhang.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText ="Update Khachhang Set Tencty = N'" + txt_tencty.Text +"', Diachi = N'" + txt_diachi.Text +"', Thanhpho = '" + txt_thanhpho.Text +"', Dienthoai = '" + txt_dienthoai.Text +"' Where Makh = '" + txt_khachhang.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Da sua xong");
            }
            conn.Close();
        }
    
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvkhachhang.CurrentCell.RowIndex;
                string strkhachhang = dgvkhachhang.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from Khachhang where Makh ='" + strkhachhang + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Đã xóa xong!!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.txt_khachhang.Enabled = true;
            this.txt_tencty.Enabled = true;
            this.txt_diachi.Enabled = true;
            this.txt_thanhpho.Enabled = true;
            this.txt_dienthoai.Enabled = true;
            this.txt_khachhang.ResetText();
            this.txt_tencty.ResetText();
            this.txt_diachi.ResetText();
            this.txt_thanhpho.ResetText();
            this.txt_dienthoai.ResetText();

            this.btn_lưu.Enabled = false;
            this.btn_huy.Enabled = false;
            this.panel1.Enabled = false;
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
           
        }

        private void btn_thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
