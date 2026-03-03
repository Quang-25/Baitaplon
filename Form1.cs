using Quanlybanhang.Danhmuctheonhom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kháchHàngTheoThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachtheoTP frm = new frmKhachtheoTP();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoKH frm = new frmHoaDonTheoKH();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoSP frm = new frmHoaDonTheoSP();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void hóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoNV frm = new frmHoaDonTheoNV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void chiTiếtHóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietTheoNV frm = new frmChiTietTheoNV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
