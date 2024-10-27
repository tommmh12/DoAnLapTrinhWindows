namespace DoAnLapTrinhWindows
{
    partial class frmBaoCAo
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
            this.btnReportLuong = new DevExpress.XtraEditors.SimpleButton();
            this.btnReportNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBaoCao = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReportLuong);
            this.panel1.Controls.Add(this.btnReportNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnReportLuong
            // 
            this.btnReportLuong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReportLuong.Location = new System.Drawing.Point(160, 0);
            this.btnReportLuong.Name = "btnReportLuong";
            this.btnReportLuong.Size = new System.Drawing.Size(185, 38);
            this.btnReportLuong.TabIndex = 1;
            this.btnReportLuong.Text = "Báo cáo danh sách lương";
            this.btnReportLuong.Click += new System.EventHandler(this.btnReportLuong_Click);
            // 
            // btnReportNhanVien
            // 
            this.btnReportNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReportNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnReportNhanVien.Name = "btnReportNhanVien";
            this.btnReportNhanVien.Size = new System.Drawing.Size(160, 38);
            this.btnReportNhanVien.TabIndex = 0;
            this.btnReportNhanVien.Text = "Báo cáo danh sách nhân viên";
            this.btnReportNhanVien.Click += new System.EventHandler(this.btnReportNhanVien_Click);
            // 
            // pnlBaoCao
            // 
            this.pnlBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaoCao.Location = new System.Drawing.Point(0, 38);
            this.pnlBaoCao.Name = "pnlBaoCao";
            this.pnlBaoCao.Size = new System.Drawing.Size(1233, 593);
            this.pnlBaoCao.TabIndex = 1;
            // 
            // frmBaoCAo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 631);
            this.Controls.Add(this.pnlBaoCao);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCAo";
            this.Text = "frmBaoCAo";
            this.Load += new System.EventHandler(this.frmBaoCAo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnReportNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnReportLuong;
        private System.Windows.Forms.Panel pnlBaoCao;
    }
}