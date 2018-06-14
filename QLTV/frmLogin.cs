﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DataConnections dt = new DataConnections();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1_show_password.Checked)
            {
                txbMK.UseSystemPasswordChar = false;
            }
            else
            {
                txbMK.UseSystemPasswordChar = true;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
     
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KiemTraDN";
            cmd.Connection = dt.conn;

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txbTK.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = txbMK.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            var user = reader.Read();
            if (user == true)
            {

                if ((int)reader["PhanQuyen"] == 1)// Bảng của admin
                {
                    frmTrangChu f = new frmTrangChu();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if ((int)reader["PhanQuyen"] == 2)//Bảng của nhân viên
                {
                    frmTrangChu2 g = new frmTrangChu2();
                    this.Hide();
                    g.ShowDialog();
                    this.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            reader.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
