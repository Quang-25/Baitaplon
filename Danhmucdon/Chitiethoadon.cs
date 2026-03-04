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
    
    public partial class Danhmucchitiethoadon : Form
    { 
       string ketnoi= @"Data Source=DESKTOP-ACVJ7GL;Initial Catalog=quanlybanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        bool themmoi;
        void loadData()
        {
            try
            {
                conn = new SqlConnection(ketnoi);
                da = new SqlDataAdapter("select Mahd, Masp, Soluong from chitiethoadon", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_chitiet.DataSource = dt;
                dgv_chitiet.AutoResizeColumns();
                dgv_chitiet.AutoGenerateColumns = true;
                this.txt_mahoadon.ResetText();
                this.txt_masp.ResetText();
                this.txt_soluong.ResetText();
                this.btn_luu.Enabled = false;
                this.btn_huybo.Enabled = false;
                this.panel1.Enabled = false;
                this.btn_them.Enabled = true;
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
                this.btn_thoat.Enabled = true;

            }
            catch (SqlException)
            {
                MessageBox.Show("Khong lay duoc loi roi!");
            }
        }

       
       
        public Danhmucchitiethoadon()
        {
            InitializeComponent();
        }
        private void Danhmucchitiethoadon_Load(object sender, EventArgs e)
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
            this.txt_mahoadon.Enabled = true;
            this.txt_masp.Enabled = true;
            this.txt_soluong.Enabled = true;
            this.txt_mahoadon.ResetText();
            this.txt_masp.ResetText();
            this.txt_soluong.ResetText();
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Enabled = true;
            this.txt_mahoadon.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            this.panel1.Enabled = true;
            int r = dgv_chitiet.CurrentCell.RowIndex;
            this.txt_mahoadon.Text = dgv_chitiet.Rows[r].Cells[0].Value.ToString();
            this.txt_masp.Text = dgv_chitiet.Rows[r].Cells[1].Value.ToString();
            this.txt_soluong.Text = dgv_chitiet.Rows[r].Cells[2].Value.ToString();
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_thoat.Enabled = true;
            this.txt_mahoadon.Focus();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (themmoi)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert Into chitiethoadon Values('" + txt_mahoadon.Text + "','" + txt_masp.Text + "','" + txt_soluong.Text + "')";
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
                int r = dgv_chitiet.CurrentCell.RowIndex;
                string strchitiet = dgv_chitiet.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = "Update chitiethoadon Set " + "Masp = '" + txt_masp.Text + "', " + "Soluong = '" + txt_soluong.Text + "' " + "Where Mahd = '" + txt_mahoadon.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Da sua xong");
            }
            conn.Close();
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.txt_mahoadon.Enabled = true;
            this.txt_masp.Enabled = true;
            this.txt_soluong.Enabled = true;
            this.txt_mahoadon.ResetText();
            this.txt_masp.ResetText();
            this.txt_soluong.ResetText();
            this.btn_luu.Enabled = false;
            this.btn_huybo.Enabled = false;
            this.panel1.Enabled = false;
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgv_chitiet.CurrentCell.RowIndex;
                string strchitiet = dgv_chitiet.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from chitiethoadon where Mahd ='" + strchitiet + "'");
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
