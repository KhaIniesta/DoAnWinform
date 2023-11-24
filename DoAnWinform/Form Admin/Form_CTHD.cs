using System.Data;
using System.Windows.Forms;

namespace DoAnWinform.Form_Admin
{
    public partial class Form_CTHD : Form
    {
        DataTable dt;
        public Form_CTHD()
        {
            InitializeComponent();
        }

        public Form_CTHD(DataTable dt)
        {
            this.dt = dt;
        }

        private void Form_CTHD_Load(object sender, System.EventArgs e)
        {
            dg_chitiethoadon.DataSource = Form_DoanhThu.setTable.dt;
        }

        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
