using Quanlybanhang;
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
    public partial class frmChiTietTheoNV : Form
    {
        DBConnect db = new DBConnect();
        public frmChiTietTheoNV()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = @"
        SELECT nv.Ho + ' ' + nv.Ten AS TenNhanVien,
               hd.Mahd,
               sp.Tensp,
               ct.Soluong
        FROM nhanvien nv
        JOIN hoadon hd ON nv.Manv = hd.Manv
        JOIN chitiethoadon ct ON hd.Mahd = ct.Mahd
        JOIN sanpham sp ON ct.Masp = sp.Masp
        ORDER BY TenNhanVien";

            dgvCT.DataSource = db.GetData(sql);
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
