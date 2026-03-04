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

namespace Quanlybanhang
{
    public partial class CauHinhHeThong : Form
    {
        string connectionString = @"Data Source=DESKTOP-ACW7GL;Initial Catalog=quanlybanhang;Integrated Security=True";

        public CauHinhHeThong()
        {
            InitializeComponent();
            LoadCurrentConfig();
        }

        private void LoadCurrentConfig()
        {
            try
            {
                // Load theme hiện tại từ Settings
                cboTheme.SelectedItem = Properties.Settings.Default.Theme;
                ApplyTheme(Properties.Settings.Default.Theme);
            }
            catch
            {
                cboTheme.SelectedItem = "Mặc định";
            }
        }

        private void ApplyTheme(string theme)
        {
            switch (theme)
            {
                case "Xanh dương":
                    this.BackColor = Color.FromArgb(52, 152, 219);
                    break;
                case "Xanh lá":
                    this.BackColor = Color.FromArgb(46, 204, 113);
                    break;
                case "Cam":
                    this.BackColor = Color.FromArgb(230, 126, 34);
                    break;
                case "Tím":
                    this.BackColor = Color.FromArgb(155, 89, 182);
                    break;
                default:
                    this.BackColor = Color.FromArgb(240, 240, 240);
                    break;
            }
        }

        private void btnApDungTheme_Click(object sender, EventArgs e)
        {
            string selectedTheme = cboTheme.SelectedItem?.ToString() ?? "Mặc định";

            // Lưu theme vào Settings
            Properties.Settings.Default.Theme = selectedTheme;
            Properties.Settings.Default.Save();

            ApplyTheme(selectedTheme);

            MessageBox.Show("Đã áp dụng theme thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}