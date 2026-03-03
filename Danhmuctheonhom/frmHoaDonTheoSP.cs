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
    public partial class frmHoaDonTheoSP : Form
    {
        DBConnect db = new DBConnect();
        public frmHoaDonTheoSP()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = @"
            SELECT sp.Tensp,
               SUM(ct.Soluong) AS TongSoLuongBan
            FROM sanpham sp
            LEFT JOIN chitiethoadon ct ON sp.Masp = ct.Masp
            GROUP BY sp.Tensp";

            dgvSP.DataSource = db.GetData(sql);
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
