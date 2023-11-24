using DoAnWinform.Form_Staff;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class form_dangnhap : Form
    {
        private KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();
        private String dieuKhien = "trong";

        public form_dangnhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, System.EventArgs e)
        {
            // Người dùng có thể quay lại đăng nhập từ một user khác admin, khi đó cần khôi phục lại chuỗi kết nối để thực hiện bước đăng nhập
            KetNoiCSDL.ChuoiKetNoi = "Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234";
            ketNoiCSDL = new KetNoiCSDL();
            dieuKhien = "dangnhap";
            ketNoiCSDL.Open();

            SqlCommand cmd = new SqlCommand("select dbo.func_DangNhap(@TenDangNhap,@MatKhau)", ketNoiCSDL.GetConnection());
            string tenDangNhap = txt_tendn.Texts;
            cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
            string matKhau = txt_matkhau.Texts;
            cmd.Parameters.AddWithValue("@MatKhau", matKhau);

            try
            {
                int cap = (int)cmd.ExecuteScalar();

                TaiKhoan.TenDangNhap = tenDangNhap;
                TaiKhoan.MatKhau = matKhau;
                TaiKhoan.Cap = cap;
                // Thay đổi chuỗi kết nối để kết nối Database với quyền tương ứng
                KetNoiCSDL.ChuoiKetNoi = $"Data Source=.;Initial Catalog=QLNhaSach;User ID={tenDangNhap};Password={matKhau}";

                if (cap == 1)
                {
                    Form form = new Admin_Home();
                    this.Hide();
                    form.Show();
                }
                else if (cap == 2)  // nhan vien thu ngan
                {
                    Form form = new staff_home();
                    this.Hide();
                    form.Show();
                }
                else if (cap == 3) // Quản lí kho
                {
                    Form form = new Admin_Home();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    // Đăng nhập thất bại thì khôi phục lại chuỗi kết nối gốc
                    KetNoiCSDL.ChuoiKetNoi = "Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234";
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            ketNoiCSDL.Close();
        }

        private void lbl_thoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void form_dangnhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
