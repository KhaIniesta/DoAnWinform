using DoAnWinform.Form_Admin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class admin_TacGia : Form
    {
        public admin_TacGia()
        {
            InitializeComponent();
            con = kn.GetConnection();
            if (TaiKhoan.Cap == 3)
            {
                btn_nxb.Enabled = false;
            }
        }
        KetNoiCSDL kn = new KetNoiCSDL();
        private SqlConnection con;
        private SqlCommand cmd;

        private void LoadData()
        {
            kn.Open();
            string sql = "Select * from TacGia";
            dtg_tacgia.DataSource = kn.TaoBang(sql);

            cb_manhaxuatban.DisplayMember = "MaNXB";
            cb_manhaxuatban.ValueMember = "MaNXB";
            cb_manhaxuatban.DataSource = kn.TaoBang("SELECT MaNXB FROM TacGia");
            cb_manhaxuatban.Enabled = false;
            txt_matacgia.Enabled = false;

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
            this.Close();
        }

        private void admin_TacGia_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_matacgia.Clear();
            txt_tentacgia.Clear();
            txt_lienhe.Clear();
            cb_manhaxuatban.Text = string.Empty;
            btn_capnhat.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = false;
            btn_luu.Enabled = true;
            txt_matacgia.Enabled = true;
            cb_manhaxuatban.Enabled = true;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_matacgia.Enabled = false;
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("XoaTacGia", con);
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaTG", txt_matacgia.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa tác giả thành công!!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy thao tác xóa tác giả.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực thi câu lệnh SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("CapNhatTacGia", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaTG", txt_matacgia.Text);
            cmd.Parameters.AddWithValue("@MaNXB", cb_manhaxuatban.Text);
            cmd.Parameters.AddWithValue("@TenTG", txt_tentacgia.Text);
            cmd.Parameters.AddWithValue("@LienHe", txt_lienhe.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật tác giả thành công!!");
                txt_matacgia.Text = "";
                txt_matacgia.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadData();
            con.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            txt_matacgia.Enabled = false;
            try
            {
                cmd = new SqlCommand("ThemTacGia", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTG", SqlDbType.NChar).Value = txt_matacgia.Text.Trim();
                cmd.Parameters.Add("@MaNXB", SqlDbType.NChar).Value = cb_manhaxuatban.Text.Trim();
                cmd.Parameters.Add("@TenTG", SqlDbType.NVarChar).Value = txt_tentacgia.Text.Trim();
                cmd.Parameters.Add("@LienHe", SqlDbType.NChar).Value = txt_lienhe.Text.Trim();

                int count = cmd.ExecuteNonQuery();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Thêm tác giả thành công!!");
                    LoadData();
                    txt_matacgia.Text = "";
                    txt_matacgia.Focus();
                }
                else
                {
                    MessageBox.Show("Không thể thêm tác giả mới!!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực thi câu lệnh SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dtg_tacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btn_capnhat.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_matacgia.Text = Convert.ToString(dtg_tacgia.CurrentRow.Cells["col_MaTG"].Value);
                cb_manhaxuatban.Text = Convert.ToString(dtg_tacgia.CurrentRow.Cells["col_MaNXB"].Value);
                txt_tentacgia.Text = Convert.ToString(dtg_tacgia.CurrentRow.Cells["col_TenTG"].Value);
                txt_lienhe.Text = Convert.ToString(dtg_tacgia.CurrentRow.Cells["col_LienHe"].Value);
                txt_matacgia.Enabled = false;


            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            txt_matacgia.Enabled = false;
            txt_lienhe.Enabled = false;
            cb_manhaxuatban.Text = string.Empty;
            txt_matacgia.Text = string.Empty;
            txt_lienhe.Text = string.Empty;

            try
            {

                string tenTacGia = txt_tentacgia.Text.Trim();
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.TimKiemSachTheoTacGia(@TenTacGia)", con))
                {

                    command.Parameters.Add("@TenTacGia", SqlDbType.NVarChar, 50).Value = tenTacGia;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);


                        dtg_tacgia.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
    }
}

