using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang.giupdo
{
    public partial class Tacgia : Form
    {
        public Tacgia()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Tacgia_Load(object sender, EventArgs e)
        {
            // Đưa Label xuống dưới cùng của Panel khi vừa mở Form
            lblCredits.Top = panelContainer.Height;
            // Căn giữa Label theo chiều ngang
            lblCredits.Left = (panelContainer.Width - lblCredits.Width) / 2;
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCredits.Top -= 2;

            // Nếu toàn bộ nội dung đã chạy khuất lên trên, cho nó quay lại từ dưới
            if (lblCredits.Top < -lblCredits.Height)
            {
                lblCredits.Top = panelContainer.Height;
            }
        }
    }
}
