using DevExpress.XtraEditors;
using DoAnLapTrinhWindows.ModelsNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLapTrinhWindows
{
    public partial class frmTrangChu : DevExpress.XtraEditors.XtraForm
    {
        NhanVienDB context = new NhanVienDB();
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void BindGirdPhongBan(List<PhongBan> listPhongBan)
        {
            dgvPhongBan.Rows.Clear();
            try 
            {
                foreach (var item in listPhongBan)
                {
                    int index = dgvPhongBan.Rows.Add();

                    dgvPhongBan.Rows[index].Cells[0].Value = item.MaPB;
                    dgvPhongBan.Rows[index].Cells[1].Value = item.TenPB;
                    dgvPhongBan.Rows[index].Cells[2].Value = item.MoTa;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

        }

        private void BindGirdLuong(List<Luong> listLuong, List<NhanVien> listNhanVien)
        {
            dgvLuong.Rows.Clear();
            try
            {
                foreach (var item in listLuong)
                {
                    int index = dgvLuong.Rows.Add();

                    dgvLuong.Rows[index].Cells[0].Value = item.MaNV;
                    dgvLuong.Rows[index].Cells[1].Value = item.NhanVien.HoTen;
                    dgvLuong.Rows[index].Cells[2].Value = item.LuongCoBan;
                    dgvLuong.Rows[index].Cells[3].Value = item.Thuong;
                    dgvLuong.Rows[index].Cells[4].Value = item.Phat;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

        }

        private void BindGirdNhanVien(List<NhanVien> listNhanVien)
        {
            dgvNhanVien.Rows.Clear();
            try
            {
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
                    dgvNhanVien.Rows[index].Cells[9].Value = item.HinhAnh;
                    dgvNhanVien.Rows[index].Cells[10].Value = item.NgayVaoLam;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

        }

        private int CountNhanVien()
        {
            return context.NhanViens.Count();
        }
        private int CountPhongBan()
        {
            return context.PhongBans.Count();
        }

        private void LoadCount()
        {
            lblSoluongNhanVien.Text = CountNhanVien().ToString();
            lblSoLuongPhongBan.Text = CountPhongBan().ToString();
        }

        private void frmTrangchu_Load(object sender, EventArgs e)
        {
            List<PhongBan> listPhongBan = context.PhongBans.ToList();
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            List<Luong> listLuong = context.Luongs.ToList();
            BindGirdPhongBan(listPhongBan);
            BindGirdNhanVien(listNhanVien);
            BindGirdLuong(listLuong, listNhanVien);
            LoadCount();

        }

        private void tmrRealTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDayTime.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            List<NhanVien> listNhanVien;
            try
            {
                if (string.IsNullOrEmpty(search))
                {
                    listNhanVien = context.NhanViens.ToList();
                }
                else
                {
                    listNhanVien = context.NhanViens
                        .Where(nv => nv.HoTen.Contains(search))
                        .ToList();
                }

                BindGirdNhanVien(listNhanVien);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}