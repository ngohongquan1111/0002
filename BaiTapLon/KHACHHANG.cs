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
    public partial class KHACHHANG : Form
    {
        public KHACHHANG()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();
     
            loadCBB();
            btDel.Enabled = false;
            btEdit.Enabled = false;
        }
        private void Show()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_HienKH",cnn))
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
        private void loadCBB()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("showcbb", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        comboBox1.DataSource = tb;
                        comboBox1.DisplayMember = "tenloaikh";
                        comboBox1.ValueMember = "pk_maloaikh";
                    }
                }
            }
        }
       
        private void add()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            string GT;
           
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ThemKH", cnn))
                {
                    if (btnNam.Checked)
                    {
                        GT = "Nam";
                       
                    }
                    else
                    {
                        GT = "Nữ";
                      
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tenkh", txtName.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txtBirt.Text));
                    cmd.Parameters.AddWithValue("@gioitinh", GT);
                    cmd.Parameters.AddWithValue("@diachi",txtAdd.Text);
                    cmd.Parameters.AddWithValue("@sdt",txtPhone.Text);
                    cmd.Parameters.AddWithValue("@socmnd",txtID.Text);
                    cmd.Parameters.AddWithValue("@maloaikh", comboBox1.SelectedValue.ToString());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            int dong = e.RowIndex;
            txtName.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            txtBirt.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            txtAdd.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[dong].Cells[5].Value.ToString();
            txtID.Text = dataGridView1.Rows[dong].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dong].Cells[7].Value.ToString();
            txtKey.Text=dataGridView1.Rows[dong].Cells[0].Value.ToString(); 
            string gt = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (gt.Trim() == "Nam")
            {
                btnNam.Checked = true;
            }
            else
            {
                btnNu.Checked = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btDel.Enabled = true;
            btEdit.Enabled = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            string GT;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CapNhat", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (btnNam.Checked)
                    {
                        GT = "Nam";
                       
                    }
                    else
                    {
                        GT = "Nữ";
                       
                    }
                    cmd.Parameters.AddWithValue("@pk_makh", txtKey.Text);
                    cmd.Parameters.AddWithValue("@tenkh", txtName.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txtBirt.Text));
                    cmd.Parameters.AddWithValue("@gioitinh", GT);
                    cmd.Parameters.AddWithValue("@diachi", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@socmnd", txtID.Text);
                    cmd.Parameters.AddWithValue("@maloaikh", comboBox1.SelectedValue.ToString());
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
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
                    using (SqlCommand cmd = new SqlCommand("sp_XoaKH", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pk_makh", txtKey.Text);
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
        private void Lookup()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            string select = "select pk_makh as[Mã khách hàng], tenkh as [Họ Tên],CONVERT(nvarchar(11),ngaysinh,103) as [Ngày sinh] , gioitinh as [Giới tính],diachi as [Địa chỉ],sdt as [Số ĐT],socmnd as [Số CMND],tenloaikh as [Loại KH]"
              + "from tbl_khachhang inner join tbl_loaikh on tbl_khachhang.maloaikh = tbl_loaikh.pk_maloaikh  where pk_makh is not null ";
            if (txtKey.Text != "") select = select + "and pk_makh=" + txtKey.Text;
            if (txtName.Text != "") select = select + "and tenKH like N'%" + txtName.Text + "%'";
            //if (txtBirt.Text!="") select = select + "and ngaysinh ='" + txtBirt.Text + "'";
            if (txtPhone.Text!="") select = select +"and sdt = '" + txtPhone.Text + "'";
            if (txtAdd.Text!="") select = select + "and diachi like N'%" + txtAdd.Text + "%'";
            if (txtID.Text !="") select = select + "and socmnd = '" + txtID.Text + "'";
           // if (comboBox1.Text != "") select = select + "and  tenloaikh ='" + comboBox1.Text + "'";
            if (btnNam.Checked) select = select + "and gioitinh=N'"+btnNam.Text + "'";
            if (btnNu.Checked) select = select + "and gioitinh=N'" + btnNu.Text + "'";
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

        private void btLookUp_Click(object sender, EventArgs e)
        {
            Lookup();
        

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
        //    using (SqlConnection cnn = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("cn1", cnn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
        //            {
        //                DataTable tb = new DataTable();
        //                ad.Fill(tb);
        //               dataGridView1.DataSource = tb;
        //                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //            }
        //        }
        //    } 
        //}
    }
}
