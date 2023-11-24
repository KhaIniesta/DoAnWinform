namespace DoAnWinform.Form_Staff
{
    partial class staff_hoadon
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.col_masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tentg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_soluongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_slban = new System.Windows.Forms.TextBox();
            this.txt_theloai = new System.Windows.Forms.TextBox();
            this.lbl_gia = new System.Windows.Forms.Label();
            this.lbl_tensach = new System.Windows.Forms.Label();
            this.lbl_theloai = new System.Windows.Forms.Label();
            this.lbl_manxb = new System.Windows.Forms.Label();
            this.lbl_soluongsach = new System.Windows.Forms.Label();
            this.lbl_matacgia = new System.Windows.Forms.Label();
            this.lbl_masach = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_tensach = new System.Windows.Forms.ComboBox();
            this.cb_mahd = new System.Windows.Forms.ComboBox();
            this.txt_tentacgia = new System.Windows.Forms.TextBox();
            this.txt_tennxb = new System.Windows.Forms.TextBox();
            this.lbl_mahd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_anh = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_tonghd = new System.Windows.Forms.Label();
            this.txt_tonghd = new System.Windows.Forms.TextBox();
            this.btn_huyhd = new System.Windows.Forms.Button();
            this.btn_xuathd = new DoAnWinform.Custom_Item.RoundButton();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chitiethoadon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 114);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(518, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "HÓA ĐƠN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_chitiethoadon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1212, 373);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // dtg_chitiethoadon
            // 
            this.dtg_chitiethoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_chitiethoadon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_chitiethoadon.BackgroundColor = System.Drawing.Color.White;
            this.dtg_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_chitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_masach,
            this.col_mahd,
            this.col_tentg,
            this.col_tennxb,
            this.col_theloai,
            this.col_soluongban,
            this.col_gia,
            this.col_tensach,
            this.col_anh});
            this.dtg_chitiethoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_chitiethoadon.Location = new System.Drawing.Point(3, 35);
            this.dtg_chitiethoadon.Name = "dtg_chitiethoadon";
            this.dtg_chitiethoadon.RowHeadersWidth = 51;
            this.dtg_chitiethoadon.RowTemplate.Height = 24;
            this.dtg_chitiethoadon.Size = new System.Drawing.Size(1206, 335);
            this.dtg_chitiethoadon.TabIndex = 2;
            this.dtg_chitiethoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_chitiethoadon_CellClick);
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
            // btn_xoa
            // 
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Roboto Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_xoa.Location = new System.Drawing.Point(1029, 260);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(131, 39);
            this.btn_xoa.TabIndex = 94;
            this.btn_xoa.Text = "Xóa sách";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Roboto Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_capnhat.Location = new System.Drawing.Point(1029, 205);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(131, 39);
            this.btn_capnhat.TabIndex = 93;
            this.btn_capnhat.Text = "Cập nhật sách";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Roboto Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_them.Location = new System.Drawing.Point(1029, 147);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(131, 39);
            this.btn_them.TabIndex = 92;
            this.btn_them.Text = "Thêm sách";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_gia
            // 
            this.txt_gia.BackColor = System.Drawing.Color.White;
            this.txt_gia.Location = new System.Drawing.Point(488, 276);
            this.txt_gia.Multiline = true;
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.ReadOnly = true;
            this.txt_gia.Size = new System.Drawing.Size(191, 27);
            this.txt_gia.TabIndex = 104;
            // 
            // txt_slban
            // 
            this.txt_slban.BackColor = System.Drawing.SystemColors.Window;
            this.txt_slban.Location = new System.Drawing.Point(488, 217);
            this.txt_slban.Multiline = true;
            this.txt_slban.Name = "txt_slban";
            this.txt_slban.Size = new System.Drawing.Size(191, 27);
            this.txt_slban.TabIndex = 103;
            // 
            // txt_theloai
            // 
            this.txt_theloai.BackColor = System.Drawing.SystemColors.Window;
            this.txt_theloai.Location = new System.Drawing.Point(488, 162);
            this.txt_theloai.Multiline = true;
            this.txt_theloai.Name = "txt_theloai";
            this.txt_theloai.ReadOnly = true;
            this.txt_theloai.Size = new System.Drawing.Size(191, 27);
            this.txt_theloai.TabIndex = 102;
            // 
            // lbl_gia
            // 
            this.lbl_gia.AutoSize = true;
            this.lbl_gia.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia.Location = new System.Drawing.Point(381, 281);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(42, 20);
            this.lbl_gia.TabIndex = 100;
            this.lbl_gia.Text = "Giá :";
            // 
            // lbl_tensach
            // 
            this.lbl_tensach.AutoSize = true;
            this.lbl_tensach.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensach.Location = new System.Drawing.Point(28, 380);
            this.lbl_tensach.Name = "lbl_tensach";
            this.lbl_tensach.Size = new System.Drawing.Size(85, 20);
            this.lbl_tensach.TabIndex = 99;
            this.lbl_tensach.Text = "Tên Sách :";
            // 
            // lbl_theloai
            // 
            this.lbl_theloai.AutoSize = true;
            this.lbl_theloai.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_theloai.Location = new System.Drawing.Point(381, 166);
            this.lbl_theloai.Name = "lbl_theloai";
            this.lbl_theloai.Size = new System.Drawing.Size(76, 20);
            this.lbl_theloai.TabIndex = 98;
            this.lbl_theloai.Text = "Thể loại :";
            // 
            // lbl_manxb
            // 
            this.lbl_manxb.AutoSize = true;
            this.lbl_manxb.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manxb.Location = new System.Drawing.Point(9, 190);
            this.lbl_manxb.Name = "lbl_manxb";
            this.lbl_manxb.Size = new System.Drawing.Size(82, 20);
            this.lbl_manxb.TabIndex = 96;
            this.lbl_manxb.Text = "Tên NXB :";
            // 
            // lbl_soluongsach
            // 
            this.lbl_soluongsach.AutoSize = true;
            this.lbl_soluongsach.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluongsach.Location = new System.Drawing.Point(381, 221);
            this.lbl_soluongsach.Name = "lbl_soluongsach";
            this.lbl_soluongsach.Size = new System.Drawing.Size(69, 20);
            this.lbl_soluongsach.TabIndex = 97;
            this.lbl_soluongsach.Text = "SL Bán :";
            // 
            // lbl_matacgia
            // 
            this.lbl_matacgia.AutoSize = true;
            this.lbl_matacgia.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matacgia.Location = new System.Drawing.Point(9, 135);
            this.lbl_matacgia.Name = "lbl_matacgia";
            this.lbl_matacgia.Size = new System.Drawing.Size(104, 20);
            this.lbl_matacgia.TabIndex = 101;
            this.lbl_matacgia.Text = "Tên Tác Giả :";
            // 
            // lbl_masach
            // 
            this.lbl_masach.AutoSize = true;
            this.lbl_masach.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masach.Location = new System.Drawing.Point(28, 167);
            this.lbl_masach.Name = "lbl_masach";
            this.lbl_masach.Size = new System.Drawing.Size(82, 20);
            this.lbl_masach.TabIndex = 95;
            this.lbl_masach.Text = "Mã Sách :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_tensach);
            this.groupBox2.Controls.Add(this.cb_mahd);
            this.groupBox2.Controls.Add(this.txt_tentacgia);
            this.groupBox2.Controls.Add(this.txt_tennxb);
            this.groupBox2.Controls.Add(this.lbl_matacgia);
            this.groupBox2.Controls.Add(this.lbl_manxb);
            this.groupBox2.Controls.Add(this.txt_masach);
            this.groupBox2.Controls.Add(this.lbl_mahd);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 300);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // cb_tensach
            // 
            this.cb_tensach.FormattingEnabled = true;
            this.cb_tensach.Location = new System.Drawing.Point(136, 237);
            this.cb_tensach.Name = "cb_tensach";
            this.cb_tensach.Size = new System.Drawing.Size(524, 26);
            this.cb_tensach.TabIndex = 108;
            this.cb_tensach.SelectedIndexChanged += new System.EventHandler(this.cb_tensach_SelectedIndexChanged);
            // 
            // cb_mahd
            // 
            this.cb_mahd.FormattingEnabled = true;
            this.cb_mahd.Location = new System.Drawing.Point(136, 83);
            this.cb_mahd.Name = "cb_mahd";
            this.cb_mahd.Size = new System.Drawing.Size(191, 26);
            this.cb_mahd.TabIndex = 108;
            this.cb_mahd.SelectedIndexChanged += new System.EventHandler(this.cb_mahd_SelectedIndexChanged);
            // 
            // txt_tentacgia
            // 
            this.txt_tentacgia.BackColor = System.Drawing.Color.White;
            this.txt_tentacgia.Location = new System.Drawing.Point(136, 131);
            this.txt_tentacgia.Multiline = true;
            this.txt_tentacgia.Name = "txt_tentacgia";
            this.txt_tentacgia.ReadOnly = true;
            this.txt_tentacgia.Size = new System.Drawing.Size(191, 27);
            this.txt_tentacgia.TabIndex = 103;
            // 
            // txt_tennxb
            // 
            this.txt_tennxb.BackColor = System.Drawing.Color.White;
            this.txt_tennxb.Location = new System.Drawing.Point(136, 183);
            this.txt_tennxb.Multiline = true;
            this.txt_tennxb.Name = "txt_tennxb";
            this.txt_tennxb.ReadOnly = true;
            this.txt_tennxb.Size = new System.Drawing.Size(191, 27);
            this.txt_tennxb.TabIndex = 103;
            // 
            // lbl_mahd
            // 
            this.lbl_mahd.AutoSize = true;
            this.lbl_mahd.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mahd.Location = new System.Drawing.Point(9, 84);
            this.lbl_mahd.Name = "lbl_mahd";
            this.lbl_mahd.Size = new System.Drawing.Size(68, 20);
            this.lbl_mahd.TabIndex = 101;
            this.lbl_mahd.Text = "Mã HĐ :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_anh);
            this.groupBox1.Location = new System.Drawing.Point(744, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 248);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            // 
            // pb_anh
            // 
            this.pb_anh.Location = new System.Drawing.Point(6, 17);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(215, 221);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anh.TabIndex = 3;
            this.pb_anh.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Roboto Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_thoat.Location = new System.Drawing.Point(1029, 364);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(131, 39);
            this.btn_thoat.TabIndex = 94;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_tonghd
            // 
            this.lbl_tonghd.AutoSize = true;
            this.lbl_tonghd.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tonghd.Location = new System.Drawing.Point(740, 416);
            this.lbl_tonghd.Name = "lbl_tonghd";
            this.lbl_tonghd.Size = new System.Drawing.Size(82, 20);
            this.lbl_tonghd.TabIndex = 99;
            this.lbl_tonghd.Text = "Tổng HĐ :";
            // 
            // txt_tonghd
            // 
            this.txt_tonghd.BackColor = System.Drawing.Color.White;
            this.txt_tonghd.Location = new System.Drawing.Point(839, 410);
            this.txt_tonghd.Multiline = true;
            this.txt_tonghd.Name = "txt_tonghd";
            this.txt_tonghd.ReadOnly = true;
            this.txt_tonghd.Size = new System.Drawing.Size(130, 27);
            this.txt_tonghd.TabIndex = 103;
            // 
            // btn_huyhd
            // 
            this.btn_huyhd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.btn_huyhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huyhd.Font = new System.Drawing.Font("Roboto Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huyhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_huyhd.Location = new System.Drawing.Point(1029, 312);
            this.btn_huyhd.Name = "btn_huyhd";
            this.btn_huyhd.Size = new System.Drawing.Size(131, 39);
            this.btn_huyhd.TabIndex = 112;
            this.btn_huyhd.Text = "Hủy HĐ";
            this.btn_huyhd.UseVisualStyleBackColor = true;
            this.btn_huyhd.Click += new System.EventHandler(this.btn_huyhd_Click);
            // 
            // btn_xuathd
            // 
            this.btn_xuathd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.btn_xuathd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(66)))));
            this.btn_xuathd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xuathd.BorderRadius = 20;
            this.btn_xuathd.BorderSize = 0;
            this.btn_xuathd.FlatAppearance.BorderSize = 0;
            this.btn_xuathd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xuathd.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuathd.ForeColor = System.Drawing.Color.White;
            this.btn_xuathd.Image = global::DoAnWinform.Properties.Resources.Arrow32;
            this.btn_xuathd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xuathd.Location = new System.Drawing.Point(1049, 416);
            this.btn_xuathd.Name = "btn_xuathd";
            this.btn_xuathd.Size = new System.Drawing.Size(151, 48);
            this.btn_xuathd.TabIndex = 111;
            this.btn_xuathd.Text = "Xuất HĐ";
            this.btn_xuathd.TextColor = System.Drawing.Color.White;
            this.btn_xuathd.UseVisualStyleBackColor = false;
            this.btn_xuathd.Click += new System.EventHandler(this.btn_xuathd_Click);
            // 
            // txt_masach
            // 
            this.txt_masach.BackColor = System.Drawing.SystemColors.Window;
            this.txt_masach.Location = new System.Drawing.Point(136, 25);
            this.txt_masach.Multiline = true;
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.ReadOnly = true;
            this.txt_masach.Size = new System.Drawing.Size(191, 27);
            this.txt_masach.TabIndex = 102;
            // 
            // staff_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 843);
            this.ControlBox = false;
            this.Controls.Add(this.btn_huyhd);
            this.Controls.Add(this.btn_xuathd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_tonghd);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_slban);
            this.Controls.Add(this.txt_theloai);
            this.Controls.Add(this.lbl_gia);
            this.Controls.Add(this.lbl_tonghd);
            this.Controls.Add(this.lbl_tensach);
            this.Controls.Add(this.lbl_theloai);
            this.Controls.Add(this.lbl_soluongsach);
            this.Controls.Add(this.lbl_masach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff_hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staff_hoadon";
            this.Load += new System.EventHandler(this.staff_hoadon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chitiethoadon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtg_chitiethoadon;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_slban;
        private System.Windows.Forms.TextBox txt_theloai;
        private System.Windows.Forms.Label lbl_gia;
        private System.Windows.Forms.Label lbl_tensach;
        private System.Windows.Forms.Label lbl_theloai;
        private System.Windows.Forms.Label lbl_manxb;
        private System.Windows.Forms.Label lbl_soluongsach;
        private System.Windows.Forms.Label lbl_matacgia;
        private System.Windows.Forms.Label lbl_masach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_mahd;
        private System.Windows.Forms.ComboBox cb_mahd;
        private System.Windows.Forms.TextBox txt_tennxb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_anh;
        private System.Windows.Forms.TextBox txt_tentacgia;
        private Custom_Item.RoundButton btn_xuathd;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_tonghd;
        private System.Windows.Forms.TextBox txt_tonghd;
        private System.Windows.Forms.Button btn_huyhd;
        private System.Windows.Forms.ComboBox cb_tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tentg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tennxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soluongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_anh;
        private System.Windows.Forms.TextBox txt_masach;
    }
}