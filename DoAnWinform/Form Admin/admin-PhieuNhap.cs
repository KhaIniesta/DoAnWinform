using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnWinform.Form_Admin
{
    public partial class admin_phieunhap : Form
    {
        private KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();
        private String dieuKhien = "trong";
        public admin_phieunhap()
        {
            InitializeComponent();
            if (TaiKhoan.Cap == 3)
            {
                btn_nxb.Enabled = false;
            }
        }

        //-----------------------------------------------------
        // Click to change to other form
        private void btn_trangchu_Click(object sender, System.EventArgs e)
        {
            Form form = new Admin_Home();
            this.Hide();
            form.Show();
        }

        private void btn_sach_Click(object sender, System.EventArgs e)
        {
            Form form = new admin_Sach();
            this.Hide();
            form.Show();
        }

        private void btn_tacgia_Click(object sender, System.EventArgs e)
        {
            Form form = new admin_TacGia();
            this.Hide();
            form.Show();
        }

        private void btn_nxb_Click(object sender, System.EventArgs e)
        {
            Form form = new admin_NXB();
            this.Hide();
            form.Show();
        }

        private void btn_phieunhap_Click(object sender, System.EventArgs e)
        {
            Form form = new admin_phieunhap();
            this.Hide();
            form.Show();
        }

        private void btn_ctphieunhap_Click(object sender, System.EventArgs e)
        {
            Form form = new admin_CTPhieuNhap();
            this.Hide();
            form.Show();

        }

        private void btn_dangxuat_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form form = new form_dangnhap();
            form.Show();
        }

        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void clearInput()
        {
            txt_maPhieuNhap.Text = string.Empty;
            cb_maNxb.Text = string.Empty;
            dtp_ngayNhap.Text = string.Empty;
        }
        private void ResetDuLieu()
        {
            string sql = "SELECT * FROM dbo.Func_LayBangPhieuNhap()";
            dtg_phieunhap.DataSource = ketNoiCSDL.TaoBang(sql);

            txt_maPhieuNhap.Enabled = false;
            cb_maNxb.Enabled = false;
            dtp_ngayNhap.Enabled = false;

            cb_maNxb.DisplayMember = "MaNXB";
            cb_maNxb.ValueMember = "MaNXB";
            cb_maNxb.DataSource = ketNoiCSDL.TaoBang("SELECT MaNXB FROM NhaXuatBan");

            dieuKhien = "trong";
            clearInput();
        }
        private void admin_phieunhap_Load(object sender, EventArgs e)
        {
            ResetDuLieu();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_maPhieuNhap.Enabled = true;
            cb_maNxb.Enabled = true;
            dtp_ngayNhap.Enabled = true;
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
            cmd.CommandText = "Proc_XoaPhieuNhap";

            String maPhieuNhap = txt_maPhieuNhap.Text.Trim();
            cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa sách thành công");
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    // Thực hiện xóa các chi tiết phiếu nhập
                    SqlCommand ctpnCmd = new SqlCommand();
                    ctpnCmd.Connection = ketNoiCSDL.GetConnection();
                    ctpnCmd.CommandType = CommandType.StoredProcedure;
                    ctpnCmd.CommandText = "Proc_XoaChiTietPhieuNhapTheoMaPhieuNhap";
                    ctpnCmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                    try
                    {
                        ctpnCmd.ExecuteNonQuery();
                        MessageBox.Show($"Bạn đã xóa tất cả các CTPN có mã phiếu nhập là {maPhieuNhap}");
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại!");

                    }
                }
            }

            ResetDuLieu();
            ketNoiCSDL.Close();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            cb_maNxb.Enabled = true;
            dtp_ngayNhap.Enabled = true;

            dieuKhien = "capnhat";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(KiemTraNhapDuLieu() == false){
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
                cmd.CommandText = "Proc_ThemPhieuNhap";

                cmd.Parameters.AddWithValue("@MaPhieuNhap", txt_maPhieuNhap.Text);
                cmd.Parameters.AddWithValue("@MaNXB", cb_maNxb.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtp_ngayNhap.Value.ToShortDateString());

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm phiếu nhập thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dieuKhien == "capnhat")
            {
                ketNoiCSDL.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ketNoiCSDL.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Proc_SuaPhieuNhap";

                cmd.Parameters.AddWithValue("@MaPhieuNhap", txt_maPhieuNhap.Text);
                cmd.Parameters.AddWithValue("@MaNXB", cb_maNxb.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtp_ngayNhap.Value);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã sửa phiếu nhập thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ResetDuLieu();
            ketNoiCSDL.Close();
        }
        private void dtg_phieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dtg_phieunhap.DataSource;
            int chiSo = dtg_phieunhap.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            txt_maPhieuNhap.Text = dr["MaPhieuNhap"].ToString();
            cb_maNxb.Text = dr["MaNXB"].ToString();
            dtp_ngayNhap.Text = dr["NgayNhap"].ToString();
        }

        private bool KiemTraNhapDuLieu()
        {
            if (txt_maPhieuNhap.Text.Trim() == "")
            {       
                MessageBox.Show("Mã phiếu nhập không được trống!");
                return false;
            }
            if (cb_maNxb.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhà xuất bản nhập không được trống!");
                return false;
            }
            
            return true;
        }

        //-----------------------------------------------------

    }
}
