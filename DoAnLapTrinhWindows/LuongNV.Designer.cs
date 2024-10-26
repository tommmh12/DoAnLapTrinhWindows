namespace DoAnLapTrinhWindows
{
    partial class frmLuongNV
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grpThongTinLuongNhanVien = new System.Windows.Forms.GroupBox();
            this.txtPhat = new System.Windows.Forms.TextBox();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.dgvLuongNV = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSapXep = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.timerXuatFile = new System.Windows.Forms.Timer(this.components);
            this.pnlDropdown = new System.Windows.Forms.Panel();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtLuongThucNhan = new System.Windows.Forms.TextBox();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuongCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.grpThongTinLuongNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 11);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(320, 45);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Lương Nhân Viên";
            // 
            // grpThongTinLuongNhanVien
            // 
            this.grpThongTinLuongNhanVien.Controls.Add(this.txtTenNV);
            this.grpThongTinLuongNhanVien.Controls.Add(this.txtMaNV);
            this.grpThongTinLuongNhanVien.Controls.Add(this.txtLuongThucNhan);
            this.grpThongTinLuongNhanVien.Controls.Add(this.txtPhat);
            this.grpThongTinLuongNhanVien.Controls.Add(this.txtThuong);
            this.grpThongTinLuongNhanVien.Controls.Add(this.labelControl9);
            this.grpThongTinLuongNhanVien.Controls.Add(this.labelControl1);
            this.grpThongTinLuongNhanVien.Controls.Add(this.labelControl2);
            this.grpThongTinLuongNhanVien.Controls.Add(this.labelControl3);
            this.grpThongTinLuongNhanVien.Controls.Add(this.labelControl8);
            this.grpThongTinLuongNhanVien.Controls.Add(this.labelControl4);
            this.grpThongTinLuongNhanVien.Controls.Add(this.txtLuong);
            this.grpThongTinLuongNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinLuongNhanVien.Location = new System.Drawing.Point(12, 118);
            this.grpThongTinLuongNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTinLuongNhanVien.Name = "grpThongTinLuongNhanVien";
            this.grpThongTinLuongNhanVien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTinLuongNhanVien.Size = new System.Drawing.Size(491, 402);
            this.grpThongTinLuongNhanVien.TabIndex = 16;
            this.grpThongTinLuongNhanVien.TabStop = false;
            this.grpThongTinLuongNhanVien.Text = "Thông Tin Lương Nhân Viên";
            // 
            // txtPhat
            // 
            this.txtPhat.Location = new System.Drawing.Point(179, 281);
            this.txtPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhat.Name = "txtPhat";
            this.txtPhat.Size = new System.Drawing.Size(176, 23);
            this.txtPhat.TabIndex = 8;
            this.txtPhat.TextChanged += new System.EventHandler(this.txtPhat_TextChanged);
            // 
            // txtThuong
            // 
            this.txtThuong.Location = new System.Drawing.Point(179, 228);
            this.txtThuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.Size = new System.Drawing.Size(176, 23);
            this.txtThuong.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 51);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã Nhân Viên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 176);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Lương Cơ Bản:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(36, 234);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Thưởng:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 286);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Phạt:";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(179, 174);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(176, 23);
            this.txtLuong.TabIndex = 0;
            // 
            // dgvLuongNV
            // 
            this.dgvLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colLuongCoBan,
            this.colThuong,
            this.colPhat,
            this.colLuongCuoi});
            this.dgvLuongNV.Location = new System.Drawing.Point(526, 118);
            this.dgvLuongNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLuongNV.Name = "dgvLuongNV";
            this.dgvLuongNV.RowHeadersWidth = 51;
            this.dgvLuongNV.RowTemplate.Height = 24;
            this.dgvLuongNV.Size = new System.Drawing.Size(675, 446);
            this.dgvLuongNV.TabIndex = 15;
            this.dgvLuongNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuongNV_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Afacad Flux", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(602, 79);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(526, 86);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 18);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Tìm kiếm :";
            // 
            // cmbSapXep
            // 
            this.cmbSapXep.Font = new System.Drawing.Font("Afacad Flux", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbSapXep.FormattingEnabled = true;
            this.cmbSapXep.Location = new System.Drawing.Point(1049, 79);
            this.cmbSapXep.Name = "cmbSapXep";
            this.cmbSapXep.Size = new System.Drawing.Size(121, 25);
            this.cmbSapXep.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(980, 86);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 18);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Sắp xếp :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Location = new System.Drawing.Point(12, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 52);
            this.panel1.TabIndex = 22;
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Location = new System.Drawing.Point(0, 0);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(173, 52);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCapNhat.Location = new System.Drawing.Point(173, 0);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(167, 52);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.Location = new System.Drawing.Point(340, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 52);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // timerXuatFile
            // 
            this.timerXuatFile.Interval = 10;
            this.timerXuatFile.Tick += new System.EventHandler(this.timerXuatFile_Tick);
            // 
            // pnlDropdown
            // 
            this.pnlDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDropdown.Controls.Add(this.btnWord);
            this.pnlDropdown.Controls.Add(this.btnPDF);
            this.pnlDropdown.Controls.Add(this.btnExcel);
            this.pnlDropdown.Controls.Add(this.btnXuatFile);
            this.pnlDropdown.Location = new System.Drawing.Point(1001, 11);
            this.pnlDropdown.MaximumSize = new System.Drawing.Size(200, 178);
            this.pnlDropdown.MinimumSize = new System.Drawing.Size(200, 35);
            this.pnlDropdown.Name = "pnlDropdown";
            this.pnlDropdown.Size = new System.Drawing.Size(200, 35);
            this.pnlDropdown.TabIndex = 23;
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.Silver;
            this.btnWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWord.FlatAppearance.BorderSize = 0;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord.Location = new System.Drawing.Point(0, 130);
            this.btnWord.Margin = new System.Windows.Forms.Padding(0);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(200, 48);
            this.btnWord.TabIndex = 3;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Silver;
            this.btnPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Location = new System.Drawing.Point(0, 82);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(0);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(200, 48);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Silver;
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(0, 34);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(200, 48);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXuatFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuatFile.FlatAppearance.BorderSize = 0;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatFile.Location = new System.Drawing.Point(0, 0);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(200, 34);
            this.btnXuatFile.TabIndex = 0;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(36, 350);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(106, 16);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "Lương Thực Nhận:";
            // 
            // txtLuongThucNhan
            // 
            this.txtLuongThucNhan.Location = new System.Drawing.Point(179, 343);
            this.txtLuongThucNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuongThucNhan.Name = "txtLuongThucNhan";
            this.txtLuongThucNhan.ReadOnly = true;
            this.txtLuongThucNhan.Size = new System.Drawing.Size(176, 23);
            this.txtLuongThucNhan.TabIndex = 8;
            this.txtLuongThucNhan.TextChanged += new System.EventHandler(this.txtPhat_TextChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 125;
            // 
            // colTenNV
            // 
            this.colTenNV.HeaderText = "Tên NV";
            this.colTenNV.Name = "colTenNV";
            // 
            // colLuongCoBan
            // 
            this.colLuongCoBan.HeaderText = "Lương Cơ Bản";
            this.colLuongCoBan.MinimumWidth = 6;
            this.colLuongCoBan.Name = "colLuongCoBan";
            this.colLuongCoBan.Width = 125;
            // 
            // colThuong
            // 
            this.colThuong.HeaderText = "Thưởng";
            this.colThuong.MinimumWidth = 6;
            this.colThuong.Name = "colThuong";
            this.colThuong.Width = 125;
            // 
            // colPhat
            // 
            this.colPhat.HeaderText = "Phạt";
            this.colPhat.MinimumWidth = 6;
            this.colPhat.Name = "colPhat";
            this.colPhat.Width = 125;
            // 
            // colLuongCuoi
            // 
            this.colLuongCuoi.HeaderText = "Lương Thực Nhận";
            this.colLuongCuoi.MinimumWidth = 6;
            this.colLuongCuoi.Name = "colLuongCuoi";
            this.colLuongCuoi.Width = 125;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(179, 48);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(176, 23);
            this.txtMaNV.TabIndex = 9;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(179, 110);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(176, 23);
            this.txtTenNV.TabIndex = 9;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(36, 113);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(89, 16);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Tên Nhân Viên:";
            // 
            // frmLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 655);
            this.Controls.Add(this.pnlDropdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSapXep);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.grpThongTinLuongNhanVien);
            this.Controls.Add(this.dgvLuongNV);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmLuongNV";
            this.Text = "LuongNV";
            this.Load += new System.EventHandler(this.frmLuongNV_Load);
            this.grpThongTinLuongNhanVien.ResumeLayout(false);
            this.grpThongTinLuongNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlDropdown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.GroupBox grpThongTinLuongNhanVien;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.TextBox txtThuong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.DataGridView dgvLuongNV;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cmbSapXep;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Timer timerXuatFile;
        private System.Windows.Forms.Panel pnlDropdown;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnXuatFile;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtLuongThucNhan;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongCuoi;
    }
}