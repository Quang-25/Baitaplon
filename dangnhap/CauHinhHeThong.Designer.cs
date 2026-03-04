namespace Quanlybanhang
{
    partial class CauHinhHeThong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panelFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnHuy = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.tabTheme = new System.Windows.Forms.TabPage();
            this.btnApDungTheme = new System.Windows.Forms.Button();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTheme.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(422, 330);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 35);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "ĐÓNG";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 380);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(584, 30);
            this.panelFooter.TabIndex = 2;
            // 
            // tabTheme
            // 
            this.tabTheme.Controls.Add(this.lblTheme);
            this.tabTheme.Controls.Add(this.cboTheme);
            this.tabTheme.Controls.Add(this.btnApDungTheme);
            this.tabTheme.Location = new System.Drawing.Point(4, 25);
            this.tabTheme.Name = "tabTheme";
            this.tabTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheme.Size = new System.Drawing.Size(552, 271);
            this.tabTheme.TabIndex = 1;
            this.tabTheme.Text = "Giao diện";
            this.tabTheme.UseVisualStyleBackColor = true;
            // 
            // btnApDungTheme
            // 
            this.btnApDungTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnApDungTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApDungTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnApDungTheme.ForeColor = System.Drawing.Color.White;
            this.btnApDungTheme.Location = new System.Drawing.Point(50, 130);
            this.btnApDungTheme.Name = "btnApDungTheme";
            this.btnApDungTheme.Size = new System.Drawing.Size(150, 35);
            this.btnApDungTheme.TabIndex = 2;
            this.btnApDungTheme.Text = "ÁP DỤNG";
            this.btnApDungTheme.UseVisualStyleBackColor = false;
            this.btnApDungTheme.Click += new System.EventHandler(this.btnApDungTheme_Click);
            // 
            // cboTheme
            // 
            this.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboTheme.Items.AddRange(new object[] {
            "Mặc định",
            "Xanh dương",
            "Xanh lá",
            "Cam",
            "Tím"});
            this.cboTheme.Location = new System.Drawing.Point(50, 75);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(200, 30);
            this.cboTheme.TabIndex = 1;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTheme.Location = new System.Drawing.Point(50, 50);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(125, 20);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Chọn giao diện:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTheme);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(560, 300);
            this.tabControl.TabIndex = 0;
            // 
            // CauHinhHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 410);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CauHinhHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình hệ thống (Admin)";
            this.tabTheme.ResumeLayout(false);
            this.tabTheme.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabPage tabTheme;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.Button btnApDungTheme;
        private System.Windows.Forms.TabControl tabControl;
    }
}