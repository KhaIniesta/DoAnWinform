using DoAnWinform.Form_Admin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class admin_NXB : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        private SqlConnection con;
        private SqlCommand cmd;
        public admin_NXB()
        {
            InitializeComponent();
            con = kn.GetConnection();
            if (TaiKhoan.Cap == 3)
            {
                btn_nxb.Enabled = false;
            }
        }
        private void Reset()
        {
            txt_maNXB.Clear();
            txt_tenNXB.Clear();
            txt_diaChi.Clear();
            txt_lienHe.Clear();
        }
        private void LoadData()
        {
            kn.Open();
            string sql = "Select * from NhaXuatBan";
            dtg_nxb.DataSource = kn.TaoBang(sql);
            kn.Close();

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

        
        private void btn_them_Click(object sender, System.EventArgs e)
        {
            Reset();
            txt_maNXB.Enabled = true;
            btn_capnhat.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = false;
            btn_luu.Enabled = true;
        }

        private void admin_NXB_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_nxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_capnhat.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_maNXB.Text = Convert.ToString(dtg_nxb.CurrentRow.Cells["col_maNXB"].Value);
                txt_tenNXB.Text = Convert.ToString(dtg_nxb.CurrentRow.Cells["col_tenNXB"].Value);
                txt_diaChi.Text = Convert.ToString(dtg_nxb.CurrentRow.Cells["col_diaChi"].Value);
                txt_lienHe.Text = Convert.ToString(dtg_nxb.CurrentRow.Cells["col_lienHe"].Value);
                txt_maNXB.Enabled = false;

            }

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Proc_SuaNhaXuatBan", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaNXB", txt_maNXB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenNXB", txt_tenNXB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChiNXB", txt_diaChi.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@LienHe", txt_lienHe.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                    LoadData();

                }
                else
                {
                    MessageBox.Show("khong the sua");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
            con.Close();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                btn_them.Enabled = true;
                btn_capnhat.Enabled = false;
                btn_xoa.Enabled = false;

                cmd = new SqlCommand("Proc_ThemNhaXuatBan", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNXB", SqlDbType.NChar).Value = txt_maNXB.Text.Trim();
                cmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar).Value = txt_tenNXB.Text.Trim();
                cmd.Parameters.Add("@DiaChiNXB", SqlDbType.NVarChar).Value = txt_diaChi.Text.Trim();
                cmd.Parameters.Add("@LienHe", SqlDbType.NVarChar).Value = txt_lienHe.Text.Trim();

                // Execute the stored procedure
                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                    txt_tenNXB.Text = "";
                    txt_tenNXB.Focus();
                }
                else
                {
                    MessageBox.Show("Không thể thêm mới");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            con.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("Proc_XoaNhaXuatBan", con);
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNXB", SqlDbType.NChar).Value = txt_maNXB.Text.Trim();

                    int count = cmd.ExecuteNonQuery();
                    con.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadData();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa hoặc mã NXB không tồn tại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //-----------------------------------------------------


    }
}
