using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnWinform.Form_Admin
{
    public partial class Form_QLTaiKhoan : Form
    {
        private KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();
        private String dieuKhien = "trong";
        public Form_QLTaiKhoan()
        {
            InitializeComponent();
        }
        private bool KiemTraNhapDuLieu()
        {
            if (txt_TenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được trống!");
                return false;
            }
            if (txt_MatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được trống!");
                return false;

            }
            if (cb_ChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Chức vụ không được trống!");
                return false;
            }

            return true;
        }
        private void clearInput()
        {
            txt_TenDangNhap.Text = string.Empty;
            txt_MatKhau.Text = string.Empty;
            cb_ChucVu.Text = string.Empty;
        }
        private void ResetDuLieu()
        {
            string sql = "SELECT * FROM TaiKhoan";
            dg_taikhoan.DataSource = ketNoiCSDL.TaoBang(sql);

            txt_TenDangNhap.Enabled = false;
            txt_MatKhau.Enabled = false;
            cb_ChucVu.Enabled = false;
            dieuKhien = "trong";
            clearInput();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Admin_Home();
            form.Show();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Enabled = true;
            txt_MatKhau.Enabled = true;
            cb_ChucVu.Enabled = true;

            clearInput();
            dieuKhien = "them";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dieuKhien = "xoa";
            ketNoiCSDL.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ketNoiCSDL.GetConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Proc_XoaTaiKhoan";

            String TenDangNhap = txt_TenDangNhap.Text.Trim();
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa tài khoản thành công sách thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            ResetDuLieu();
            ketNoiCSDL.Close();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            txt_MatKhau.Enabled = true;
            dieuKhien = "capnhat";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapDuLieu() == false)
            {
                ResetDuLieu();
                return;
            }
            ketNoiCSDL.Open();
            if (dieuKhien == "them")
            {
                ketNoiCSDL.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ketNoiCSDL.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Proc_ThemTaiKhoan";

                String TenDangNhap = txt_TenDangNhap.Text.Trim();
                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                String MatKhau = txt_MatKhau.Text.Trim();
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                int Cap;
                if (cb_ChucVu.Text == "Admin")
                {
                    Cap = 1;
                }
                else if (cb_ChucVu.Text == "Thu ngân")
                {
                    Cap = 2;
                }
                else
                {
                    Cap = 3;
                }
                cmd.Parameters.AddWithValue("@Cap", Cap);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm tài khoản thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dieuKhien == "capnhat")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ketNoiCSDL.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_ThayDoiMatKhau";

                String TenDangNhap = txt_TenDangNhap.Text.Trim();
                String MatKhau = txt_MatKhau.Text.Trim();

                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Bạn đã sửa mật khẩu cho user {TenDangNhap} thành công");
                    if (TenDangNhap == TaiKhoan.TenDangNhap)
                    {
                        KetNoiCSDL.ChuoiKetNoi = $"Data Source=.;Initial Catalog=QLNhaSach;User ID={TenDangNhap};Password={MatKhau}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ResetDuLieu();
            ketNoiCSDL.Close();
        }

        private void dg_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dg_taikhoan.DataSource;
            int chiSo = dg_taikhoan.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            txt_TenDangNhap.Text = dr["TenDangNhap"].ToString();
            txt_MatKhau.Text = dr["MatKhau"].ToString();
            String ChucVu = "";
            if (dr["Cap"].ToString() == "1")
            {
                ChucVu = "Admin";
            }
            else if (dr["Cap"].ToString() == "2")
            {
                ChucVu = "Quản lý kho";

            }
            else
            {
                ChucVu = "Thu ngân";
            }
            cb_ChucVu.Text = ChucVu;

        }

        private void Form_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            ResetDuLieu();
        }
    }
}
