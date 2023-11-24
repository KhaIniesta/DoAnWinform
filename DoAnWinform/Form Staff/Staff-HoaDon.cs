using DoAnWinform.Report;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnWinform.Form_Staff
{
    public partial class staff_hoadon : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        SqlConnection conn;
        DataTable dt = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        Utils utils = new Utils();

        public staff_hoadon()
        {
            InitializeComponent();
            conn = kn.GetConnection();
        }

        // Method
        private void LoadDuLieuTheoMaHD()
        {
            cmd = new SqlCommand("Proc_HienCTHDTheoMaHD", conn);
            kn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = cb_mahd.Text.Trim();

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dtg_chitiethoadon.DataSource = dt;

            kn.Close();
        }
        private void CapNhatTongHD()
        {
            cmd = new SqlCommand("Proc_TimKiemTheoMaHD", conn);
            kn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = cb_mahd.Text.Trim();
            string result = cmd.ExecuteScalar()?.ToString();
            txt_tonghd.Text = result;
            kn.Close();

        }
        void reset()
        {
            txt_masach.ResetText();
            txt_gia.ResetText();
            txt_slban.ResetText();
            cb_tensach.ResetText();
            txt_tentacgia.ResetText();
            txt_theloai.ResetText();
            txt_tennxb.ResetText();

        }


        // Load dữ liệu vào bảng theo mã hóa đơn
        private void staff_hoadon_Load(object sender, System.EventArgs e)
        {
            kn.Open();

            //cb_masach.DataSource = con.TaoBang("Proc_TimKiemMaSach");
            //cb_masach.DisplayMember = "MaSach";

            cb_mahd.DataSource = kn.TaoBang("Proc_TimKiemMaHD");
            cb_mahd.DisplayMember = "MaHD";

            cb_tensach.DataSource = kn.TaoBang("Proc_TimKiemTenSach");
            cb_tensach.DisplayMember = "TenSach";

            kn.Close();

            // Set mã hóa đơn mới được tạo
            cb_mahd.Text = staff_home.SetMaHoaDon.mahd;

            // Set trạng thái cho các item
            this.reset();
        }

        private void cb_mahd_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            LoadDuLieuTheoMaHD();
            kn.Close();
        }

        private void btn_them_Click(object sender, System.EventArgs e)
        {

            kn.Open();
            cmd = new SqlCommand("Proc_ThemSachCTHD", conn);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = cb_mahd.Text.Trim();
                cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = txt_masach.Text.Trim();
                cmd.Parameters.Add("@SoLuongBan", SqlDbType.Int).Value = txt_slban.Text.Trim();

                int count = cmd.ExecuteNonQuery();
                kn.Close();
                if (count > 0)
                {

                    MessageBox.Show("Thêm thành công");
                    LoadDuLieuTheoMaHD();
                    this.reset();

                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                    this.reset();
                }
                CapNhatTongHD();

            }
            catch (Exception ex)
            {
                kn.Close();
                MessageBox.Show(ex.Message, "Thông báo!");
                txt_slban.Clear();
                txt_slban.Focus();

            }
            finally
            {
                kn.Close();
            }

        }

        private void btn_capnhat_Click(object sender, System.EventArgs e)
        {
            cmd = new SqlCommand("Proc_CapNhatSachCTHD", conn);
            kn.Open();
            try
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = cb_mahd.Text.Trim();
                cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = txt_masach.Text.Trim();
                cmd.Parameters.Add("@SoLuongBan", SqlDbType.Int).Value = txt_slban.Text.Trim();
                int count = cmd.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {

                    MessageBox.Show("Cập nhật thành công");
                    LoadDuLieuTheoMaHD();
                    this.reset();

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                    this.reset();
                }
                CapNhatTongHD();
                LoadDuLieuTheoMaHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được để trống số lượng sách!", "Thông báo!");
                txt_slban.Clear();
                txt_slban.Focus();
            }
            finally
            {
                kn.Close();
            }


        }

        private void dtg_chitiethoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra cả dòng và cột được chọn
            {
                DataGridViewRow row = dtg_chitiethoadon.Rows[e.RowIndex];

                // Hiển thị thông tin trong TextBox
                txt_masach.Text = row.Cells["col_masach"].Value.ToString();
                cb_mahd.Text = row.Cells["col_mahd"].Value.ToString();
                txt_tentacgia.Text = row.Cells["col_tentg"].Value.ToString();
                txt_theloai.Text = row.Cells["col_theloai"].Value.ToString();
                txt_tennxb.Text = row.Cells["col_tennxb"].Value.ToString();
                txt_slban.Text = row.Cells["col_soluongban"].Value.ToString();
                txt_gia.Text = row.Cells["col_gia"].Value.ToString();
                cb_tensach.Text = row.Cells["col_tensach"].Value.ToString();
                string check = row.Cells["col_anh"].Value.ToString();
                if (check == "")
                {
                    pb_anh.Image = null;
                }
                else
                {
                    Image anh = Utils.ChuyenVeHinhAnh((byte[])row.Cells["col_anh"].Value);
                    pb_anh.Image = anh;
                }
            }

            btn_them.Enabled = false;
            btn_capnhat.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void btn_xoa_Click(object sender, System.EventArgs e)
        {
            kn.Open();
            cmd = new SqlCommand("Proc_XoaSachCTHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = cb_mahd.Text.Trim();
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = txt_masach.Text.Trim();
            int count = cmd.ExecuteNonQuery();
            kn.Close();
            if (count > 0)
            {

                MessageBox.Show("Cập nhật thành công");
                LoadDuLieuTheoMaHD();
                this.reset();

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
                this.reset();
            }
            CapNhatTongHD();
            kn.Close();
        }

        private void btn_huyhd_Click(object sender, System.EventArgs e)
        {
            cmd = new SqlCommand("Proc_XoaHoaDon", conn);
            kn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = cb_mahd.Text.Trim();
            cmd.ExecuteNonQuery();
            kn.Close();

            this.Hide();
            Form form = new staff_home();
            form.Show();
            LoadDuLieuTheoMaHD();
        }

        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form form = new staff_home();
            form.Show();
        }

        private void cb_tensach_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Proc_HienCTHDTheoTenSach", conn);
            kn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSach", SqlDbType.NChar).Value = cb_tensach.Text;
            //da = new SqlDataAdapter(cmd);
            //dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                // Lấy giá trị theo tên trường trong csdl
                txt_masach.Text = dr["MaSach"].ToString();
                txt_tentacgia.Text = dr["TenTG"].ToString();
                txt_tennxb.Text = dr["TenNXB"].ToString();
                txt_theloai.Text = dr["TheLoai"].ToString();
                txt_gia.Text = dr["Gia"].ToString();
                string check = dr["Anh"].ToString();
                if (check == "")
                {
                    pb_anh.Image = null;
                }
                else
                {
                    Image anh = Utils.ChuyenVeHinhAnh((byte[])dr["Anh"]);
                    pb_anh.Image = anh;
                }
            }

            btn_them.Enabled = true;
            btn_capnhat.Enabled = false;
            btn_xoa.Enabled = false;
            txt_slban.Clear();
            kn.Close();
        }

        private void cb_masach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_xuathd_Click(object sender, EventArgs e)
        {
            // Cập nhật lại thời gian hóa đơn
            cmd = new SqlCommand("Proc_CapNhatHoaDon", conn);
            kn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = cb_mahd.Text;
            cmd.ExecuteNonQuery();
            conn.Close();

            // Xuất hóa đơn
            cmd = new SqlCommand("Proc_XuatHoaDon", conn);
            kn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = cb_mahd.Text;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            // Gán dữ liệu cho report
            rptHoaDon hoaDon = new rptHoaDon();
            hoaDon.SetDataSource(dt);

            // Hiển thị báo cáo
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.rptHoaDon.ReportSource = hoaDon;
            frmHoaDon.ShowDialog();
        }
    }
}

