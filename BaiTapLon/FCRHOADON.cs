using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace BaiTapLon
{
    public partial class FCRHOADON : Form
    {
        public FCRHOADON()
        {
            InitializeComponent();
        }

        private void FCRHOADON_Load(object sender, EventArgs e)
        {
            ReportDocument cr = new ReportDocument();
            cr.Load(@"E:\Visual Studio Workspace\BaiTapLon\BaiTapLon\CRHOADON.rpt");
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
