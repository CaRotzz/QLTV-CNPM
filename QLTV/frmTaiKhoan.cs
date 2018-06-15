using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        public string tendangnhap1;
        public string matkhau1;
        public string phanquyen1;
        DataConnections con = new DataConnections();
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            lbtendn.Text = tendangnhap1;
            lbmatkhau.Text = matkhau1;
            lbphanquyen.Text = phanquyen1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoiMK fdmk = new frmDoiMK();
            fdmk.tendn = tendangnhap1;
            fdmk.mkhau = matkhau1;
            this.Hide();
            fdmk.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTaoTK fttk = new frmTaoTK();
            this.Hide();
            fttk.ShowDialog();
            this.Show();
        }
    }
}
