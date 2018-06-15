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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để thêm một thành phần, điền đầy đủ thông tin sau đó ấn nút Thêm.", "Thêm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để sửa một thành phần, thay đổi thông tin cần sửa sau đó ấn nút Sửa.", "Sửa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để xoá một thành phần, chọn đối tượng cần xoá sau đó ấn nút Xoá.", "Xoá");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập thông tin đối tượng cần tìm kiếm sau đó ấn nút Tìm Kiếm.", "Tìm Kiếm");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để xoá các thông tin đã nhập, ấn nút Làm mới.", "Làm mới");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để mươn sách, vào mục Quản lý Mượn Trả, tab Mượn Sách, ấn nút Chọn ở phần Thông tin sách, chọn sách cần mượn, điền đầy đủ thông tin và ấn nút Mượn Sách.", "Mượn Sách");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để trả sách, vào mục Quản lý Mượn Trả, tab Trả Sách, điền đầy đủ thông tin rồi ấn nút Trả Sách.", "Trả Sách");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để đổi mật khẩu, vào mục Quản lý Tài khoản, chọn Đổi Mật khẩu, điền đầy đủ thông tin rồi ấn nút Đổi Mật khẩu", "Đổi Mật khẩu");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo Tài khoản chỉ dành cho Quản lý, để Tạo Tài khoản, vào mục Quản lý Tài khoản, chọn Tạo Tài khoản, điền đầy đủ thông tin rồi ấn nút Đăng ký", "Tạo Tài khoản");
        }
    }
}
