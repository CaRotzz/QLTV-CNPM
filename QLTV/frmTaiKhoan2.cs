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
    public partial class frmTaiKhoan2 : Form
    {
        public frmTaiKhoan2()
        {
            InitializeComponent();
        }
        public string tendangnhap2;
        public string matkhau2;
        public string phanquyen2;
        DataConnections con = new DataConnections();
        private void button1_Click(object sender, EventArgs e)
        {
            frmDoiMK fdmk = new frmDoiMK();
            fdmk.tendn = tendangnhap2;
            fdmk.mkhau = matkhau2;
            this.Hide();
            fdmk.ShowDialog();
            this.Show();
        }

        private void frmTaiKhoan2_Load(object sender, EventArgs e)
        {
            lbtendn.Text = tendangnhap2;
            lbmatkhau.Text = matkhau2;
            lbphanquyen.Text = phanquyen2;
        }
    }
}
