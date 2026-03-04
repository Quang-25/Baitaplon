namespace Quanlybanhang.Danhmucdon
{
    partial class Danhmucsanpham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Hinh = new System.Windows.Forms.PictureBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.cmb_donvi = new System.Windows.Forms.ComboBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.lbl_Hinh = new System.Windows.Forms.Label();
            this.lbl_dongia = new System.Windows.Forms.Label();
            this.lbl_donvi = new System.Windows.Forms.Label();
            this.lbl_tensp = new System.Windows.Forms.Label();
            this.lbl_masp = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huybo = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.btn_chonanh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_Hinh);
            this.panel1.Controls.Add(this.txt_dongia);
            this.panel1.Controls.Add(this.cmb_donvi);
            this.panel1.Controls.Add(this.txt_tensp);
            this.panel1.Controls.Add(this.txt_masp);
            this.panel1.Controls.Add(this.lbl_Hinh);
            this.panel1.Controls.Add(this.lbl_dongia);
            this.panel1.Controls.Add(this.lbl_donvi);
            this.panel1.Controls.Add(this.lbl_tensp);
            this.panel1.Controls.Add(this.lbl_masp);
            this.panel1.Location = new System.Drawing.Point(27, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 178);
            this.panel1.TabIndex = 0;
            // 
            // pic_Hinh
            // 
            this.pic_Hinh.Location = new System.Drawing.Point(525, 52);
            this.pic_Hinh.Name = "pic_Hinh";
            this.pic_Hinh.Size = new System.Drawing.Size(180, 112);
            this.pic_Hinh.Size = new System.Drawing.Size(192, 112);
            this.pic_Hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hinh.TabIndex = 11;
            this.pic_Hinh.TabStop = false;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(525, 6);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(180, 22);
            this.txt_dongia.TabIndex = 10;
            // 
            // cmb_donvi
            // 
            this.cmb_donvi.FormattingEnabled = true;
            this.cmb_donvi.Items.AddRange(new object[] {
            "Kg",
            "Thùng",
            "Lít",
            "Hộp",
            "Cái",
            "Chai"});
            this.cmb_donvi.Location = new System.Drawing.Point(136, 106);
            this.cmb_donvi.Name = "cmb_donvi";
            this.cmb_donvi.Size = new System.Drawing.Size(121, 24);
            this.cmb_donvi.TabIndex = 9;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(136, 63);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(136, 22);
            this.txt_tensp.TabIndex = 8;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(136, 9);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(136, 22);
            this.txt_masp.TabIndex = 7;
            // 
            // lbl_Hinh
            // 
            this.lbl_Hinh.AutoSize = true;
            this.lbl_Hinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hinh.Location = new System.Drawing.Point(431, 63);
            this.lbl_Hinh.Name = "lbl_Hinh";
            this.lbl_Hinh.Size = new System.Drawing.Size(54, 22);
            this.lbl_Hinh.TabIndex = 6;
            this.lbl_Hinh.Text = "Hình:";
            // 
            // lbl_dongia
            // 
            this.lbl_dongia.AutoSize = true;
            this.lbl_dongia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dongia.Location = new System.Drawing.Point(431, 5);
            this.lbl_dongia.Name = "lbl_dongia";
            this.lbl_dongia.Size = new System.Drawing.Size(79, 22);
            this.lbl_dongia.TabIndex = 3;
            this.lbl_dongia.Text = "Đơn giá:";
            // 
            // lbl_donvi
            // 
            this.lbl_donvi.AutoSize = true;
            this.lbl_donvi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donvi.Location = new System.Drawing.Point(4, 109);
            this.lbl_donvi.Name = "lbl_donvi";
            this.lbl_donvi.Size = new System.Drawing.Size(105, 22);
            this.lbl_donvi.TabIndex = 5;
            this.lbl_donvi.Text = "Đơn vị tính:";
            // 
            // lbl_tensp
            // 
            this.lbl_tensp.AutoSize = true;
            this.lbl_tensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensp.Location = new System.Drawing.Point(5, 63);
            this.lbl_tensp.Name = "lbl_tensp";
            this.lbl_tensp.Size = new System.Drawing.Size(124, 22);
            this.lbl_tensp.TabIndex = 4;
            this.lbl_tensp.Text = "Tên sản phẩm:";
            // 
            // lbl_masp
            // 
            this.lbl_masp.AutoSize = true;
            this.lbl_masp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masp.Location = new System.Drawing.Point(4, 5);
            this.lbl_masp.Name = "lbl_masp";
            this.lbl_masp.Size = new System.Drawing.Size(125, 22);
            this.lbl_masp.TabIndex = 3;
            this.lbl_masp.Text = "Mã sản phẩm: ";
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(66, 188);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_reload.Size = new System.Drawing.Size(90, 56);
            this.btn_reload.TabIndex = 4;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(309, 188);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 56);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(540, 188);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 56);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(66, 250);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_luu.Size = new System.Drawing.Size(90, 56);
            this.btn_luu.TabIndex = 7;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.Location = new System.Drawing.Point(309, 250);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_huybo.Size = new System.Drawing.Size(95, 56);
            this.btn_huybo.TabIndex = 8;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.UseVisualStyleBackColor = true;
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(540, 250);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_xoa.Size = new System.Drawing.Size(92, 56);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(716, 250);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(95, 56);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Location = new System.Drawing.Point(27, 312);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.RowHeadersWidth = 51;
            this.dgvsanpham.RowTemplate.Height = 24;
            this.dgvsanpham.Size = new System.Drawing.Size(839, 217);
            this.dgvsanpham.TabIndex = 12;
            // 
            // btn_chonanh
            // 
            this.btn_chonanh.Location = new System.Drawing.Point(716, 188);
            this.btn_chonanh.Name = "btn_chonanh";
            this.btn_chonanh.Size = new System.Drawing.Size(95, 56);
            this.btn_chonanh.TabIndex = 13;
            this.btn_chonanh.Text = "Chọn ảnh";
            this.btn_chonanh.UseVisualStyleBackColor = true;
            this.btn_chonanh.Click += new System.EventHandler(this.btn_chonanh_Click);
            // 
            // Danhmucsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 541);
            this.Controls.Add(this.btn_chonanh);
            this.Controls.Add(this.dgvsanpham);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.panel1);
            this.Name = "Danhmucsanpham";
            this.Text = "Danhmucsanpham";
            this.Load += new System.EventHandler(this.Danhmucsanpham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_dongia;
        private System.Windows.Forms.Label lbl_donvi;
        private System.Windows.Forms.Label lbl_tensp;
        private System.Windows.Forms.Label lbl_masp;
        private System.Windows.Forms.Label lbl_Hinh;
        private System.Windows.Forms.ComboBox cmb_donvi;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.PictureBox pic_Hinh;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huybo;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.Button btn_chonanh;
    }
}