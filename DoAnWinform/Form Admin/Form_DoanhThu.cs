using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DoAnWinform.Form_Admin
{
    public partial class Form_DoanhThu : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        SqlConnection conn;
        DataTable dt = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        public Form_DoanhThu()
        {
            InitializeComponent();
            conn = kn.GetConnection();
        }

        public class setTable
        {
            public static DataTable dt;
        }

        private void reset()
        {
            cb_nam.Text = "";
            cb_ngay.Text = "";
            cb_thang.Text = "";
            cb_ngay.Enabled = false;
            cb_thang.Enabled = false;

            btn_dtnam.Enabled = false;
            btn_dtthang.Enabled = false;
            btn_dtngay.Enabled = false;
        }

        private void Form_DoanhThu_Load(object sender, EventArgs e)
        {

            // Gán danh sách giá trị cho combobox
            List<string> ngayList = kn.TaoBang("select distinct Ngay from V_DTNgay").AsEnumerable().Select(row => row["Ngay"].ToString()).ToList();

            List<string> thangList = kn.TaoBang("select distinct Thang from V_DTThang").AsEnumerable().Select(row => row["Thang"].ToString()).ToList();

            List<string> namList = kn.TaoBang("select distinct Nam from V_DTNam").AsEnumerable().Select(row => row["Nam"].ToString()).ToList();

            cb_ngay.DataSource = ngayList;

            cb_thang.DataSource = thangList;
            //cb_thang.DisplayMember = "Thang";
            cb_nam.DataSource = namList;
            //cb_nam.DisplayMember = "Nam";

            //reset combobox
            reset();

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Admin_Home();
            form.Show();
        }

        private void btn_dtngay_Click(object sender, EventArgs e)
        {
            string sql = $"select * from V_DTNgay where Ngay = {cb_ngay.Text} and Thang = {cb_thang.Text} and Nam = {cb_nam.Text}";
            dg_doanhthu.DataSource = kn.TaoBang(sql);


            cmd = new SqlCommand("select dbo.func_tinhDoanhThuNgay(@ngay,@thang,@nam)", conn);
            conn.Open();
            cmd.Parameters.Add("@ngay", SqlDbType.Int).Value = cb_ngay.Text.Trim();
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = cb_thang.Text.Trim();
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = cb_nam.Text.Trim();
            double dtngay = (double)cmd.ExecuteScalar();
            txt_tongdoanhthu.Text = dtngay.ToString();
            conn.Close();
            reset();
        }

        private void btn_dtthang_Click(object sender, EventArgs e)
        {
            string sql = $"select * from V_DTThang where Thang = {cb_thang.Text} and Nam = {cb_nam.Text}";
            dg_doanhthu.DataSource = kn.TaoBang(sql);

            cmd = new SqlCommand($"select dbo.func_tinhDoanhThuThang(@thang,@nam)", conn);
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = cb_thang.Text.Trim();
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = cb_nam.Text.Trim();
            conn.Open();
            double dtthang = (double)cmd.ExecuteScalar();
            txt_tongdoanhthu.Text = dtthang.ToString();
            conn.Close();

            reset();
        }

        private void btn_dtnam_Click(object sender, EventArgs e)
        {
            string sql = $"select * from V_DTThang where Nam = {cb_nam.Text}";
            dg_doanhthu.DataSource = kn.TaoBang(sql);

            cmd = new SqlCommand($"select dbo.func_tinhDoanhThuNam(@nam)", conn);
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = cb_nam.Text.Trim();
            conn.Open();
            double dtnam = (double)cmd.ExecuteScalar();
            txt_tongdoanhthu.Text = dtnam.ToString();
            conn.Close();

            reset();
        }

        private void cb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_thang.Enabled = true;
            btn_dtnam.Enabled = true;
        }

        private void cb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ngay.Enabled = true;
            btn_dtthang.Enabled = true;
        }

        private void cb_ngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_dtngay.Enabled = true;
        }

        private void dg_doanhthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            int rowindex = dg_doanhthu.CurrentRow.Index;
            object mahd = dg_doanhthu.Rows[rowindex].Cells[0].Value;
            Console.WriteLine(mahd);

            cmd = new SqlCommand("Proc_HienCTHDTheoMaHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = (String)mahd;

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            setTable.dt = dt;

            Form form = new Form_CTHD();
            form.Show();
        }
    }
}
