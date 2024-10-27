using DevExpress.XtraEditors;
using DoAnLapTrinhWindows.ModelsNhanVien;
using DoAnLapTrinhWindows.ModelsUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLapTrinhWindows
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVienDB context = new NhanVienDB();
        UserLoging contexts = new UserLoging();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string avatarFilePath = string.Empty;

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    avatarFilePath = openFileDialog.FileName; // Lưu đường dẫn ảnh
                    picAvatar.Image = Image.FromFile(avatarFilePath); // Hiển thị ảnh trong PictureBox
                }
            }
        }

        private void LoadAvatar(string employeeID)
        {
            string folderPath = Path.Combine(Application.StartupPath, "Images");
            var employee = context.NhanViens.FirstOrDefault(p => p.MaNV == employeeID);
            if (employee != null && !string.IsNullOrEmpty(employee.HinhAnh))
            {
                string avatarFilePath = Path.Combine(folderPath, employee.HinhAnh); 
                if (File.Exists(avatarFilePath))
                {
                    picAvatar.Image = Image.FromFile(avatarFilePath); 
                }
                else
                {
                    picAvatar.Image = null;
                }
            }
        }
        private string SaveAvatar(string sourceFilePath, string employeeID)
        {
            try
            {
                if (string.IsNullOrEmpty(sourceFilePath)) return null; // Kiểm tra nếu không có file

                string folderPath = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileExtension = Path.GetExtension(sourceFilePath); // Lấy phần mở rộng của file ảnh
                string targetFilePath = Path.Combine(folderPath, $"{employeeID}{fileExtension}"); // Đặt tên file theo ID nhân viên

                if (!File.Exists(sourceFilePath))
                {
                    throw new FileNotFoundException($"Không tìm thấy file: {sourceFilePath}");
                }

                File.Copy(sourceFilePath, targetFilePath, true); // Sao chép file ảnh vào thư mục

                return $"{employeeID}{fileExtension}"; // Trả về tên file để lưu vào DB
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void cmbShowPhongBan()
        {
            try
            {

                var phongban = context.PhongBans.Select(p => new { p.MaPB, p.TenPB }).ToList();
                cmbPhongBan.DataSource = phongban;
                cmbPhongBan.DisplayMember = "TenPB"; 
                cmbPhongBan.ValueMember = "MaPB"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbShowGioitinh()
        {
            try
            {
                var phongban = context.NhanViens.Select(p => p.GioiTinh).Distinct().ToList();

                cmbGioiTinh.Items.Clear();
                foreach (var p in phongban)
                {
                    cmbGioiTinh.Items.Add(p);
                }
                cmbGioiTinh.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }


        private void BindGirdNhanVien(List<NhanVien> listNhanVien)
        {
            dgvNhanVien.Rows.Clear();
            try
            {
                dgvNhanVien.RowTemplate.Height = 150;
                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dgvNhanVien.Columns[9];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                foreach (var item in listNhanVien)
                {
                    int index = dgvNhanVien.Rows.Add();

                    dgvNhanVien.Rows[index].Cells[0].Value = item.MaNV;
                    dgvNhanVien.Rows[index].Cells[1].Value = item.HoTen;
                    dgvNhanVien.Rows[index].Cells[2].Value = item.NgaySinh;
                    dgvNhanVien.Rows[index].Cells[3].Value = item.GioiTinh;
                    dgvNhanVien.Rows[index].Cells[4].Value = item.DiaChi;
                    dgvNhanVien.Rows[index].Cells[5].Value = item.SDT;
                    dgvNhanVien.Rows[index].Cells[6].Value = item.CCCD;
                    dgvNhanVien.Rows[index].Cells[7].Value = item.Email;
                    dgvNhanVien.Rows[index].Cells[8].Value = item.ChucVu;
                    dgvNhanVien.Rows[index].Cells[10].Value = item.NgayVaoLam;
                    if (!string.IsNullOrEmpty(item.HinhAnh))
                    {
                        string folderPath = Path.Combine(Application.StartupPath, "Images");
                        string avatarFilePath = Path.Combine(folderPath, item.HinhAnh);

                        if (File.Exists(avatarFilePath))
                        {
                            Image avatarImage = Image.FromFile(avatarFilePath);
                            dgvNhanVien.Rows[index].Cells[9].Value = avatarImage; 
                        }
                        else
                        {
                            dgvNhanVien.Rows[index].Cells[9].Value = null; 
                        }
                    }
                    else
                    {
                        dgvNhanVien.Rows[index].Cells[9].Value = null;
                    }
                    dgvNhanVien.Rows[index].Cells[11].Value = item.PhongBan.TenPB;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            BindGirdNhanVien(listNhanVien);
            cmbShowPhongBan();
            cmbShowGioitinh();
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            dtNgaySinh.DateTime = DateTime.Now; 
            cmbGioiTinh.SelectedIndex = -1;
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            txtEmail.Clear();
            txtChucVu.Clear();
            dtNgayVaoLam.DateTime = DateTime.Now;
            picAvatar.Image = null;
            avatarFilePath = string.Empty; 
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string IdEmployee = txtMaNV.Text;
            var employeee = context.NhanViens.FirstOrDefault(p => p.MaNV == IdEmployee);
            

            if (employeee == null) 
            {

                var newEmployee = new NhanVien
                {
                    MaNV = txtMaNV.Text,
                    HoTen = txtTenNV.Text,
                    NgaySinh = dtNgaySinh.DateTime,
                    GioiTinh = cmbGioiTinh.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    CCCD = txtCCCD.Text,
                    Email = txtEmail.Text,
                    ChucVu = txtChucVu.Text,
                    NgayVaoLam = dtNgayVaoLam.DateTime,
                    MaPB = (string)cmbPhongBan.SelectedValue
                };

                if (!string.IsNullOrEmpty(avatarFilePath))
                {
                    string imageName = SaveAvatar(avatarFilePath, IdEmployee);
                    if (!string.IsNullOrEmpty(imageName))
                    {
                        newEmployee.HinhAnh = imageName;
                    }
                }


                context.NhanViens.Add(newEmployee);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công !");

                ClearInputFields();

                List<NhanVien> listNhanVien = context.NhanViens.ToList();
                BindGirdNhanVien(listNhanVien);
            }
            else
            {
                MessageBox.Show("Nhân viên đã tồn tại!");
            }
        }



        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                ClearInputFields();
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                dtNgaySinh.DateTime = DateTime.Parse(row.Cells[2].Value.ToString());
                cmbGioiTinh.SelectedItem = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                txtCCCD.Text = row.Cells[6].Value.ToString();
                txtEmail.Text = row.Cells[7].Value.ToString();
                txtChucVu.Text = row.Cells[8].Value.ToString();
                dtNgayVaoLam.DateTime = DateTime.Parse(row.Cells[10].Value.ToString());

                LoadAvatar(txtMaNV.Text);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IdEmployee = txtMaNV.Text;
            var employee = context.NhanViens.FirstOrDefault(p => p.MaNV == IdEmployee);

            if (employee != null)
            {
                var userAccount = contexts.Users.FirstOrDefault(u => u.MaNV == IdEmployee);

                if (userAccount != null)
                {
                    contexts.Users.Remove(userAccount);
                }
                context.NhanViens.Remove(employee);
                context.SaveChanges();
                MessageBox.Show("Xóa thành công!");

                ClearInputFields();

                List<NhanVien> listNhanVien = context.NhanViens.ToList();
                BindGirdNhanVien(listNhanVien);
            }
            else
            {
                MessageBox.Show("Nhân viên không tồn tại!");
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string IdEmployee = txtMaNV.Text;
            var employee = context.NhanViens.FirstOrDefault(p => p.MaNV == IdEmployee);

            if (employee != null)
            {
                employee.HoTen = txtTenNV.Text;
                employee.NgaySinh = dtNgaySinh.DateTime;
                employee.GioiTinh = cmbGioiTinh.Text;
                employee.DiaChi = txtDiaChi.Text;
                employee.SDT = txtSDT.Text;
                employee.CCCD = txtCCCD.Text;
                employee.Email = txtEmail.Text;
                employee.ChucVu = txtChucVu.Text;
                employee.NgayVaoLam = dtNgayVaoLam.DateTime;
                employee.MaPB = (string)cmbPhongBan.SelectedValue;

                if (!string.IsNullOrEmpty(avatarFilePath))
                {
                    string imageName = SaveAvatar(avatarFilePath, IdEmployee);
                    if (!string.IsNullOrEmpty(imageName))
                    {
                        employee.HinhAnh = imageName;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Cập nhật thành công!");
                ClearInputFields();
                List<NhanVien> listNhanVien = context.NhanViens.ToList();
                BindGirdNhanVien(listNhanVien);
            }
            else
            {
                MessageBox.Show("Nhân viên không tồn tại!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmCapTaiKhoan frmnew = new frmCapTaiKhoan();
            frmnew.ShowDialog();
        }
    }
}