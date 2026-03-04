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
    public partial class Danhmuchoadon : Form
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
                da = new SqlDataAdapter("select * from hoadon", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_hoadon.DataSource = dt;
                dgv_hoadon.AutoResizeColumns();
                this.txt_mahoadon.ResetText();
                this.txt_manv.ResetText();
                this.txt_khachhang.ResetText();
                this.dateTimePicker1.Value = DateTime.Now;
                this.dateTimePicker2.Value = DateTime.Now;
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

        public Danhmuchoadon()
        {
            InitializeComponent();
        }

        private void Danhmuchoadon_Load(object sender, EventArgs e)
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
            this.txt_manv.Enabled = true;
            this.txt_khachhang.Enabled = true;
            this.txt_mahoadon.ResetText();
            this.txt_manv.ResetText();
            this.txt_khachhang.ResetText();
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker2.Value = DateTime.Now;
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.txt_mahoadon.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            this.panel1.Enabled = true;
            int r = dgv_hoadon.CurrentCell.RowIndex;
            this.txt_mahoadon.Text = dgv_hoadon.Rows[r].Cells[0].Value.ToString();
            this.txt_khachhang.Text = dgv_hoadon.Rows[r].Cells[1].Value.ToString();
            this.txt_manv.Text = dgv_hoadon.Rows[r].Cells[2].Value.ToString();
            this.dateTimePicker1.Value = Convert.ToDateTime(dgv_hoadon.Rows[r].Cells[3].Value);
            this.dateTimePicker2.Value = Convert.ToDateTime(dgv_hoadon.Rows[r].Cells[4].Value);
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
                    cmd.CommandText = "Insert Into hoadon (Mahd,Makh,Manv,Ngaylaphd,Ngaynhanhang) " + "Values(N'" + txt_mahoadon.Text +"', N'" + txt_khachhang.Text +"', N'" + txt_manv.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +"', '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')";
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
                int r = dgv_hoadon.CurrentCell.RowIndex;
                string strhoadon = dgv_hoadon.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText ="Update hoadon Set " +"Makh = N'" + txt_khachhang.Text + "', " +"Manv = N'" + txt_manv.Text + "', " +"Ngaylaphd = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " +"Ngaynhanhang = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' " +"Where Mahd = N'" + txt_mahoadon.Text + "'";
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
            this.txt_khachhang.Enabled = true;
            this.txt_manv.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.txt_mahoadon.ResetText();
            this.txt_khachhang.ResetText();
            this.txt_manv.ResetText();
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker2.Value = DateTime.Now;
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
                int r = dgv_hoadon.CurrentCell.RowIndex;
                string strhoadon = dgv_hoadon.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from hoadon where Mahd='" + strhoadon + "'");
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

