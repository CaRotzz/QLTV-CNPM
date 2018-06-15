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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        public string tendangnhap;
        public string matkhau;
        public string phanquyen;
        private void btnSinhVien_Click_1(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnVitri_Click_1(object sender, EventArgs e)
        {
            frmViTri frmvt = new frmViTri();
            this.Hide();
            frmvt.ShowDialog();
            this.Show();
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            frmNhanVien frmnv = new frmNhanVien();
            this.Hide();
            frmnv.ShowDialog();
            this.Show();
        }

        private void btnSach_Click_1(object sender, EventArgs e)
        {
            frmSach frms = new frmSach();
            this.Hide();
            frms.ShowDialog();
            this.Show();
        }

        private void btnMuontra_Click(object sender, EventArgs e)
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
            frmTaiKhoan ftk = new frmTaiKhoan();
            ftk.tendangnhap1 = tendangnhap;
            ftk.matkhau1 = matkhau;
            ftk.phanquyen1 = phanquyen;
            this.Hide();
            ftk.ShowDialog();
            this.Show(); 
        }
    }
}
