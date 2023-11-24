using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnWinform.Form_Admin
{
    public partial class admin_CTPhieuNhap : Form
    {
        private KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();
        private String dieuKhien = "trong";
        public admin_CTPhieuNhap()
        {
            InitializeComponent();
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

        private void btn_nxb_Click(object sender, EventArgs e)
        {
            Form form = new admin_NXB();
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

        private void clearInput()
        {
            cb_maPhieuNhap.Text = string.Empty;
            cb_maSach.Text = string.Empty;
            txt_soLuong.Text = string.Empty;
        }
        private void ResetDuLieu()
        {
            string sql = "SELECT * FROM V_ChiTietCacPhieuNhap";
            dtg_CTPhieuNhap.DataSource = ketNoiCSDL.TaoBang(sql);

            cb_maPhieuNhap.Enabled = false;
            cb_maSach.Enabled = false;
            txt_soLuong.Enabled = false;

            cb_maPhieuNhap.DisplayMember = "MaPhieuNhap";
            cb_maPhieuNhap.ValueMember = "MaPhieuNhap";
            cb_maPhieuNhap.DataSource = ketNoiCSDL.TaoBang("SELECT MaPhieuNhap FROM PhieuNhap");

            cb_maSach.DisplayMember = "MaSach";
            cb_maSach.ValueMember = "MaSach";
            cb_maSach.DataSource = ketNoiCSDL.TaoBang($"SELECT * FROM Sach s\r\nINNER JOIN PhieuNhap pn ON s.MaNXB = pn.MaNXB\r\nWHERE pn.MaPhieuNhap = '{cb_maPhieuNhap.Text}'");

            dieuKhien = "trong";
            clearInput();
        }
        private void admin_CTPhieuNhap_Load(object sender, EventArgs e)
        {
            ResetDuLieu();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            cb_maPhieuNhap.Enabled = true;
            txt_soLuong.Enabled = true;
            cb_maSach.Enabled = true;
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
            cmd.CommandText = "Proc_XoaChiTietPhieuNhap";

            String maPhieuNhap = cb_maPhieuNhap.Text.Trim();
            String maSach = cb_maSach.Text.Trim();

            cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
            cmd.Parameters.AddWithValue("@MaSach", maSach);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa chi tiết phiếu nhập thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResetDuLieu();
            ketNoiCSDL.Close();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            cb_maPhieuNhap.Enabled = true;
            txt_soLuong.Enabled = true;
            cb_maSach.Enabled = true;
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
                cmd.CommandText = "Proc_ThemChiTietPhieuNhap";

                try
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", cb_maPhieuNhap.Text);
                    cmd.Parameters.AddWithValue("@MaSach", cb_maSach.Text);
                    cmd.Parameters.AddWithValue("@SoLuongNhap", int.Parse(txt_soLuong.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm chi tiết phiếu nhập thành công");
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
                cmd.CommandText = "Proc_SuaChiTietPhieuNhap";

                try
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", cb_maPhieuNhap.Text);
                    cmd.Parameters.AddWithValue("@MaSach", cb_maSach.Text);
                    cmd.Parameters.AddWithValue("@SoLuongNhap", int.Parse(txt_soLuong.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã sửa chi tiết phiếu nhập thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ResetDuLieu();
            ketNoiCSDL.Close();
        }
        private void cb_maPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_maSach.DisplayMember = "MaSach";
            cb_maSach.ValueMember = "MaSach";
            cb_maSach.DataSource = ketNoiCSDL.TaoBang($"SELECT * FROM Sach s\r\nINNER JOIN PhieuNhap pn ON s.MaNXB = pn.MaNXB\r\nWHERE pn.MaPhieuNhap = '{cb_maPhieuNhap.Text}'");

        }

        private void dtg_CTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dtg_CTPhieuNhap.DataSource;
            int chiSo = dtg_CTPhieuNhap.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            cb_maPhieuNhap.Text = dr["MaPhieuNhap"].ToString();
            cb_maSach.Text = dr["MaSach"].ToString();
            txt_soLuong.Text = dr["SoLuongNhap"].ToString();
        }
        private bool KiemTraNhapDuLieu()
        {
            if (cb_maPhieuNhap.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được trống!");
                return false;
            }
            if (cb_maSach.Text.Trim() == "")
            {
                MessageBox.Show("Mã sách không được trống!");
                return false;
            }
            if (txt_soLuong.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng nhập không được trống!");
                return false;
            }

            return true;
        }

        //-----------------------------------------------------

    }
}
