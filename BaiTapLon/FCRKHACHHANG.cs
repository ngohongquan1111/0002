using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace BaiTapLon
{
    public partial class FCRKHACHHANG : Form
    {
        public FCRKHACHHANG()
        {
            InitializeComponent();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            loadCRR();
        }
        private void loadCBB()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("gioitinh", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        comboBox1.DataSource = tb;
                        comboBox1.DisplayMember = "gioitinh";
                       comboBox1.ValueMember = "gioitinh";
                    }
                }
            }
        }
        private void loadCRR()
        {
            

            ReportDocument cr = new ReportDocument();
            cr.Load(@"E:\Visual Studio Workspace\BaiTapLon\BaiTapLon\CRKHACHHANG.rpt");
            DD = comboBox1.SelectedValue.ToString();
            if (comboBox1.SelectedValue.ToString().Equals("Nam"))
            {
                cr.RecordSelectionFormula = "{tbl_khachhang.gioitinh}='Nam'";
            };               
            if (comboBox1.SelectedValue.ToString().Equals("Nữ")) { 
                    cr.RecordSelectionFormula = "{tbl_khachhang.gioitinh}='Nữ'";
            };

    
             crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void FCRKHACHHANG_Load(object sender, EventArgs e)
        {
            loadCBB();
        }
    }
}
