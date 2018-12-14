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
    public partial class LOAIKH : Form
    {
        public LOAIKH()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Show1();
            btDel.Enabled = false;
            btUpdate.Enabled = false;
            //loadCBB();
           thongke();
            
        }
        private void Show1()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_HienLoaiKH", cnn))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            int dong = e.RowIndex;
            txtID.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            txtPrice1.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            txtPrice2.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            txtPrice3.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btDel.Enabled = true;
            btUpdate.Enabled = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ThemLoaiKH", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tenloaikh", txtName.Text);
                    cmd.Parameters.AddWithValue("@dongia", txtPrice1.Text);
                    cmd.Parameters.AddWithValue("@dongia2", txtPrice2.Text);
                    cmd.Parameters.AddWithValue("@dongia3", txtPrice3.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            Show1();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CapnhatLKH", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pk_maloaikh", txtID.Text);
                    cmd.Parameters.AddWithValue("@tenloaikh", txtName.Text);
                    cmd.Parameters.AddWithValue("@dongia", txtPrice1.Text);
                    cmd.Parameters.AddWithValue("@dongia2", txtPrice2.Text);
                    cmd.Parameters.AddWithValue("@dongia3", txtPrice3.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            Show1();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_XoaLKH", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pk_maloaikh", txtID.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }Show1();
        }
        //private void loadCBB()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
        //    using (SqlConnection cnn = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("showcbb", cnn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
        //            {
        //                DataTable tb = new DataTable();
        //                ad.Fill(tb);
        //                comboBox1.DataSource = tb;
        //                comboBox1.DisplayMember = "tenloaikh";
        //                comboBox1.ValueMember = "pk_maloaikh";
        //            }
        //        }
        //    }
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void thongke()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbobtl"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("f3", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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

        //private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    thongke();
        //}
    }
}
    

