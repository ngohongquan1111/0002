namespace BaiTapLon
{
    partial class HOADON
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtNI = new System.Windows.Forms.MaskedTextBox();
            this.txtOI = new System.Windows.Forms.MaskedTextBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoaiKH = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGM3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGM2 = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtGM1 = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtCSC = new System.Windows.Forms.TextBox();
            this.txtCSM = new System.Windows.Forms.TextBox();
            this.bttTinh = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Lập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chỉ số mới:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chỉ số cũ:";
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(106, 9);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(100, 20);
            this.txtBID.TabIndex = 8;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(106, 36);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(100, 20);
            this.txtCID.TabIndex = 9;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(106, 65);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(100, 20);
            this.txtSID.TabIndex = 10;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(483, 6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 36);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(634, 58);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 36);
            this.btEdit.TabIndex = 16;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(483, 56);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 36);
            this.btDel.TabIndex = 17;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(483, 107);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 35);
            this.btSearch.TabIndex = 18;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtNI
            // 
            this.txtNI.Location = new System.Drawing.Point(321, 35);
            this.txtNI.Mask = "00000";
            this.txtNI.Name = "txtNI";
            this.txtNI.Size = new System.Drawing.Size(100, 20);
            this.txtNI.TabIndex = 19;
            this.txtNI.ValidatingType = typeof(int);
            // 
            // txtOI
            // 
            this.txtOI.Location = new System.Drawing.Point(321, 65);
            this.txtOI.Mask = "00000";
            this.txtOI.Name = "txtOI";
            this.txtOI.Size = new System.Drawing.Size(100, 20);
            this.txtOI.TabIndex = 20;
            this.txtOI.ValidatingType = typeof(int);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(321, 9);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(139, 20);
            this.txtDate.TabIndex = 22;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(634, 6);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 36);
            this.btSave.TabIndex = 23;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(634, 107);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 36);
            this.btExit.TabIndex = 24;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Loại KH:";
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.FormattingEnabled = true;
            this.txtLoaiKH.Location = new System.Drawing.Point(136, 6);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(100, 21);
            this.txtLoaiKH.TabIndex = 26;
            this.txtLoaiKH.SelectedIndexChanged += new System.EventHandler(this.txtLoaiKH_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 442);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btExit);
            this.tabPage1.Controls.Add(this.txtBID);
            this.tabPage1.Controls.Add(this.btEdit);
            this.tabPage1.Controls.Add(this.btSearch);
            this.tabPage1.Controls.Add(this.btSave);
            this.tabPage1.Controls.Add(this.btDel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtOI);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.txtNI);
            this.tabPage1.Controls.Add(this.btAdd);
            this.tabPage1.Controls.Add(this.txtCID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách Hóa Đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtGM3);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtGM2);
            this.tabPage2.Controls.Add(this.txtPrice);
            this.tabPage2.Controls.Add(this.txtGM1);
            this.tabPage2.Controls.Add(this.txtSN);
            this.tabPage2.Controls.Add(this.txtCSC);
            this.tabPage2.Controls.Add(this.txtCSM);
            this.tabPage2.Controls.Add(this.bttTinh);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtLoaiKH);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tính tiền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(513, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "VNĐ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(513, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "VNĐ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(513, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "VNĐ";
            // 
            // txtGM3
            // 
            this.txtGM3.Location = new System.Drawing.Point(389, 73);
            this.txtGM3.Name = "txtGM3";
            this.txtGM3.ReadOnly = true;
            this.txtGM3.Size = new System.Drawing.Size(100, 20);
            this.txtGM3.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(269, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Giá mức 3:";
            // 
            // txtGM2
            // 
            this.txtGM2.Location = new System.Drawing.Point(389, 41);
            this.txtGM2.Name = "txtGM2";
            this.txtGM2.ReadOnly = true;
            this.txtGM2.Size = new System.Drawing.Size(100, 20);
            this.txtGM2.TabIndex = 47;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(359, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(130, 20);
            this.txtPrice.TabIndex = 46;
            // 
            // txtGM1
            // 
            this.txtGM1.Location = new System.Drawing.Point(389, 6);
            this.txtGM1.Name = "txtGM1";
            this.txtGM1.ReadOnly = true;
            this.txtGM1.Size = new System.Drawing.Size(100, 20);
            this.txtGM1.TabIndex = 45;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(136, 106);
            this.txtSN.Name = "txtSN";
            this.txtSN.ReadOnly = true;
            this.txtSN.Size = new System.Drawing.Size(100, 20);
            this.txtSN.TabIndex = 44;
            // 
            // txtCSC
            // 
            this.txtCSC.Location = new System.Drawing.Point(136, 73);
            this.txtCSC.Name = "txtCSC";
            this.txtCSC.ReadOnly = true;
            this.txtCSC.Size = new System.Drawing.Size(100, 20);
            this.txtCSC.TabIndex = 43;
            // 
            // txtCSM
            // 
            this.txtCSM.Location = new System.Drawing.Point(136, 41);
            this.txtCSM.Name = "txtCSM";
            this.txtCSM.ReadOnly = true;
            this.txtCSM.Size = new System.Drawing.Size(100, 20);
            this.txtCSM.TabIndex = 42;
            // 
            // bttTinh
            // 
            this.bttTinh.Location = new System.Drawing.Point(609, 14);
            this.bttTinh.Name = "bttTinh";
            this.bttTinh.Size = new System.Drawing.Size(152, 95);
            this.bttTinh.TabIndex = 41;
            this.bttTinh.Text = "Tính";
            this.bttTinh.UseVisualStyleBackColor = true;
            this.bttTinh.Click += new System.EventHandler(this.bttTinh_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(513, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Thành tiền:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 162);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(782, 248);
            this.dataGridView2.TabIndex = 37;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Chỉ số cũ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Chỉ số mới:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Giá mức 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Giá mức 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số nước:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "HOADON";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.MaskedTextBox txtNI;
        private System.Windows.Forms.MaskedTextBox txtOI;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtLoaiKH;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGM2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtGM1;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtCSC;
        private System.Windows.Forms.TextBox txtCSM;
        private System.Windows.Forms.Button bttTinh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtGM3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
    }
}