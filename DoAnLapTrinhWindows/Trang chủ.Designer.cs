namespace DoAnLapTrinhWindows
{
    partial class frmTrangChu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.colMaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.colMaNVLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNVLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSoLuongNhanVien = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSoluongNhanVien = new System.Windows.Forms.Label();
            this.pnlSoLuongPhongBan = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoLuongPhongBan = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDayTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrRealTime = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSoLuongNhanVien.SuspendLayout();
            this.pnlSoLuongPhongBan.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(945, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trang chủ";
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPB,
            this.colTenPB,
            this.colMota});
            this.dgvPhongBan.Location = new System.Drawing.Point(26, 226);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(498, 239);
            this.dgvPhongBan.TabIndex = 3;
            // 
            // colMaPB
            // 
            this.colMaPB.HeaderText = "Mã phòng ban";
            this.colMaPB.Name = "colMaPB";
            // 
            // colTenPB
            // 
            this.colTenPB.HeaderText = "Tên phòng ban";
            this.colTenPB.Name = "colTenPB";
            this.colTenPB.Width = 150;
            // 
            // colMota
            // 
            this.colMota.HeaderText = "Mô tả";
            this.colMota.Name = "colMota";
            this.colMota.Width = 200;
            // 
            // dgvLuong
            // 
            this.dgvLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNVLuong,
            this.colTenNVLuong,
            this.colLuong,
            this.colThuong,
            this.colPhat});
            this.dgvLuong.Location = new System.Drawing.Point(613, 226);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.Size = new System.Drawing.Size(598, 239);
            this.dgvLuong.TabIndex = 4;
            // 
            // colMaNVLuong
            // 
            this.colMaNVLuong.HeaderText = "Mã nhân viên";
            this.colMaNVLuong.Name = "colMaNVLuong";
            // 
            // colTenNVLuong
            // 
            this.colTenNVLuong.HeaderText = "Tên nhân viên";
            this.colTenNVLuong.Name = "colTenNVLuong";
            // 
            // colLuong
            // 
            this.colLuong.HeaderText = "Lương cơ bản";
            this.colLuong.Name = "colLuong";
            // 
            // colThuong
            // 
            this.colThuong.HeaderText = "Thưởng";
            this.colThuong.Name = "colThuong";
            // 
            // colPhat
            // 
            this.colPhat.HeaderText = "Phạt";
            this.colPhat.Name = "colPhat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(182)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 33);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phòng ban";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(182)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(613, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 33);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bảng lương";
            // 
            // pnlSoLuongNhanVien
            // 
            this.pnlSoLuongNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.pnlSoLuongNhanVien.Controls.Add(this.label5);
            this.pnlSoLuongNhanVien.Controls.Add(this.lblSoluongNhanVien);
            this.pnlSoLuongNhanVien.Location = new System.Drawing.Point(26, 20);
            this.pnlSoLuongNhanVien.Name = "pnlSoLuongNhanVien";
            this.pnlSoLuongNhanVien.Size = new System.Drawing.Size(222, 100);
            this.pnlSoLuongNhanVien.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhân viên";
            // 
            // lblSoluongNhanVien
            // 
            this.lblSoluongNhanVien.AutoSize = true;
            this.lblSoluongNhanVien.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoluongNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblSoluongNhanVien.Location = new System.Drawing.Point(15, 8);
            this.lblSoluongNhanVien.Name = "lblSoluongNhanVien";
            this.lblSoluongNhanVien.Size = new System.Drawing.Size(142, 33);
            this.lblSoluongNhanVien.TabIndex = 0;
            this.lblSoluongNhanVien.Text = "Số Lượng";
            // 
            // pnlSoLuongPhongBan
            // 
            this.pnlSoLuongPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.pnlSoLuongPhongBan.Controls.Add(this.label6);
            this.pnlSoLuongPhongBan.Controls.Add(this.lblSoLuongPhongBan);
            this.pnlSoLuongPhongBan.Location = new System.Drawing.Point(291, 20);
            this.pnlSoLuongPhongBan.Name = "pnlSoLuongPhongBan";
            this.pnlSoLuongPhongBan.Size = new System.Drawing.Size(222, 100);
            this.pnlSoLuongPhongBan.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phòng ban";
            // 
            // lblSoLuongPhongBan
            // 
            this.lblSoLuongPhongBan.AutoSize = true;
            this.lblSoLuongPhongBan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuongPhongBan.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongPhongBan.Location = new System.Drawing.Point(12, 8);
            this.lblSoLuongPhongBan.Name = "lblSoLuongPhongBan";
            this.lblSoLuongPhongBan.Size = new System.Drawing.Size(142, 33);
            this.lblSoLuongPhongBan.TabIndex = 0;
            this.lblSoLuongPhongBan.Text = "Số Lượng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(100)))), ((int)(((byte)(147)))));
            this.panel5.Controls.Add(this.lblDayTime);
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Location = new System.Drawing.Point(551, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 100);
            this.panel5.TabIndex = 9;
            // 
            // lblDayTime
            // 
            this.lblDayTime.AutoSize = true;
            this.lblDayTime.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDayTime.ForeColor = System.Drawing.Color.White;
            this.lblDayTime.Location = new System.Drawing.Point(18, 57);
            this.lblDayTime.Name = "lblDayTime";
            this.lblDayTime.Size = new System.Drawing.Size(53, 25);
            this.lblDayTime.TabIndex = 10;
            this.lblDayTime.Text = "Day";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(18, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 25);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time";
            // 
            // tmrRealTime
            // 
            this.tmrRealTime.Enabled = true;
            this.tmrRealTime.Tick += new System.EventHandler(this.tmrRealTime_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1243, 1);
            this.panel3.TabIndex = 10;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colNgaySinh,
            this.colGioitinh,
            this.colDiaChi,
            this.colSDT,
            this.colCCCD,
            this.colEmail,
            this.colChucVu,
            this.colHinhAnh,
            this.colNgayVaoLam});
            this.dgvNhanVien.Location = new System.Drawing.Point(26, 550);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1185, 466);
            this.dgvNhanVien.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(182)))), ((int)(((byte)(141)))));
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(26, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1185, 33);
            this.panel4.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(832, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(957, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(214, 21);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bảng Nhân viên";
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            // 
            // colTenNV
            // 
            this.colTenNV.HeaderText = "Tên nhân viên";
            this.colTenNV.Name = "colTenNV";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colGioitinh
            // 
            this.colGioitinh.HeaderText = "Giới tính";
            this.colGioitinh.Name = "colGioitinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SDT";
            this.colSDT.Name = "colSDT";
            // 
            // colCCCD
            // 
            this.colCCCD.HeaderText = "CCCD";
            this.colCCCD.Name = "colCCCD";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colChucVu
            // 
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.Name = "colChucVu";
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.HeaderText = "Hình ảnh";
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNgayVaoLam
            // 
            this.colNgayVaoLam.HeaderText = "Ngày vào làm";
            this.colNgayVaoLam.Name = "colNgayVaoLam";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1241, 1068);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlSoLuongPhongBan);
            this.Controls.Add(this.pnlSoLuongNhanVien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.label1);
            this.Name = "frmTrangChu";
            this.Text = "Trang_chủ";
            this.Load += new System.EventHandler(this.frmTrangchu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSoLuongNhanVien.ResumeLayout(false);
            this.pnlSoLuongNhanVien.PerformLayout();
            this.pnlSoLuongPhongBan.ResumeLayout(false);
            this.pnlSoLuongPhongBan.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMota;
        private System.Windows.Forms.Panel pnlSoLuongNhanVien;
        private System.Windows.Forms.Panel pnlSoLuongPhongBan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer tmrRealTime;
        private System.Windows.Forms.Label lblSoluongNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoLuongPhongBan;
        private System.Windows.Forms.Label lblDayTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNVLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNVLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewImageColumn colHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayVaoLam;
    }
}