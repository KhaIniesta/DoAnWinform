namespace DoAnWinform.Form_Admin
{
    partial class Form_CTHD
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
            this.dg_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.col_masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tentg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_soluongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cthd = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_chitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_chitiethoadon
            // 
            this.dg_chitiethoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_chitiethoadon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_chitiethoadon.BackgroundColor = System.Drawing.Color.White;
            this.dg_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_chitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_masach,
            this.col_mahd,
            this.col_tentg,
            this.col_tennxb,
            this.col_theloai,
            this.col_soluongban,
            this.col_gia,
            this.col_tensach,
            this.col_anh});
            this.dg_chitiethoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_chitiethoadon.Location = new System.Drawing.Point(0, 196);
            this.dg_chitiethoadon.Name = "dg_chitiethoadon";
            this.dg_chitiethoadon.RowHeadersWidth = 51;
            this.dg_chitiethoadon.RowTemplate.Height = 24;
            this.dg_chitiethoadon.Size = new System.Drawing.Size(982, 557);
            this.dg_chitiethoadon.TabIndex = 4;
            // 
            // col_masach
            // 
            this.col_masach.DataPropertyName = "MaSach";
            this.col_masach.HeaderText = "Mã Sách";
            this.col_masach.MinimumWidth = 6;
            this.col_masach.Name = "col_masach";
            // 
            // col_mahd
            // 
            this.col_mahd.DataPropertyName = "MaHD";
            this.col_mahd.HeaderText = "Mã HĐ";
            this.col_mahd.MinimumWidth = 6;
            this.col_mahd.Name = "col_mahd";
            // 
            // col_tentg
            // 
            this.col_tentg.DataPropertyName = "TenTG";
            this.col_tentg.HeaderText = "Tên TG";
            this.col_tentg.MinimumWidth = 6;
            this.col_tentg.Name = "col_tentg";
            // 
            // col_tennxb
            // 
            this.col_tennxb.DataPropertyName = "TenNXB";
            this.col_tennxb.HeaderText = "Tên NXB";
            this.col_tennxb.MinimumWidth = 6;
            this.col_tennxb.Name = "col_tennxb";
            // 
            // col_theloai
            // 
            this.col_theloai.DataPropertyName = "TheLoai";
            this.col_theloai.HeaderText = "Thể Loại";
            this.col_theloai.MinimumWidth = 6;
            this.col_theloai.Name = "col_theloai";
            // 
            // col_soluongban
            // 
            this.col_soluongban.DataPropertyName = "SoLuongBan";
            this.col_soluongban.HeaderText = "SL Bán";
            this.col_soluongban.MinimumWidth = 6;
            this.col_soluongban.Name = "col_soluongban";
            // 
            // col_gia
            // 
            this.col_gia.DataPropertyName = "Gia";
            this.col_gia.HeaderText = "Giá";
            this.col_gia.MinimumWidth = 6;
            this.col_gia.Name = "col_gia";
            // 
            // col_tensach
            // 
            this.col_tensach.DataPropertyName = "TenSach";
            this.col_tensach.HeaderText = "Tên Sách";
            this.col_tensach.MinimumWidth = 6;
            this.col_tensach.Name = "col_tensach";
            // 
            // col_anh
            // 
            this.col_anh.DataPropertyName = "Anh";
            this.col_anh.HeaderText = "Ảnh";
            this.col_anh.MinimumWidth = 6;
            this.col_anh.Name = "col_anh";
            this.col_anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_anh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lbl_cthd
            // 
            this.lbl_cthd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cthd.AutoSize = true;
            this.lbl_cthd.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cthd.Location = new System.Drawing.Point(343, 14);
            this.lbl_cthd.Name = "lbl_cthd";
            this.lbl_cthd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_cthd.Size = new System.Drawing.Size(299, 39);
            this.lbl_cthd.TabIndex = 3;
            this.lbl_cthd.Text = "CHI TIẾT HÓA ĐƠN";
            this.lbl_cthd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(891, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_thoat.Size = new System.Drawing.Size(79, 58);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "X";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Form_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.ControlBox = false;
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dg_chitiethoadon);
            this.Controls.Add(this.lbl_cthd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_CTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.Form_CTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_chitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_chitiethoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tentg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tennxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soluongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_anh;
        private System.Windows.Forms.Label lbl_cthd;
        private System.Windows.Forms.Button btn_thoat;
    }
}