using DoAnWinform.Form_Admin;
using System;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
            if (TaiKhoan.Cap == 3)
            {
                btn_qltk.Enabled = false;
                btn_doanhthu.Enabled = false;
                btn_qltk.Visible = false;
                btn_doanhthu.Visible = false;
                btn_nxb.Enabled = false;
            }
        }
        //-----------------------------------------------------
        // Click to change to other form
        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            Form form = new Admin_Home();
            this.Hide();
            form.Show();
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            Form form = new admin_Sach();
            this.Hide();
            form.Show();
        }

        private void btn_tacgia_Click(object sender, EventArgs e)
        {
            Form form = new admin_TacGia();
            this.Hide();
            form.Show();
        }
        private void btn_phieunhap_Click(object sender, EventArgs e)
        {
            Form form = new admin_phieunhap();
            this.Hide();
            form.Show();
        }

        private void btn_ctphieunhap_Click(object sender, EventArgs e)
        {
            Form form = new admin_CTPhieuNhap();
            this.Hide();
            form.Show();
        }


        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new form_dangnhap();
            form.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            Form form = new Form_DoanhThu();
            form.Show();
        }
        private void btn_nxb_Click(object sender, EventArgs e)
        {
            Form form = new admin_NXB();
            this.Hide();
            form.Show();
        }

        private void btn_qltk_Click(object sender, EventArgs e)
        {
            Form form = new Form_QLTaiKhoan();
            this.Hide();
            form.Show();
        }
    }
}
