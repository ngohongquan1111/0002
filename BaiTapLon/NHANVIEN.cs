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

namespace BaiTapLon
{
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
        }
        private string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
        private void Form4_Load(object sender, EventArgs e)
        {
            Show();
            btDel.Enabled = false;
            btEdit.Enabled = false;
        }
       
        private void Show(string filter ="" )
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Hiennv", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }
        private void add()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            int n=18;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Themnv", cnn))
                {
                   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tennv", txtName.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txtBirt.Text));
                  // (DateTime.Today.Year - DateTime.Parse(txtBirt.Text).Year) <= n;
                    cmd.Parameters.AddWithValue("@diachi", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtPhone.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            add();
            Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btDel.Enabled = true;
            btEdit.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            int dong = e.RowIndex;
            txtID.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            txtBirt.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            txtAdd.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();


        }

        private void Edit()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CapNhatnv", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pk_manv", txtID.Text);
                    cmd.Parameters.AddWithValue("@tennv", txtName.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txtBirt.Text));
                    cmd.Parameters.AddWithValue("@diachi", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtPhone.Text);
                    //cmd.Parameters.AddWithValue("@socmnd", txtID.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

               
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Edit();
            Show();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Xoanv", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pk_manv", txtID.Text);
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            DataTable tb = new DataTable();
                            ad.Fill(tb);
                            dataGridView1.DataSource = tb;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            string select = "select pk_manv as[Mã nhân viên], tennv as [Họ Tên],CONVERT(nvarchar(11),ngaysinh,103) as [Ngày sinh],diachi as [Địa chỉ],sdt as [Số ĐT]"
              + "from tbl_nhanvien where pk_manv is not null ";
            if (txtID.Text != "") select = select + "and pk_manv=" + txtID.Text;
            if (txtName.Text != "") select = select + "and tennv like N'%" + txtName.Text + "%'";
            //if (txtBirt.Text!="") select = select + "and ngaysinh ='" + txtBirt.Text + "'";
            if (txtPhone.Text != "") select = select + "and sdt = '" + txtPhone.Text + "'";
            if (txtAdd.Text != "") select = select + "and diachi like N'%" + txtAdd.Text + "%'";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(select, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }
    }
}
