using DevExpress.XtraEditors;
using DoAnLapTrinhWindows.ModelsNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Expando;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLapTrinhWindows
{
    public partial class frmLuongNV : DevExpress.XtraEditors.XtraForm
    {
        NhanVienDB context = new NhanVienDB();
        public frmLuongNV()
        {
            InitializeComponent();
        }
        bool expand = false;
        private void timerXuatFile_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                pnlDropdown.Height += 15;
                if (pnlDropdown.Height >= pnlDropdown.MaximumSize.Height)
                {
                    timerXuatFile.Stop();
                    expand = true;
                }
            }
            else
            {
                pnlDropdown.Height -= 15;
                if (pnlDropdown.Height <= pnlDropdown.MinimumSize.Height)
                {
                    timerXuatFile.Stop();
                    expand = false;
                }
            }
        }
        private void LoadData()
        {
            List<Luong> listLuong = context.Luongs.ToList();
            BindGirdNhanVien(listLuong);
        }
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            timerXuatFile.Start();
        }

        private void txtPhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void BindGirdNhanVien(List<Luong> list)
        {
            dgvLuongNV.Rows.Clear();

            foreach (var item in list)
            {

                int index = dgvLuongNV.Rows.Add();

                dgvLuongNV.Rows[index].Cells[0].Value = item.MaNV;
                dgvLuongNV.Rows[index].Cells[1].Value = item.NhanVien.HoTen;
                dgvLuongNV.Rows[index].Cells[2].Value = item.LuongCoBan;
                dgvLuongNV.Rows[index].Cells[3].Value = item.Thuong;
                dgvLuongNV.Rows[index].Cells[4].Value = item.Phat;
                dgvLuongNV.Rows[index].Cells[4].Value = item.LuongThucNhan;

            }
        }
        private void ClearInputFields()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtLuong.Clear();
            txtThuong.Clear();
            txtPhat.Clear();
            txtLuongThucNhan.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            List<Luong> listLuong;
            try
            {
                if (string.IsNullOrEmpty(search))
                {
                    listLuong = context.Luongs.ToList();
                }
                else
                {
                    listLuong = context.Luongs
                        .Where(l => l.NhanVien.HoTen.Contains(search))
                        .ToList();
                }

                BindGirdNhanVien(listLuong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLuongNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLuongNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtLuong.Text = row.Cells[2].Value.ToString();
                txtThuong.Text = row.Cells[3].Value.ToString();
                txtPhat.Text = row.Cells[4].Value.ToString();
                txtLuongThucNhan.Text = row.Cells[5]?.Value?.ToString()??string.Empty;
            }
        }

        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var newLuong = new Luong
            {
                MaNV = txtMaNV.Text,
                LuongCoBan = decimal.Parse(txtLuong.Text),
                Thuong = decimal.Parse(txtThuong.Text),
                Phat = decimal.Parse(txtPhat.Text)
            };

            context.Luongs.Add(newLuong);
            context.SaveChanges();
            LoadData();
            ClearInputFields();
            MessageBox.Show("Thêm lương thành công!");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var luong = context.Luongs.FirstOrDefault(l => l.MaNV == txtMaNV.Text);
            if (luong != null)
            {
                luong.LuongCoBan = decimal.Parse(txtLuong.Text);
                luong.Thuong = decimal.Parse(txtThuong.Text);
                luong.Phat = decimal.Parse(txtPhat.Text);

                context.SaveChanges();
                LoadData();
                ClearInputFields();
                MessageBox.Show("Cập nhật lương thành công!");
            }
            else
            {
                MessageBox.Show("Nhân viên không tồn tại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var luong = context.Luongs.FirstOrDefault(l => l.MaNV == txtMaNV.Text);
            if (luong != null)
            {
                context.Luongs.Remove(luong);
                context.SaveChanges();
                LoadData();
                ClearInputFields();
                MessageBox.Show("Xóa lương thành công!");
            }
            else
            {
                MessageBox.Show("Nhân viên không tồn tại!");
            }
        }
    }
}