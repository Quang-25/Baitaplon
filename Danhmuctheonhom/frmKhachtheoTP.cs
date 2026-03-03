using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang.Danhmuctheonhom
{
    public partial class frmKhachtheoTP : Form
    {
        DBConnect db = new DBConnect();
        public frmKhachtheoTP()
        {
            InitializeComponent();
        }

        private void frmKhachtheoTP_Load(object sender, EventArgs e)
        {
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT tp.Tenthanhpho,
                       COUNT(kh.Makh) AS SoLuongKhach
                FROM thanhpho tp
                LEFT JOIN khachhang kh 
                ON tp.Thanhpho = kh.Thanhpho
                GROUP BY tp.Tenthanhpho";

            dgvThongKe.DataSource = db.GetData(query);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn thoát?",
                "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
