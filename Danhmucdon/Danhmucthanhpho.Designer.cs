namespace Quanlybanhang.Danhmucdon
{
    partial class Danhmucthanhpho
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
            this.txt_tentp = new System.Windows.Forms.TextBox();
            this.txt_thanhpho = new System.Windows.Forms.TextBox();
            this.lbl_tenpho = new System.Windows.Forms.Label();
            this.lbl_thanhpho = new System.Windows.Forms.Label();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btn_luu1 = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvthanhpho = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthanhpho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_tentp);
            this.panel1.Controls.Add(this.txt_thanhpho);
            this.panel1.Controls.Add(this.lbl_tenpho);
            this.panel1.Controls.Add(this.lbl_thanhpho);
            this.panel1.Location = new System.Drawing.Point(26, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 133);
            this.panel1.TabIndex = 0;
            // 
            // txt_tentp
            // 
            this.txt_tentp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_tentp.Location = new System.Drawing.Point(166, 79);
            this.txt_tentp.Multiline = true;
            this.txt_tentp.Name = "txt_tentp";
            this.txt_tentp.Size = new System.Drawing.Size(198, 29);
            this.txt_tentp.TabIndex = 3;
            // 
            // txt_thanhpho
            // 
            this.txt_thanhpho.Location = new System.Drawing.Point(166, 20);
            this.txt_thanhpho.Multiline = true;
            this.txt_thanhpho.Name = "txt_thanhpho";
            this.txt_thanhpho.Size = new System.Drawing.Size(149, 33);
            this.txt_thanhpho.TabIndex = 2;
            // 
            // lbl_tenpho
            // 
            this.lbl_tenpho.AutoSize = true;
            this.lbl_tenpho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenpho.Location = new System.Drawing.Point(10, 78);
            this.lbl_tenpho.Name = "lbl_tenpho";
            this.lbl_tenpho.Size = new System.Drawing.Size(128, 22);
            this.lbl_tenpho.TabIndex = 1;
            this.lbl_tenpho.Text = "Tên Thành Phố";
            // 
            // lbl_thanhpho
            // 
            this.lbl_thanhpho.AutoSize = true;
            this.lbl_thanhpho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thanhpho.Location = new System.Drawing.Point(10, 20);
            this.lbl_thanhpho.Name = "lbl_thanhpho";
            this.lbl_thanhpho.Size = new System.Drawing.Size(93, 22);
            this.lbl_thanhpho.TabIndex = 0;
            this.lbl_thanhpho.Text = "Thành Phố";
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(40, 149);
            this.btnreload.Name = "btnreload";
            this.btnreload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnreload.Size = new System.Drawing.Size(79, 37);
            this.btnreload.TabIndex = 1;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(201, 149);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(79, 37);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(387, 149);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(79, 37);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btn_luu1
            // 
            this.btn_luu1.Location = new System.Drawing.Point(40, 209);
            this.btn_luu1.Name = "btn_luu1";
            this.btn_luu1.Size = new System.Drawing.Size(79, 37);
            this.btn_luu1.TabIndex = 4;
            this.btn_luu1.Text = "Lưu";
            this.btn_luu1.UseVisualStyleBackColor = true;
            this.btn_luu1.Click += new System.EventHandler(this.btn_luu1_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(201, 209);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(79, 37);
            this.btn_huy.TabIndex = 5;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(387, 209);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(79, 37);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvthanhpho
            // 
            this.dgvthanhpho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthanhpho.Location = new System.Drawing.Point(26, 252);
            this.dgvthanhpho.Name = "dgvthanhpho";
            this.dgvthanhpho.RowHeadersWidth = 51;
            this.dgvthanhpho.RowTemplate.Height = 24;
            this.dgvthanhpho.Size = new System.Drawing.Size(461, 138);
            this.dgvthanhpho.TabIndex = 7;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(201, 401);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnthoat.Size = new System.Drawing.Size(79, 37);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Danhmucthanhpho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvthanhpho);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu1);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.panel1);
            this.Name = "Danhmucthanhpho";
            this.Text = "Danhmucthanhpho";
            this.Load += new System.EventHandler(this.Danhmucthanhpho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthanhpho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_tenpho;
        private System.Windows.Forms.Label lbl_thanhpho;
        private System.Windows.Forms.TextBox txt_tentp;
        private System.Windows.Forms.TextBox txt_thanhpho;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btn_luu1;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvthanhpho;
        private System.Windows.Forms.Button btnthoat;
    }
}