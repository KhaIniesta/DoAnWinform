using DoAnWinform.Form_Admin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class admin_Sach : Form
    {
        private KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();
        private String dieuKhien = "trong";

        public admin_Sach()
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
            txt_masach.Text = string.Empty;
            txt_tensach.Text = string.Empty;
            txt_theloai.Text = string.Empty;
            txt_slsach.Text = string.Empty;
            txt_gia.Text = string.Empty;
            cb_matacgia.Text = string.Empty;
            cb_manxb.Text = string.Empty;
        }
        private void ResetDuLieu()
        {
            string sql = "SELECT * FROM dbo.Func_LayBangSach()";
            dtg_sach.DataSource = ketNoiCSDL.TaoBang(sql);

            txt_masach.Enabled = false;
            txt_tensach.Enabled = false;
            txt_theloai.Enabled = false;
            txt_slsach.Enabled = false;
            txt_gia.Enabled = false;
            cb_matacgia.Enabled = false;
            cb_manxb.Enabled = false;
            btn_themanh.Enabled = false;

            cb_manxb.DisplayMember = "MaNXB";
            cb_manxb.ValueMember = "MaNXB";
            cb_manxb.DataSource = ketNoiCSDL.TaoBang("SELECT MaNXB FROM NhaXuatBan");

            cb_matacgia.DisplayMember = "MaTG";
            cb_matacgia.ValueMember = "MaTG";
            cb_matacgia.DataSource = ketNoiCSDL.TaoBang("SELECT MaTG FROM TacGia");

            picb_hinhanh.Image = null;

            dieuKhien = "trong";
            clearInput();
        }
        private void admin_Sach_Load(object sender, System.EventArgs e)
        {
            ResetDuLieu();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_masach.Enabled = true;
            txt_tensach.Enabled = true;
            txt_theloai.Enabled = true;
            txt_slsach.Enabled = true;
            txt_gia.Enabled = true;
            cb_matacgia.Enabled = true;
            cb_manxb.Enabled = true;
            btn_themanh.Enabled = true;

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
            cmd.CommandText = "Proc_XoaSach";

            String maSach = txt_masach.Text.Trim();
            cmd.Parameters.AddWithValue("@MaSach", maSach);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa sách thành công");
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
            txt_tensach.Enabled = true;
            txt_theloai.Enabled = true;
            txt_slsach.Enabled = true;
            txt_gia.Enabled = true;
            cb_matacgia.Enabled = true;
            cb_manxb.Enabled = true;
            btn_themanh.Enabled = true;
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
                cmd.CommandText = "Proc_ThemSach";

                cmd.Parameters.AddWithValue("@MaSach", txt_masach.Text);
                cmd.Parameters.AddWithValue("@MaTG", cb_matacgia.Text);
                cmd.Parameters.AddWithValue("@MaNXB", cb_manxb.Text);
                cmd.Parameters.AddWithValue("@TenSach", txt_tensach.Text);
                cmd.Parameters.AddWithValue("@SoLuongSach", int.Parse(txt_slsach.Text));
                cmd.Parameters.AddWithValue("@Gia", txt_gia.Text);
                cmd.Parameters.AddWithValue("@TheLoai", txt_theloai.Text);

                byte[] imageData = Utils.TaoDataImageTuLinkFile(picb_hinhanh.ImageLocation);
                cmd.Parameters.AddWithValue("@Anh", imageData);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm sách thành công");
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
                cmd.CommandText = "Proc_SuaSach";

                String maSach = txt_masach.Text.Trim();

                cmd.Parameters.AddWithValue("@MaSach", maSach);
                cmd.Parameters.AddWithValue("@MaTG", cb_matacgia.Text);
                cmd.Parameters.AddWithValue("@MaNXB", cb_manxb.Text);
                cmd.Parameters.AddWithValue("@TenSach", txt_tensach.Text);
                cmd.Parameters.AddWithValue("@SoLuongSach", int.Parse(txt_slsach.Text));

                String gia = txt_gia.Text.Trim().Split(',')[0];
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@TheLoai", txt_theloai.Text);

                byte[] imageData = Utils.TaoDataImageTuLinkFile(picb_hinhanh.ImageLocation);
                cmd.Parameters.AddWithValue("@Anh", imageData);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã sửa sách thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ResetDuLieu();
            ketNoiCSDL.Close();
        }
        private void btn_themanh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*.jpg|png|*.png|gif|*.gif|All Files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                picb_hinhanh.ImageLocation = openFileDialog1.FileName;
                openFileDialog1.Dispose();
            }
        }

        private void dtg_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dtg_sach.DataSource;
            int chiSo = dtg_sach.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            txt_masach.Text = dr["MaSach"].ToString();
            txt_tensach.Text = dr["TenSach"].ToString();
            txt_theloai.Text = dr["TheLoai"].ToString();
            txt_slsach.Text = dr["SoLuongSach"].ToString();
            txt_gia.Text = dr["Gia"].ToString();
            cb_matacgia.Text = dr["MaTG"].ToString();
            cb_manxb.Text = dr["MaNXB"].ToString();
            picb_hinhanh.Image = null;

            if (dtg_sach.CurrentRow.Cells[7].Value != DBNull.Value)
            {
                try
                {
                    Image image = null;
                    image = Utils.ChuyenVeHinhAnh((byte[])dtg_sach.CurrentRow.Cells[7].Value);
                    picb_hinhanh.Image = image;

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                }
            }
        }
        private bool KiemTraNhapDuLieu()
        {
            if (txt_masach.Text.Trim() == "")
            {
                MessageBox.Show("Mã sách không được trống!");
                return false;
            }
            if (txt_tensach.Text.Trim() == "")
            {
                MessageBox.Show("Tên sách không được trống!");
                return false;

            }
            if (txt_theloai.Text.Trim() == "")
            {
                MessageBox.Show("Thể loại không được trống!");
                return false;

            }
            if (txt_slsach.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng sách không được trống!");
                return false;

            }
            if (txt_gia.Text.Trim() == "")
            {
                MessageBox.Show("Giá sách không được trống!");
                return false;

            }
            return true;
        }

       
    }
}
