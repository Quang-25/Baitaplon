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
    public partial class frmHoaDonTheoKH : Form
    {
        DBConnect db = new DBConnect();
        public frmHoaDonTheoKH()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = @"
            SELECT kh.Tencty,
               COUNT(hd.Mahd) AS SoHoaDon
            FROM khachhang kh
            LEFT JOIN hoadon hd ON kh.Makh = hd.Makh
            GROUP BY kh.Tencty";

            dgvKH.DataSource = db.GetData(sql);
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
