using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Form findOpenedForm(string formID)// cái này để nó ko hiện 2 form--- truyền vào tên form
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(formID))
                {
                    return f;
                }
            }
            return null;
        }
        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("KHACHHANG");
            if (f == null)
            {
                f = new KHACHHANG();
                f.MdiParent = this;
            }
            
            f.Show();
            f.Activate();
        }

        private void loạiKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("LOAIKH");
            if (f == null)
            {
                f = new LOAIKH();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("NHANVIEN");
            if (f == null)
            {
                f = new NHANVIEN();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
      
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("HOADON");
            if (f == null)
            {
                f = new HOADON();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ngô Hồng Quân - 14A1 \n Phạm Minh Hòa - 14A1 \n Nguyễn Xuân Lợi - 14A1 \n Phan Đức Thịnh- 14A1");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();///thê là thoat r
        }

        private void giáoViênHướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyễn Thị Tâm");
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("FCRHOADON");
            if (f == null)
            {
                f = new FCRHOADON();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
           
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("FCRKHACHHANG");
            if (f == null)
            {
                f = new FCRKHACHHANG();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
           
        }
    }
}
