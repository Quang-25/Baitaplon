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
    public partial class Danhmucthanhpho : Form
    {
        string ketnoi = @"Data Source=DESKTOP-ACVJ7GL;Initial Catalog=quanlybanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        bool themmoi;


        public Danhmucthanhpho()
        {
            InitializeComponent();
        }

        void loadData()
        {
            try
            {
                conn = new SqlConnection(ketnoi);
                da = new SqlDataAdapter("select * from Thanhpho", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvthanhpho.DataSource = dt;
                dgvthanhpho.AutoResizeColumns();
                this.txt_thanhpho.ResetText();
                this.txt_tentp.ResetText();

                this.btn_luu1.Enabled = false;
                this.btn_huy.Enabled = false;
                this.panel1.Enabled = false;
             
                this.btnthem.Enabled = true;
                this.btnsua.Enabled = true;
                this.btnxoa.Enabled = true;
                this.btnthoat.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Thành phố. Lỗi rồi!!!");

            }
        }
        private void Danhmucthanhpho_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnreload_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void Danhmucthanhpho_FormClosing(object sender, FormClosingEventArgs e)
        {
            dt.Dispose();
            dt = null;
            conn = null;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            themmoi = true;
          this.txt_thanhpho.Enabled = true;
           this.txt_tentp.Enabled = true;
            this.txt_thanhpho.ResetText();
            this.txt_tentp.ResetText();
            this.btn_luu1.Enabled = true;
            this.btn_huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btnthem.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnxoa.Enabled = false;
            this.btnthoat.Enabled = true;
            this.txt_thanhpho.Focus();

        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            this.panel1.Enabled = true;
            int r = dgvthanhpho.CurrentCell.RowIndex;
            this.txt_thanhpho.Text = dgvthanhpho.Rows[r].Cells[0].Value.ToString();
            this.txt_tentp.Text = dgvthanhpho.Rows[r].Cells[1].Value.ToString();
            this.btn_luu1.Enabled = true;
            this.btn_huy.Enabled = true;
            this.panel1.Enabled = true;
            this.btnthem.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnxoa.Enabled = true;
            this.btnthoat.Enabled = true;
            this.txt_thanhpho.Focus();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvthanhpho.CurrentCell.RowIndex;
                string strthanhpho = dgvthanhpho.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from Thanhpho where Thanhpho='" + strthanhpho + "'");
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
            this.txt_thanhpho.ResetText();
            this.txt_tentp.ResetText();
            this.btn_luu1.Enabled = false;
            this.btn_huy.Enabled = false;
            this.panel1.Enabled = false;
            this.btnthem.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnxoa.Enabled = true;
            this.btnthoat.Enabled = true;
        }
        private void btn_luu1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (themmoi)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert Into Thanhpho(Thanhpho, Tenthanhpho) Values('"+ txt_thanhpho.Text + "',N'" + txt_tentp.Text +"')";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    loadData();
                    MessageBox.Show("da them xong!");

                }
                catch(SqlException)
                {
                    MessageBox.Show("Khong them duoc.Loi roi");
                }
            }
            else 
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvthanhpho.CurrentCell.RowIndex;
                string strthanhpho = dgvthanhpho.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = "Update Thanhpho Set Tenthanhpho = N'" + txt_tentp.Text + "' Where Thanhpho = '"+ txt_thanhpho.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Da sua xong");
            }
            conn.Close();
        }
    }
}
