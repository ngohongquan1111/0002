using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BaiTapLon
{
    public partial class HOADON : Form
    {   
        
        public HOADON()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Show();
            loadCBB();
            btDel.Enabled = false;
            btEdit.Enabled = false;
            btSave.Enabled = false;
            bttTinh.Enabled = false;
           
        }
        private void Show()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Hienhd", cnn))
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
        private void Add()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Themhd", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fk_makh", txtCID.Text);
                    cmd.Parameters.AddWithValue("@chisomoi", txtNI.Text);
                    cmd.Parameters.AddWithValue("@chisocu", txtOI.Text);
                   cmd.Parameters.AddWithValue("@fk_manv", txtSID.Text);
                    cmd.Parameters.AddWithValue("@ngaylap", DateTime.Parse(txtDate.Text));           
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
            btSave.Enabled = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEdit.Enabled = true;
            btDel.Enabled = true;
        }

        // = số nước * đơn giá 1 nếu dùng thấp hơn 50 số
        // = 50*đơn giá 1 +(số nước dư*đơn giá 2) nếu dùng thấp hơn 100 số
        //= 50*đơn giá 1 + 50*đơn giá 2 + (số nước dư*đơn giá 3) nếu dừng hơn 100 số

        private void tinhtien()
        {
            double m1 = Convert.ToDouble(txtGM1.Text)*50;
            double m2 = Convert.ToDouble(txtGM2.Text) * 50;
            double g1, g2, g3, sn,tt;
            g1 = Convert.ToDouble(txtGM1.Text);
            g2 = Convert.ToDouble(txtGM2.Text);
            g3 = Convert.ToDouble(txtGM3.Text);
            sn = Convert.ToDouble(txtSN.Text);
            if(sn <50)
            {
                tt = sn * g1;
                txtPrice.Text = tt.ToString();
            }
            if (sn > 50 || sn < 100)
            {
                tt = (m1) + (sn - 50) * g2;
                txtPrice.Text = tt.ToString();
            }
            if (sn>100)
            {
                tt = m1 + m2 + (sn - 100) * g3;
                txtPrice.Text = tt.ToString();

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
                        txtLoaiKH.DataSource = tb;
                        txtLoaiKH.DisplayMember = "tenloaikh";
                        txtLoaiKH.ValueMember = "pk_maloaikh";
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1_CellClick(sender, e);
            int dong = e.RowIndex;
            txtBID.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txtCID.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();
            txtNI.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            txtOI.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            txtSID.Text = dataGridView1.Rows[dong].Cells[7].Value.ToString();
            txtDate.Text = dataGridView1.Rows[dong].Cells[9].Value.ToString();

        }
        private void Del()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Xoahd", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pk_mahoadon", txtBID.Text);
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
        private void btDel_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Del();
                Show();
            }
        }

        private void Edit()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_capnhathd", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;     
                    cmd.Parameters.AddWithValue("@pk_mahoadon", txtBID.Text);
                    cmd.Parameters.AddWithValue("@fk_makh", txtCID.Text);
                    cmd.Parameters.AddWithValue("@fk_manv", txtSID.Text);
                    cmd.Parameters.AddWithValue("@chisomoi", txtNI.Text);
                    cmd.Parameters.AddWithValue("@chisocu", txtOI.Text);
                    cmd.Parameters.AddWithValue("@ngaylap", DateTime.Parse(txtDate.Text));
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

        private void btSave_Click(object sender, EventArgs e)
        {
            Add();
            Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("f5cbb", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tenloaikh", txtLoaiKH.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView2.DataSource = tb;
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtCSC.Text = dataGridView2.Rows[dong].Cells[2].Value.ToString();
            txtCSM.Text = dataGridView2.Rows[dong].Cells[1].Value.ToString();
            txtSN.Text = dataGridView2.Rows[dong].Cells[3].Value.ToString();
            txtGM1.Text = dataGridView2.Rows[dong].Cells[6].Value.ToString();
            txtGM2.Text = dataGridView2.Rows[dong].Cells[7].Value.ToString();
            txtGM3.Text = dataGridView2.Rows[dong].Cells[8].Value.ToString();
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bttTinh.Enabled = true;
        }

        private void bttTinh_Click(object sender, EventArgs e)
        {
            tinhtien();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
