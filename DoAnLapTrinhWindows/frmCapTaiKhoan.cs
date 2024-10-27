using DevExpress.XtraEditors;
using DoAnLapTrinhWindows.ModelsNhanVien;
using DoAnLapTrinhWindows.ModelsUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLapTrinhWindows
{
    public partial class frmCapTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        UserLoging context = new UserLoging();
        NhanVienDB contexts = new NhanVienDB();
        public frmCapTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnCaptaikhoan_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string quyen = cmbQuyen.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(quyen))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên và chọn quyền!");
                return;
            }

            var nhanVien = contexts.NhanViens.SingleOrDefault(nv => nv.MaNV == maNV);
            if (nhanVien == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }


            string username = maNV;
            string password = GenerateRandomPassword(10);

            User newUser = new User
            {
                Username = username,
                PasswordHash = password,
                MaNV = maNV,
                Role = quyen
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            SendEmail(nhanVien.Email, username, password);

            MessageBox.Show("Cấp tài khoản thành công!");
        
    }

    private string GenerateRandomPassword(int length)
        {
            Random random = new Random();
            return string.Concat(Enumerable.Range(0, length).Select(_ => random.Next(0, 10)));
        }

        public void SendEmail(string recipientEmail, string username, string password)
        {
            try
            {
                var fromAddress = new MailAddress("hello12102004@gmail.com", "Support");
                var toAddress = new MailAddress(recipientEmail);
                const string fromPass = "udkz abpk vvgs actg"; // Mật khẩu ứng dụng hoặc mật khẩu thật

                using (var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPass)
                })
                {
                    string subject = "Cấp tài khoản thành công";
                    string body = $"Chào bạn,\n\nBạn đã được cấp tài khoản mới với thông tin như sau:\n" +
                                  $"Tài khoản: {username}\nMật khẩu: {password}\n\nVui lòng đăng nhập và thay đổi mật khẩu sau khi đăng nhập lần đầu.\n\nCảm ơn!";

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = false, // Đặt thành false nếu bạn không gửi HTML
                    })
                    {
                        smtp.Send(message);
                        MessageBox.Show("Email đã được gửi thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void frmCapTaiKhoan_Load(object sender, EventArgs e)
        {
            List<User> listQuyen = context.Users.ToList();
            BindcmbQuyen(listQuyen);
        }
        private void BindcmbQuyen(List<User> listQuyen)
        {
            cmbQuyen.Items.Clear();
            foreach (var user in listQuyen)
            {
                if (!cmbQuyen.Items.Contains(user.Role))
                {
                    cmbQuyen.Items.Add(user.Role);
                }
            }
            cmbQuyen.SelectedIndex = 0;
        }
    }
}