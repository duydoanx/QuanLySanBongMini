namespace QuanLySanBongMini
{
    partial class fNhapMatHang
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "1",
            "10",
            "1564"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapMatHang));
            this.cbNganhHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMatHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.btNhap = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvNhapHang = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idMatHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNganhHang
            // 
            this.cbNganhHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNganhHang.FormattingEnabled = true;
            this.cbNganhHang.Location = new System.Drawing.Point(14, 40);
            this.cbNganhHang.Name = "cbNganhHang";
            this.cbNganhHang.Size = new System.Drawing.Size(109, 21);
            this.cbNganhHang.TabIndex = 0;
            this.cbNganhHang.SelectedIndexChanged += new System.EventHandler(this.cbNganhHang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngành hàng";
            // 
            // cbMatHang
            // 
            this.cbMatHang.FormattingEnabled = true;
            this.cbMatHang.Location = new System.Drawing.Point(129, 39);
            this.cbMatHang.Name = "cbMatHang";
            this.cbMatHang.Size = new System.Drawing.Size(167, 21);
            this.cbMatHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên mặt hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudTongTien);
            this.panel1.Controls.Add(this.btNhap);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpNgayNhap);
            this.panel1.Controls.Add(this.nudSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbNganhHang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbMatHang);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 131);
            this.panel1.TabIndex = 4;
            // 
            // nudTongTien
            // 
            this.nudTongTien.Location = new System.Drawing.Point(360, 40);
            this.nudTongTien.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.Size = new System.Drawing.Size(79, 20);
            this.nudTongTien.TabIndex = 12;
            // 
            // btNhap
            // 
            this.btNhap.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhap.Image = global::QuanLySanBongMini.Properties.Resources.plus_25px;
            this.btNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhap.Location = new System.Drawing.Point(291, 76);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(71, 44);
            this.btNhap.TabIndex = 5;
            this.btNhap.Text = "Nhập";
            this.btNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::QuanLySanBongMini.Properties.Resources.delete_25px;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(368, 76);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(71, 44);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(14, 102);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(109, 20);
            this.dtpNgayNhap.TabIndex = 4;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(302, 40);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(46, 20);
            this.nudSoLuong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // lvNhapHang
            // 
            this.lvNhapHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.idMatHang,
            this.ngayNhap,
            this.soLuong,
            this.tongTien});
            this.lvNhapHang.FullRowSelect = true;
            this.lvNhapHang.HideSelection = false;
            this.lvNhapHang.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvNhapHang.Location = new System.Drawing.Point(15, 181);
            this.lvNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.lvNhapHang.MultiSelect = false;
            this.lvNhapHang.Name = "lvNhapHang";
            this.lvNhapHang.Size = new System.Drawing.Size(458, 199);
            this.lvNhapHang.TabIndex = 5;
            this.lvNhapHang.UseCompatibleStateImageBehavior = false;
            this.lvNhapHang.View = System.Windows.Forms.View.Details;
            this.lvNhapHang.SelectedIndexChanged += new System.EventHandler(this.lvNhapHang_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // idMatHang
            // 
            this.idMatHang.Text = "Mặt Hàng";
            this.idMatHang.Width = 143;
            // 
            // ngayNhap
            // 
            this.ngayNhap.Text = "Ngày nhập";
            this.ngayNhap.Width = 96;
            // 
            // soLuong
            // 
            this.soLuong.Text = "Số lượng";
            // 
            // tongTien
            // 
            this.tongTien.Text = "Tổng tiền";
            this.tongTien.Width = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lịch sử nhập";
            // 
            // fNhapMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 391);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvNhapHang);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fNhapMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.fNhapMatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNganhHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ListView lvNhapHang;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader idMatHang;
        private System.Windows.Forms.ColumnHeader ngayNhap;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader tongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTongTien;
    }
}