namespace DoAnWinform.Form_Admin
{
    partial class Form_DoanhThu
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_doanhthu = new System.Windows.Forms.DataGridView();
            this.col_mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tonghd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_dtngay = new System.Windows.Forms.Button();
            this.btn_dtthang = new System.Windows.Forms.Button();
            this.btn_dtnam = new System.Windows.Forms.Button();
            this.txt_tongdoanhthu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ngay = new System.Windows.Forms.ComboBox();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(766, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(79, 58);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "X";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "THỐNG KÊ DOANH THU";
            // 
            // dg_doanhthu
            // 
            this.dg_doanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_doanhthu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_doanhthu.BackgroundColor = System.Drawing.Color.White;
            this.dg_doanhthu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dg_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_doanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_mahd,
            this.col_nam,
            this.col_thang,
            this.col_ngay,
            this.col_tonghd});
            this.dg_doanhthu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_doanhthu.GridColor = System.Drawing.Color.White;
            this.dg_doanhthu.Location = new System.Drawing.Point(0, 326);
            this.dg_doanhthu.Name = "dg_doanhthu";
            this.dg_doanhthu.ReadOnly = true;
            this.dg_doanhthu.RowHeadersWidth = 51;
            this.dg_doanhthu.RowTemplate.Height = 24;
            this.dg_doanhthu.Size = new System.Drawing.Size(857, 198);
            this.dg_doanhthu.TabIndex = 3;
            this.dg_doanhthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_doanhthu_CellClick);
            // 
            // col_mahd
            // 
            this.col_mahd.DataPropertyName = "MaHD";
            this.col_mahd.HeaderText = "Mã HĐ";
            this.col_mahd.MinimumWidth = 6;
            this.col_mahd.Name = "col_mahd";
            this.col_mahd.ReadOnly = true;
            // 
            // col_nam
            // 
            this.col_nam.DataPropertyName = "Nam";
            this.col_nam.HeaderText = "Năm";
            this.col_nam.MinimumWidth = 6;
            this.col_nam.Name = "col_nam";
            this.col_nam.ReadOnly = true;
            // 
            // col_thang
            // 
            this.col_thang.DataPropertyName = "Thang";
            this.col_thang.HeaderText = "Tháng";
            this.col_thang.MinimumWidth = 6;
            this.col_thang.Name = "col_thang";
            this.col_thang.ReadOnly = true;
            // 
            // col_ngay
            // 
            this.col_ngay.DataPropertyName = "Ngay";
            this.col_ngay.HeaderText = "Ngày";
            this.col_ngay.MinimumWidth = 6;
            this.col_ngay.Name = "col_ngay";
            this.col_ngay.ReadOnly = true;
            // 
            // col_tonghd
            // 
            this.col_tonghd.DataPropertyName = "TongHD";
            this.col_tonghd.HeaderText = "Tổng HĐ";
            this.col_tonghd.MinimumWidth = 6;
            this.col_tonghd.Name = "col_tonghd";
            this.col_tonghd.ReadOnly = true;
            // 
            // btn_dtngay
            // 
            this.btn_dtngay.BackColor = System.Drawing.Color.Transparent;
            this.btn_dtngay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_dtngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dtngay.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_dtngay.Location = new System.Drawing.Point(12, 246);
            this.btn_dtngay.Name = "btn_dtngay";
            this.btn_dtngay.Size = new System.Drawing.Size(131, 39);
            this.btn_dtngay.TabIndex = 81;
            this.btn_dtngay.Text = "Doanh thu ngày";
            this.btn_dtngay.UseVisualStyleBackColor = false;
            this.btn_dtngay.Click += new System.EventHandler(this.btn_dtngay_Click);
            // 
            // btn_dtthang
            // 
            this.btn_dtthang.BackColor = System.Drawing.Color.Transparent;
            this.btn_dtthang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_dtthang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dtthang.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtthang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_dtthang.Location = new System.Drawing.Point(162, 246);
            this.btn_dtthang.Name = "btn_dtthang";
            this.btn_dtthang.Size = new System.Drawing.Size(131, 39);
            this.btn_dtthang.TabIndex = 82;
            this.btn_dtthang.Text = "Doanh thu tháng";
            this.btn_dtthang.UseVisualStyleBackColor = false;
            this.btn_dtthang.Click += new System.EventHandler(this.btn_dtthang_Click);
            // 
            // btn_dtnam
            // 
            this.btn_dtnam.BackColor = System.Drawing.Color.Transparent;
            this.btn_dtnam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_dtnam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dtnam.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtnam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_dtnam.Location = new System.Drawing.Point(311, 246);
            this.btn_dtnam.Name = "btn_dtnam";
            this.btn_dtnam.Size = new System.Drawing.Size(131, 39);
            this.btn_dtnam.TabIndex = 83;
            this.btn_dtnam.Text = "Doanh thu năm";
            this.btn_dtnam.UseVisualStyleBackColor = false;
            this.btn_dtnam.Click += new System.EventHandler(this.btn_dtnam_Click);
            // 
            // txt_tongdoanhthu
            // 
            this.txt_tongdoanhthu.Location = new System.Drawing.Point(659, 259);
            this.txt_tongdoanhthu.Multiline = true;
            this.txt_tongdoanhthu.Name = "txt_tongdoanhthu";
            this.txt_tongdoanhthu.ReadOnly = true;
            this.txt_tongdoanhthu.Size = new System.Drawing.Size(169, 26);
            this.txt_tongdoanhthu.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tổng doanh thu";
            // 
            // cb_ngay
            // 
            this.cb_ngay.FormattingEnabled = true;
            this.cb_ngay.Location = new System.Drawing.Point(12, 190);
            this.cb_ngay.Name = "cb_ngay";
            this.cb_ngay.Size = new System.Drawing.Size(131, 24);
            this.cb_ngay.TabIndex = 86;
            this.cb_ngay.Text = "Ngày";
            this.cb_ngay.SelectedIndexChanged += new System.EventHandler(this.cb_ngay_SelectedIndexChanged);
            // 
            // cb_thang
            // 
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(162, 190);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(131, 24);
            this.cb_thang.TabIndex = 86;
            this.cb_thang.Text = "Tháng";
            this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged);
            // 
            // cb_nam
            // 
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Location = new System.Drawing.Point(311, 190);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(131, 24);
            this.cb_nam.TabIndex = 86;
            this.cb_nam.Text = "Năm";
            this.cb_nam.SelectedIndexChanged += new System.EventHandler(this.cb_nam_SelectedIndexChanged);
            // 
            // Form_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 524);
            this.ControlBox = false;
            this.Controls.Add(this.cb_nam);
            this.Controls.Add(this.cb_thang);
            this.Controls.Add(this.cb_ngay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tongdoanhthu);
            this.Controls.Add(this.btn_dtnam);
            this.Controls.Add(this.btn_dtthang);
            this.Controls.Add(this.btn_dtngay);
            this.Controls.Add(this.dg_doanhthu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.Form_DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_doanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_doanhthu;
        private System.Windows.Forms.Button btn_dtngay;
        private System.Windows.Forms.Button btn_dtthang;
        private System.Windows.Forms.Button btn_dtnam;
        private System.Windows.Forms.TextBox txt_tongdoanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ngay;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tonghd;
    }
}