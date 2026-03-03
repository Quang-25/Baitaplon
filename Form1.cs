using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlybanhang.Danhmucdon;
using Quanlybanhang.Danhmuctheonhom;

namespace Quanlybanhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void danhMụcThànhPhốToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Danhmucthanhpho pho = new Danhmucthanhpho();
            this.Hide();
            pho.ShowDialog();
            this.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Danhmuckhachhang pho = new Danhmuckhachhang();
            this.Hide();
            pho.ShowDialog();
            this.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void danhMụcSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Danhmucsanpham pho = new Danhmucsanpham();
            this.Hide();
            pho.ShowDialog();
            this.Show();
        }

        private void danhMụcHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Danhmuchoadon danhmuchoadon = new Danhmuchoadon();
            this.Hide();
            danhmuchoadon.ShowDialog();
            this.Show();
        }

        private void danhMụcChiTiếtHóaĐơn_Click(object sender, EventArgs e)
        {
            Danhmucchitiethoadon danhmucchitiethoadon = new Danhmucchitiethoadon();
            this.Hide();
            danhmucchitiethoadon.ShowDialog();
            this.Show();

        }

        private void danhMụcNhânViênToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Danhmucnhanvien nhanvien = new Danhmucnhanvien();
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
        }

        private void kháchHàngTheoThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachtheoTP f = new frmKhachtheoTP();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoKH f = new frmHoaDonTheoKH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoSP f = new frmHoaDonTheoSP();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoNV f = new frmHoaDonTheoNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chiTiếtHóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietTheoNV f = new frmChiTietTheoNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
