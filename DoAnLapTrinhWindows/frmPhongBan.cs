using DevExpress.XtraEditors;
using DoAnLapTrinhWindows.ModelsNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLapTrinhWindows
{
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        NhanVienDB context = new NhanVienDB();
        public frmPhongBan()
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
                    int employeeCount = context.NhanViens.Count(nv => nv.MaPB == item.MaPB);
                    int index = dgvPhongBan.Rows.Add();

                    dgvPhongBan.Rows[index].Cells[0].Value = item.MaPB;
                    dgvPhongBan.Rows[index].Cells[1].Value = item.TenPB;
                    dgvPhongBan.Rows[index].Cells[2].Value = item.MoTa;
                    dgvPhongBan.Rows[index].Cells[3].Value = employeeCount;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            List<PhongBan> listPhongBan = context.PhongBans.ToList();
            BindGirdPhongBan(listPhongBan);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPB.Text) || string.IsNullOrEmpty(txtTenPB.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }

                string mapb = txtMaPB.Text;
                var updatePhongBan = context.PhongBans.FirstOrDefault(p => p.MaPB == mapb);
                if (updatePhongBan == null)
                {
                    PhongBan newPhongBan = new PhongBan
                    {
                        MaPB = txtMaPB.Text,
                        TenPB = txtTenPB.Text,
                        MoTa = txtMoTa.Text
                    };


                    context.PhongBans.Add(newPhongBan);
                    context.SaveChanges();
                    MessageBox.Show("Thêm phòng ban thành công!");
                    ClearFields();
                }
                else
                { 
                    MessageBox.Show("Phòng ban đã tồn tại!");
                }



                List<PhongBan> listPhongBan = context.PhongBans.ToList();
                BindGirdPhongBan(listPhongBan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng ban: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {

                string mapb = txtMaPB.Text;
                var updatePhongBan = context.PhongBans.FirstOrDefault(p => p.MaPB == mapb);
                if (updatePhongBan != null)
                {
                    updatePhongBan.TenPB = txtTenPB.Text;
                    updatePhongBan.MoTa = txtMoTa.Text;

                    context.SaveChanges();
                    MessageBox.Show("Cập nhật phòng ban thành công!");
                    ClearFields();
                    List<PhongBan> listPhongBan = context.PhongBans.ToList();
                    BindGirdPhongBan(listPhongBan);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng ban!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phòng ban: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPB.Text))
                {
                    MessageBox.Show("Vui lòng chọn phòng ban cần xóa!");
                    return;
                }

                PhongBan deletePhongBan = context.PhongBans.Find(txtMaPB.Text);
                if (deletePhongBan != null)
                {
                    context.PhongBans.Remove(deletePhongBan);
                    context.SaveChanges();
                    MessageBox.Show("Xóa phòng ban thành công!");
                    ClearFields();
                    List<PhongBan> listPhongBan = context.PhongBans.ToList();
                    BindGirdPhongBan(listPhongBan);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng ban!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng ban: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtMoTa.Clear();
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhongBan.Rows[e.RowIndex];
                txtMaPB.Text = row.Cells[0].Value?.ToString(); 
                txtTenPB.Text = row.Cells[1].Value?.ToString(); 
                txtMoTa.Text = row.Cells[2].Value?.ToString();  
            }
        }
    }
}