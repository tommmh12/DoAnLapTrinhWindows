using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmBaoCAo : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCAo()
        {
            InitializeComponent();
        }

        private void frmBaoCAo_Load(object sender, EventArgs e)
        {

        }

        private void btnReportNhanVien_Click(object sender, EventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            report.ShowPreviewDialog();
        }

        private void btnReportLuong_Click(object sender, EventArgs e)
        {
            XtraReport2 report = new XtraReport2();
            report.ShowPreviewDialog();
        }
    }
}