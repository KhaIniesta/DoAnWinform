using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnWinform.Form_Staff
{
    public partial class staff_home : Form
    {
        KetNoiCSDL con = new KetNoiCSDL();
        Utils utils = new Utils();
        DataTable dt = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        SqlConnection conn;
        public staff_home()
        {
            InitializeComponent();
            conn = con.GetConnection();
        }

        // Class chuyển giá trị sang form khác
        public class SetMaHoaDon
        {
            public static string mahd;
        }

        // Thực thi procedure xuất ra danh sách thông tin sách



        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            Form form = new form_dangnhap();
            this.Close();
            form.Show();
        }

        private void btn_taohd_Click(object sender, System.EventArgs e)
        {
            //dt = con.TaoBang("Proc_ThemMaHoaDon");
            cmd = new SqlCommand("Proc_ThemMaHoaDon", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                SetMaHoaDon.mahd = dr["MaHD"].ToString();
            }

            Form form = new staff_hoadon();
            form.Show();
        }

        private void staff_home_Load(object sender, System.EventArgs e)
        {
            con.Open();
            // Load dữ liệu vào bảng
            string sql = "Select * from V_HienChiTietSach";
            dt = con.TaoBang(sql);
            dtg_sach.DataSource = dt;
            con.Close();
        }

        private void dtg_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra cả dòng và cột được chọn
            {
                DataGridViewRow row = dtg_sach.Rows[e.RowIndex];

                // Hiển thị thông tin trong TextBox
                txt_masach.Text = row.Cells["col_masach"].Value.ToString();
                txt_tentacgia.Text = row.Cells["col_tentg"].Value.ToString();
                txt_tennxb.Text = row.Cells["col_tennxb"].Value.ToString();
                txt_theloai.Text = row.Cells["col_theloai"].Value.ToString();
                txt_sl.Text = row.Cells["col_soluongsach"].Value.ToString();
                txt_gia.Text = row.Cells["col_gia"].Value.ToString();
                txt_tensach.Text = row.Cells["col_tensach"].Value.ToString();
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
        }
    }
}
