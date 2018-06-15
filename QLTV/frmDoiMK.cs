using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV
{
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }
        DataConnections con = new DataConnections();
        public string tendn;
        public string mkhau;
        public void DoiMK()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DoiMK";
            cmd.Connection = con.conn;
            if (txtmkmoi.Text == txtxacnhan.Text)
            {
                cmd.Parameters.Add("@Taikhoan", SqlDbType.NVarChar).Value = tendn;
                cmd.Parameters.Add("@Matkhau", SqlDbType.VarChar).Value = txtmkmoi.Text;
                int ret = cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp!", "Lưu ý");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiMK();

        }
    }
}
