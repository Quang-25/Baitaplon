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
    public partial class Danhmucnhanvien : Form
    {
        string ketnoi = @"Data Source=DESKTOP-ACVJ7GL;Initial Catalog=quanlybanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        string tenhinh ="";
        bool themmoi;
        void loadData()
        {
            try
            {

                conn = new SqlConnection(ketnoi);
               
                da = new SqlDataAdapter("select * from nhanvien", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvnhanvien.DataSource = dt;
                dgvnhanvien.AutoResizeColumns();
                this.txt_manv.ResetText();
                this.txt_ho.ResetText();
                this.txt_ten.ResetText();
                this.cmb_gioitinh.ResetText();
                this.dateTimePicker1.Value=DateTime.Now;
                this.txt_diachi.ResetText();
                this.txt_dienthoai.ResetText();
                this.pic_nv.Image = null;
                this.btn_lưu.Enabled = false;
                this.btn_huybo.Enabled = false;
                this.panel1.Enabled = false;

                this.btn_them.Enabled = true;
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
                this.btn_thoát.Enabled = true;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Nhan vien. Lỗi rồi!!!");

            }
        }
        public Danhmucnhanvien()
        {
            InitializeComponent();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            themmoi = true;
            this.txt_manv.Enabled = true;
            this.txt_ten.Enabled = true;
            this.cmb_gioitinh.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.txt_diachi.Enabled = true;
            this.txt_dienthoai.Enabled = true;
            this.txt_manv.ResetText();
            this.txt_ho.ResetText();
            this.txt_ten.ResetText();
            this.cmb_gioitinh.ResetText();
            this.dateTimePicker1.Value = DateTime.Now;
            this.txt_diachi.ResetText();
            this.txt_dienthoai.ResetText();
            this.pic_nv.Image = null;
            this.btn_lưu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Enabled = true;
            this.txt_manv.Focus();


        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            this.panel1.Enabled = true;
            int r = dgvnhanvien.CurrentCell.RowIndex;
            this.txt_manv.Text = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
            this.txt_ho.Text = dgvnhanvien.Rows[r].Cells[1].Value.ToString();
            this.txt_ten.Text = dgvnhanvien.Rows[r].Cells[2].Value.ToString();
            this.cmb_gioitinh.Text = dgvnhanvien.Rows[r].Cells[3].Value.ToString();
            this.dateTimePicker1.Value = DateTime.Now;dgvnhanvien.Rows[r].Cells[4].Value.ToString();
            this.txt_diachi.Text = dgvnhanvien.Rows[r].Cells[5].Value.ToString();
            this.txt_dienthoai.Text = dgvnhanvien.Rows[r].Cells[6].Value.ToString();
            this.pic_nv.Image = dgvnhanvien.Rows[r].Cells[7].Value as Image;
            this.btn_lưu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_thoát.Enabled = true;
            this.txt_manv.Focus();
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
                   cmd.CommandText = "Insert Into Nhanvien(Manv, Ho, Ten, Gioitinh, Ngaynv, Diachi, Dienthoai, Hinh) " +"Values(N'" + txt_manv.Text +"', N'" + txt_ho.Text +"', N'" + txt_ten.Text +"', N'" + cmb_gioitinh.Text +"', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +"', N'" + txt_diachi.Text +"', '" + txt_dienthoai.Text +"', '" + tenhinh + "')";
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
                int r = dgvnhanvien.CurrentCell.RowIndex;
                string strthanhpho = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = "Update Nhanvien Set " +"Ho = N'" + txt_ho.Text +"', Ten = N'" + txt_ten.Text +"', Gioitinh = N'" + cmb_gioitinh.Text +"', Ngaynv = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +"', Diachi = N'" + txt_diachi.Text +"', Dienthoai = '" + txt_dienthoai.Text + "', Hinh = '" + tenhinh + "' Where Manv = N'" + txt_manv.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Da sua xong");
            }
            conn.Close();

        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.txt_manv.Enabled = true;
            this.txt_ten.Enabled = true;
            this.cmb_gioitinh.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.txt_diachi.Enabled = true;
            this.txt_dienthoai.Enabled = true;
            this.txt_manv.ResetText();
            this.txt_ho.ResetText();
            this.txt_ten.ResetText();
            this.cmb_gioitinh.ResetText();
            this.dateTimePicker1.Value = DateTime.Now;
            this.txt_diachi.ResetText();
            this.txt_dienthoai.ResetText();
            this.pic_nv.Image = null;
            this.btn_lưu.Enabled = false;
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
                int r = dgvnhanvien.CurrentCell.RowIndex;
                string strnhanvien = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from nhanvien where Manv ='" + strnhanvien + "'");
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

        private void btn_thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Danhmucnhanvien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_nv.Image = Image.FromFile(ofd.FileName);
                tenhinh = System.IO.Path.GetFileName(ofd.FileName);
            }
        }
    }
}
