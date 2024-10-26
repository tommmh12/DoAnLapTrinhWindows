using DoAnLapTrinhWindows.ModelsUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnLapTrinhWindows
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        private void CheckLogin()
        {
            try {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                using (UserLoging context =  new UserLoging())
                {
                    var user = context.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

                    if (user != null) 
                    {
                        if (user.Role == "Admin")
                        {
                            MessageBox.Show("Đăng nhập với quyền Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frmManager frmManager = new frmManager();
                            frmManager.ShowDialog();
                        }
                        else if (user.Role == "NhanVien")
                        {
                            MessageBox.Show("Đăng nhập với quyền Nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                        }
                        else {
                            MessageBox.Show("Thông tin bạn nhập chưa chính xác.", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
