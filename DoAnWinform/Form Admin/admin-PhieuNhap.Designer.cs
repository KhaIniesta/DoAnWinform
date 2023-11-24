namespace DoAnWinform.Form_Admin
{
    partial class admin_phieunhap
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_phieunhap = new System.Windows.Forms.DataGridView();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_sach = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tacgia = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_nxb = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_phieunhap = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_ctphieunhap = new System.Windows.Forms.Button();
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
            this.lbl_matg = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.lbl_manxb = new System.Windows.Forms.Label();
            this.cb_maNxb = new System.Windows.Forms.ComboBox();
            this.lbl_soluongsach = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phieunhap)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_phieunhap);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(226, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(986, 424);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dtg_phieunhap
            // 
            this.dtg_phieunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_phieunhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg_phieunhap.BackgroundColor = System.Drawing.Color.White;
            this.dtg_phieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_phieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuNhap,
            this.MaNXB,
            this.NgayNhap});
            this.dtg_phieunhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_phieunhap.Location = new System.Drawing.Point(3, 27);
            this.dtg_phieunhap.Name = "dtg_phieunhap";
            this.dtg_phieunhap.RowHeadersWidth = 51;
            this.dtg_phieunhap.RowTemplate.Height = 24;
            this.dtg_phieunhap.Size = new System.Drawing.Size(980, 394);
            this.dtg_phieunhap.TabIndex = 2;
            this.dtg_phieunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_phieunhap_CellClick);
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.MaPhieuNhap.MinimumWidth = 6;
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.MinimumWidth = 6;
            this.MaNXB.Name = "MaNXB";
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Snow;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(-32, -9);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_dangxuat.Size = new System.Drawing.Size(269, 99);
            this.btn_dangxuat.TabIndex = 2;
            this.btn_dangxuat.Text = "Đăng Xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_thoat);
            this.panel10.Location = new System.Drawing.Point(3, 713);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(223, 75);
            this.panel10.TabIndex = 56;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(23)))));
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Snow;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(-33, -9);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_thoat.Size = new System.Drawing.Size(269, 99);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_dangxuat);
            this.panel9.Location = new System.Drawing.Point(3, 632);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(223, 75);
            this.panel9.TabIndex = 56;
            // 
            // btn_them
            // 
            this.btn_them.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_them.Location = new System.Drawing.Point(628, 374);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(131, 39);
            this.btn_them.TabIndex = 69;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_trangchu);
            this.panel5.Location = new System.Drawing.Point(3, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 77);
            this.panel5.TabIndex = 1;
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.ForeColor = System.Drawing.Color.Snow;
            this.btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.Location = new System.Drawing.Point(-28, -11);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_trangchu.Size = new System.Drawing.Size(269, 99);
            this.btn_trangchu.TabIndex = 2;
            this.btn_trangchu.Text = "Trang Chủ";
            this.btn_trangchu.UseVisualStyleBackColor = false;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_sach);
            this.panel6.Location = new System.Drawing.Point(3, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 77);
            this.panel6.TabIndex = 1;
            // 
            // btn_sach
            // 
            this.btn_sach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sach.ForeColor = System.Drawing.Color.Snow;
            this.btn_sach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sach.Location = new System.Drawing.Point(-30, -9);
            this.btn_sach.Name = "btn_sach";
            this.btn_sach.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_sach.Size = new System.Drawing.Size(269, 99);
            this.btn_sach.TabIndex = 2;
            this.btn_sach.Text = "Sách";
            this.btn_sach.UseVisualStyleBackColor = false;
            this.btn_sach.Click += new System.EventHandler(this.btn_sach_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_xoa.Location = new System.Drawing.Point(776, 374);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(131, 39);
            this.btn_xoa.TabIndex = 68;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.btn_capnhat.Location = new System.Drawing.Point(924, 374);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(131, 39);
            this.btn_capnhat.TabIndex = 67;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_luu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_luu.FlatAppearance.BorderSize = 0;
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(1069, 374);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(131, 39);
            this.btn_luu.TabIndex = 66;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_tacgia);
            this.panel1.Location = new System.Drawing.Point(3, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 77);
            this.panel1.TabIndex = 1;
            // 
            // btn_tacgia
            // 
            this.btn_tacgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_tacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tacgia.ForeColor = System.Drawing.Color.Snow;
            this.btn_tacgia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tacgia.Location = new System.Drawing.Point(-29, -5);
            this.btn_tacgia.Name = "btn_tacgia";
            this.btn_tacgia.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_tacgia.Size = new System.Drawing.Size(269, 99);
            this.btn_tacgia.TabIndex = 2;
            this.btn_tacgia.Text = "Tác Giả";
            this.btn_tacgia.UseVisualStyleBackColor = false;
            this.btn_tacgia.Click += new System.EventHandler(this.btn_tacgia_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_nxb);
            this.panel7.Location = new System.Drawing.Point(3, 383);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 77);
            this.panel7.TabIndex = 1;
            // 
            // btn_nxb
            // 
            this.btn_nxb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_nxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nxb.ForeColor = System.Drawing.Color.Snow;
            this.btn_nxb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nxb.Location = new System.Drawing.Point(-30, -11);
            this.btn_nxb.Name = "btn_nxb";
            this.btn_nxb.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_nxb.Size = new System.Drawing.Size(269, 99);
            this.btn_nxb.TabIndex = 2;
            this.btn_nxb.Text = "NXB";
            this.btn_nxb.UseVisualStyleBackColor = false;
            this.btn_nxb.Click += new System.EventHandler(this.btn_nxb_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 843);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 119);
            this.panel2.TabIndex = 57;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnWinform.Properties.Resources.Bookstore_logo1201;
            this.pictureBox2.Location = new System.Drawing.Point(33, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_phieunhap);
            this.panel3.Location = new System.Drawing.Point(3, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 77);
            this.panel3.TabIndex = 1;
            // 
            // btn_phieunhap
            // 
            this.btn_phieunhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(77)))), ((int)(((byte)(19)))));
            this.btn_phieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phieunhap.ForeColor = System.Drawing.Color.Snow;
            this.btn_phieunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_phieunhap.Location = new System.Drawing.Point(-31, -11);
            this.btn_phieunhap.Name = "btn_phieunhap";
            this.btn_phieunhap.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_phieunhap.Size = new System.Drawing.Size(269, 99);
            this.btn_phieunhap.TabIndex = 2;
            this.btn_phieunhap.Text = "Phiếu Nhập";
            this.btn_phieunhap.UseVisualStyleBackColor = false;
            this.btn_phieunhap.Click += new System.EventHandler(this.btn_phieunhap_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_ctphieunhap);
            this.panel4.Location = new System.Drawing.Point(3, 549);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 77);
            this.panel4.TabIndex = 1;
            // 
            // btn_ctphieunhap
            // 
            this.btn_ctphieunhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.btn_ctphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ctphieunhap.ForeColor = System.Drawing.Color.Snow;
            this.btn_ctphieunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ctphieunhap.Location = new System.Drawing.Point(-31, -11);
            this.btn_ctphieunhap.Name = "btn_ctphieunhap";
            this.btn_ctphieunhap.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_ctphieunhap.Size = new System.Drawing.Size(269, 99);
            this.btn_ctphieunhap.TabIndex = 2;
            this.btn_ctphieunhap.Text = "CT Phiếu Nhập";
            this.btn_ctphieunhap.UseVisualStyleBackColor = false;
            this.btn_ctphieunhap.Click += new System.EventHandler(this.btn_ctphieunhap_Click);
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(244, 49);
            this.txt_maPhieuNhap.Multiline = true;
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(191, 27);
            this.txt_maPhieuNhap.TabIndex = 78;
            // 
            // lbl_matg
            // 
            this.lbl_matg.AutoSize = true;
            this.lbl_matg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matg.Location = new System.Drawing.Point(76, 56);
            this.lbl_matg.Name = "lbl_matg";
            this.lbl_matg.Size = new System.Drawing.Size(133, 20);
            this.lbl_matg.TabIndex = 77;
            this.lbl_matg.Text = "Mã Phiếu Nhập :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_ngayNhap);
            this.groupBox2.Controls.Add(this.lbl_matg);
            this.groupBox2.Controls.Add(this.txt_maPhieuNhap);
            this.groupBox2.Controls.Add(this.lbl_manxb);
            this.groupBox2.Controls.Add(this.cb_maNxb);
            this.groupBox2.Controls.Add(this.lbl_soluongsach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(402, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 234);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // dtp_ngayNhap
            // 
            this.dtp_ngayNhap.Location = new System.Drawing.Point(244, 152);
            this.dtp_ngayNhap.Name = "dtp_ngayNhap";
            this.dtp_ngayNhap.Size = new System.Drawing.Size(191, 24);
            this.dtp_ngayNhap.TabIndex = 79;
            // 
            // lbl_manxb
            // 
            this.lbl_manxb.AutoSize = true;
            this.lbl_manxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manxb.Location = new System.Drawing.Point(76, 106);
            this.lbl_manxb.Name = "lbl_manxb";
            this.lbl_manxb.Size = new System.Drawing.Size(82, 20);
            this.lbl_manxb.TabIndex = 64;
            this.lbl_manxb.Text = "Mã NXB :";
            // 
            // cb_maNxb
            // 
            this.cb_maNxb.FormattingEnabled = true;
            this.cb_maNxb.Location = new System.Drawing.Point(244, 99);
            this.cb_maNxb.Name = "cb_maNxb";
            this.cb_maNxb.Size = new System.Drawing.Size(191, 26);
            this.cb_maNxb.TabIndex = 74;
            // 
            // lbl_soluongsach
            // 
            this.lbl_soluongsach.AutoSize = true;
            this.lbl_soluongsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluongsach.Location = new System.Drawing.Point(76, 155);
            this.lbl_soluongsach.Name = "lbl_soluongsach";
            this.lbl_soluongsach.Size = new System.Drawing.Size(98, 20);
            this.lbl_soluongsach.TabIndex = 60;
            this.lbl_soluongsach.Text = "Ngày nhập :";
            // 
            // admin_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 843);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_phieunhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_phieunhap";
            this.Load += new System.EventHandler(this.admin_phieunhap_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phieunhap)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtg_phieunhap;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_trangchu;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_sach;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_tacgia;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_nxb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_phieunhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_ctphieunhap;
        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.Label lbl_matg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_ngayNhap;
        private System.Windows.Forms.Label lbl_manxb;
        private System.Windows.Forms.ComboBox cb_maNxb;
        private System.Windows.Forms.Label lbl_soluongsach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
    }
}