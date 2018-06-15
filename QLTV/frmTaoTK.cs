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
    public partial class frmTaoTK : Form
    {
        public frmTaoTK()
        {
            InitializeComponent();
            PullData();
        }
        DataConnections con = new DataConnections();
        List<string> lst = new List<string>();
        public void PullData()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from DANGNHAP";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(0);
                lst.Add(username);
            }
            reader.Close();
        }
        public void AddTK_Database()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DangKy";
            cmd.Connection = con.conn;

            cmd.Parameters.Add("@Taikhoan", SqlDbType.NVarChar).Value = txtUsername.Text;
            cmd.Parameters.Add("@Matkhau", SqlDbType.NVarChar).Value = txtPassword.Text;
            if (rdbAdmin.Checked == true)
            {
                cmd.Parameters.Add("@PHANQUYEN", SqlDbType.Int).Value = rdbAdmin.Text;
            }
            else if (rdbnv.Checked == true)
            {
                cmd.Parameters.Add("@PHANQUYEN", SqlDbType.Int).Value = rdbnv.Text;
            }
            
            int ret = cmd.ExecuteNonQuery();
            MessageBox.Show("Đăng ký thành công!");
        }
        bool check = true;
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            foreach (string us in lst)
            {
                if (us.Contains(txtUsername.Text) || txtUsername.Text.Contains(us) || txtPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại hoặc mật khẩu không khớp !", "Thông báo");
                    check = false;
                    break;
                }
                check = true;
            }
            if (check == true)
            {
                AddTK_Database();
            }
        }
    }
}
