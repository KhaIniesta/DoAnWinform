namespace DoAnWinform
{
    partial class form_dangnhap
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
            this.lbl_thoat = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dangnhap = new DoAnWinform.Custom_Item.RoundButton();
            this.txt_matkhau = new CustomControls.RJControls.RJTextBox();
            this.txt_tendn = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_thoat
            // 
            this.lbl_thoat.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_thoat.AutoSize = true;
            this.lbl_thoat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thoat.LinkColor = System.Drawing.Color.Black;
            this.lbl_thoat.Location = new System.Drawing.Point(213, 534);
            this.lbl_thoat.Name = "lbl_thoat";
            this.lbl_thoat.Size = new System.Drawing.Size(51, 18);
            this.lbl_thoat.TabIndex = 2;
            this.lbl_thoat.TabStop = true;
            this.lbl_thoat.Text = "Thoát";
            this.lbl_thoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_thoat_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnWinform.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(84, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DoAnWinform.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(84, 350);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(146, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnWinform.Properties.Resources.BookstoreLogo150;
            this.pictureBox1.Location = new System.Drawing.Point(141, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dangnhap.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dangnhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangnhap.BorderRadius = 20;
            this.btn_dangnhap.BorderSize = 0;
            this.btn_dangnhap.FlatAppearance.BorderSize = 0;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Location = new System.Drawing.Point(166, 430);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(152, 47);
            this.btn_dangnhap.TabIndex = 7;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.TextColor = System.Drawing.Color.White;
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.SystemColors.Window;
            this.txt_matkhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_matkhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_matkhau.BorderRadius = 0;
            this.txt_matkhau.BorderSize = 2;
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_matkhau.Location = new System.Drawing.Point(145, 345);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matkhau.Multiline = false;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_matkhau.PasswordChar = true;
            this.txt_matkhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_matkhau.PlaceholderText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(246, 35);
            this.txt_matkhau.TabIndex = 3;
            this.txt_matkhau.Texts = "";
            this.txt_matkhau.UnderlinedStyle = false;
            // 
            // txt_tendn
            // 
            this.txt_tendn.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tendn.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_tendn.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tendn.BorderRadius = 0;
            this.txt_tendn.BorderSize = 2;
            this.txt_tendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tendn.Location = new System.Drawing.Point(144, 270);
            this.txt_tendn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendn.Multiline = false;
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tendn.PasswordChar = false;
            this.txt_tendn.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tendn.PlaceholderText = "";
            this.txt_tendn.Size = new System.Drawing.Size(247, 35);
            this.txt_tendn.TabIndex = 3;
            this.txt_tendn.Texts = "";
            this.txt_tendn.UnderlinedStyle = false;
            // 
            // form_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(487, 563);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendn);
            this.Controls.Add(this.lbl_thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Đăng Nhập";
            this.Load += new System.EventHandler(this.form_dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lbl_thoat;
        private CustomControls.RJControls.RJTextBox txt_tendn;
        private CustomControls.RJControls.RJTextBox txt_matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Custom_Item.RoundButton btn_dangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

