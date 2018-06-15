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
    public partial class frmTrangChu2 : Form
    {
        public frmTrangChu2()
        {
            InitializeComponent();
        }
        public string tendangnhap;
        public string matkhau;
        public string phanquyen;
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            frmSach frms = new frmSach();
            this.Hide();
            frms.ShowDialog();
            this.Show();
        }

        private void btnVitri_Click(object sender, EventArgs e)
        {
            frmViTri frmvt = new frmViTri();
            this.Hide();
            frmvt.ShowDialog();
            this.Show();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            frmMuonTra frmmt = new frmMuonTra();
            this.Hide();
            frmmt.ShowDialog();
            this.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frmh = new frmHelp();
            this.Hide();
            frmh.ShowDialog();
            this.Show();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan2 ftk2 = new frmTaiKhoan2();
            ftk2.tendangnhap2 = tendangnhap;
            ftk2.matkhau2 = matkhau;
            ftk2.phanquyen2 = phanquyen;
            this.Hide();
            ftk2.ShowDialog();
            this.Show();
        }
    }
}
