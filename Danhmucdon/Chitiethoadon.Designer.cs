namespace Quanlybanhang.Danhmucdon
{
    partial class Danhmucchitiethoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_masp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huybo = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_chitiet = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_masp
            // 
            this.lbl_masp.AutoSize = true;
            this.lbl_masp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masp.Location = new System.Drawing.Point(3, 30);
            this.lbl_masp.Name = "lbl_masp";
            this.lbl_masp.Size = new System.Drawing.Size(110, 22);
            this.lbl_masp.TabIndex = 5;
            this.lbl_masp.Text = "Mã hóa đơn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_soluong);
            this.panel1.Controls.Add(this.txt_masp);
            this.panel1.Controls.Add(this.txt_mahoadon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_masp);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 96);
            this.panel1.TabIndex = 6;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(716, 31);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(120, 22);
            this.txt_soluong.TabIndex = 12;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(442, 29);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(158, 22);
            this.txt_masp.TabIndex = 11;
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(119, 30);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(168, 22);
            this.txt_mahoadon.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã sản phẩm: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng:";
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(27, 107);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_reload.Size = new System.Drawing.Size(90, 56);
            this.btn_reload.TabIndex = 7;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(319, 107);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 56);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(612, 107);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 56);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(27, 169);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_luu.Size = new System.Drawing.Size(90, 56);
            this.btn_luu.TabIndex = 10;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.Location = new System.Drawing.Point(319, 169);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_huybo.Size = new System.Drawing.Size(95, 56);
            this.btn_huybo.TabIndex = 11;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.UseVisualStyleBackColor = true;
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(612, 169);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_xoa.Size = new System.Drawing.Size(92, 56);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(745, 138);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(95, 56);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_chitiet
            // 
            this.dgv_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiet.Location = new System.Drawing.Point(4, 231);
            this.dgv_chitiet.Name = "dgv_chitiet";
            this.dgv_chitiet.RowHeadersWidth = 51;
            this.dgv_chitiet.RowTemplate.Height = 24;
            this.dgv_chitiet.Size = new System.Drawing.Size(850, 226);
            this.dgv_chitiet.TabIndex = 14;
            // 
            // Danhmucchitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 466);
            this.Controls.Add(this.dgv_chitiet);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.panel1);
            this.Name = "Danhmucchitiethoadon";
            this.Text = "DanhmucChitiethoadon";
            this.Load += new System.EventHandler(this.Danhmucchitiethoadon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_masp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huybo;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_chitiet;
    }
}