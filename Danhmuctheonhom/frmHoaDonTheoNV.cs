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
    public partial class frmHoaDonTheoNV : Form
    {
        DBConnect db = new DBConnect();
        public frmHoaDonTheoNV()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = @"
            SELECT nv.Ho + ' ' + nv.Ten AS TenNhanVien,
               COUNT(hd.Mahd) AS SoHoaDonLap
            FROM nhanvien nv
            LEFT JOIN hoadon hd ON nv.Manv = hd.Manv
            GROUP BY nv.Ho, nv.Ten";

            dgvNV.DataSource = db.GetData(sql);
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
