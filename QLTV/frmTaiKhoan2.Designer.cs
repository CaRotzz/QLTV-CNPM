namespace QLTV
{
    partial class frmTaiKhoan2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbtendn = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbphanquyen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QLTV.Properties.Resources.accounts_2;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbtendn);
            this.panel1.Controls.Add(this.lbmatkhau);
            this.panel1.Controls.Add(this.lbphanquyen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 550);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(656, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbtendn
            // 
            this.lbtendn.AutoSize = true;
            this.lbtendn.BackColor = System.Drawing.Color.White;
            this.lbtendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbtendn.Location = new System.Drawing.Point(370, 124);
            this.lbtendn.Name = "lbtendn";
            this.lbtendn.Size = new System.Drawing.Size(137, 25);
            this.lbtendn.TabIndex = 9;
            this.lbtendn.Text = "tên đăng nhập";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.BackColor = System.Drawing.Color.White;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbmatkhau.Location = new System.Drawing.Point(370, 195);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(92, 25);
            this.lbmatkhau.TabIndex = 8;
            this.lbmatkhau.Text = "mật khẩu";
            // 
            // lbphanquyen
            // 
            this.lbphanquyen.AutoSize = true;
            this.lbphanquyen.BackColor = System.Drawing.Color.White;
            this.lbphanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbphanquyen.Location = new System.Drawing.Point(370, 261);
            this.lbphanquyen.Name = "lbphanquyen";
            this.lbphanquyen.Size = new System.Drawing.Size(115, 25);
            this.lbphanquyen.TabIndex = 7;
            this.lbphanquyen.Text = "phân quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(73, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phân Quyền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(73, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(73, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(334, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Tài khoản";
            // 
            // frmTaiKhoan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 550);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaiKhoan2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbtendn;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbphanquyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}