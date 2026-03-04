using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quanlybanhang.Danhmucdon
{
    
    public partial class Danhmucsanpham : Form
    {
        string ketnoi = @"Data Source=DESKTOP-ACVJ7GL;Initial Catalog=quanlybanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        string tenhinh = "";
        bool themmoi;

        void loadData()
        {
            try
            {
                conn = new SqlConnection(ketnoi);
                da = new SqlDataAdapter("select * from sanpham", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvsanpham.DataSource = dt;
                dgvsanpham.AutoResizeColumns();
                this.txt_masp.ResetText();
                this.txt_tensp.ResetText();
                this.cmb_donvi.ResetText();
                this.txt_dongia.ResetText();
                this.pic_Hinh.Image = null;
                this.btn_luu.Enabled = false;
                this.btn_huybo.Enabled = false;
                this.panel1.Enabled = false;

                this.btn_them.Enabled = true;
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
                this.btn_thoat.Enabled = true;

            }
            catch(SqlException)
            {
                MessageBox.Show("Khong lay duoc loi roi!");
            }
        }

        public Danhmucsanpham()
        {
            InitializeComponent();
        }

        private void Danhmucsanpham_Load(object sender, EventArgs e)
        {

            loadData();
            LoadImageFromGrid();

        }
        void LoadImageFromGrid()
        {
            if (dgvsanpham.CurrentRow == null) return;

            string imagePath = dgvsanpham.CurrentRow.Cells["Hinh"].Value?.ToString();

            if (string.IsNullOrEmpty(imagePath))
            {
                pic_Hinh.Image = null;
                return;
            }

            string fullPath;

            // Nếu DB đã lưu dạng Images\abc.jpg
            if (imagePath.StartsWith("Images"))
                fullPath = Path.Combine(Application.StartupPath, imagePath);
            else
                fullPath = Path.Combine(Application.StartupPath, "Images", imagePath);

            if (File.Exists(fullPath))
            {
                using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    pic_Hinh.Image = Image.FromStream(fs);
                }
                pic_Hinh.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pic_Hinh.Image = null;
            }

   

        }


        private void btn_reload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            themmoi = true;
            this.txt_masp.Enabled = true;
            this.txt_tensp.Enabled = true;
            this.cmb_donvi.Enabled = true;
            this.txt_dongia.Enabled = true;
            this.txt_masp.ResetText();
            this.txt_tensp.ResetText();
            this.cmb_donvi.ResetText();
            this.txt_dongia.ResetText();
            this.pic_Hinh.Image = null;
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.txt_masp.Focus();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            this.panel1.Enabled = true;
            int r = dgvsanpham.CurrentCell.RowIndex;
            this.txt_masp.Text = dgvsanpham.Rows[r].Cells[0].Value.ToString();
            this.txt_tensp.Text = dgvsanpham.Rows[r].Cells[1].Value.ToString();
            this.cmb_donvi.Text = dgvsanpham.Rows[r].Cells[2].Value.ToString();
            this.txt_dongia.Text = dgvsanpham.Rows[r].Cells[3].Value.ToString();
            string imagePath = dgvsanpham.Rows[r].Cells[4].Value?.ToString();
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel1.Enabled = true;
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_thoat.Enabled = true;
            this.txt_masp.Focus();
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    string fullPath = Path.Combine(Application.StartupPath, "Images", imagePath);

                    if (File.Exists(fullPath))
                    {
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            pic_Hinh.Image = Image.FromStream(fs);
                        }

                        pic_Hinh.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy file: " + fullPath);
                        pic_Hinh.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    pic_Hinh.Image = null;
                }
            }
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
                    cmd.CommandText ="Insert Into sanpham(Masp, Tensp, Donvitinh, Dongia, Hinh) " +"Values(N'" + txt_masp.Text +"', N'" + txt_tensp.Text +"', N'" + cmb_donvi.Text +"', " + txt_dongia.Text +", '" + tenhinh + "')";
                    cmd.CommandType = CommandType.Text; 
                    cmd.ExecuteNonQuery();
                    loadData();
                    MessageBox.Show("Da them xong!");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Khong them duoc roi!");

                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvsanpham.CurrentCell.RowIndex;
                string strsanpham = dgvsanpham.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = "Update sanpham Set " +"Tensp = N'" + txt_tensp.Text +"', Donvitinh = N'" + cmb_donvi.Text +"', Dongia = " + txt_dongia.Text + ", Hinh = '" + tenhinh + "' Where Masp = N'" + txt_masp.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Da sua xong");
            }
            conn.Close();
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.txt_masp.Enabled = true;
            this.txt_tensp.Enabled = true;
            this.cmb_donvi.Enabled = true;
            this.txt_dongia.Enabled = true;
            this.txt_masp.ResetText();
            this.txt_tensp.ResetText();
            this.cmb_donvi.ResetText();
            this.pic_Hinh.Image = null;
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
                int r = dgvsanpham.CurrentCell.RowIndex;
                string strsanpham = dgvsanpham.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from sanpham where Masp ='" + strsanpham + "'");
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

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofd.FileName;               // Đường dẫn gốc
                string fileName = Path.GetFileName(sourcePath); // prev_3.jpg

                // Thư mục Images trong chương trình
                string imageFolder = Path.Combine(Application.StartupPath, "Images");

                // Nếu chưa có thư mục thì tạo
                if (!Directory.Exists(imageFolder))
                    Directory.CreateDirectory(imageFolder);

                // Đường dẫn đích
                string destPath = Path.Combine(imageFolder, fileName);

                // Copy ảnh (ghi đè nếu trùng tên)
                File.Copy(sourcePath, destPath, true);

                // Hiển thị ảnh (không khóa file)
                using (var fs = new FileStream(destPath, FileMode.Open, FileAccess.Read))
                {
                    pic_Hinh.Image = Image.FromStream(fs);
                }

                pic_Hinh.SizeMode = PictureBoxSizeMode.Zoom;

                // LƯU DB: Images/prev_3.jpg
                tenhinh = fileName;
            }
        }


        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            LoadImageFromGrid();
        }

    }
}
