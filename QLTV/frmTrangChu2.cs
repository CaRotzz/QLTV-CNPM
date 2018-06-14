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
    }
}
