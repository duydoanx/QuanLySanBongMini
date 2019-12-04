namespace QuanLySanBongMini
{
    partial class FQuanLyMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuanLyMatHang));
            this.tbTenMatHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.lvMatHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btThemMatHang = new System.Windows.Forms.Button();
            this.btSuaMatHang = new System.Windows.Forms.Button();
            this.btXoaMatHang = new System.Windows.Forms.Button();
            this.cbNganhHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenMatHang
            // 
            this.tbTenMatHang.Location = new System.Drawing.Point(139, 26);
            this.tbTenMatHang.Name = "tbTenMatHang";
            this.tbTenMatHang.Size = new System.Drawing.Size(121, 20);
            this.tbTenMatHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá";
            // 
            // nudDonGia
            // 
            this.nudDonGia.Location = new System.Drawing.Point(266, 25);
            this.nudDonGia.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(73, 20);
            this.nudDonGia.TabIndex = 5;
            // 
            // lvMatHang
            // 
            this.lvMatHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMatHang.FullRowSelect = true;
            this.lvMatHang.HideSelection = false;
            this.lvMatHang.Location = new System.Drawing.Point(12, 98);
            this.lvMatHang.MultiSelect = false;
            this.lvMatHang.Name = "lvMatHang";
            this.lvMatHang.Size = new System.Drawing.Size(327, 247);
            this.lvMatHang.TabIndex = 6;
            this.lvMatHang.UseCompatibleStateImageBehavior = false;
            this.lvMatHang.View = System.Windows.Forms.View.Details;
            this.lvMatHang.SelectedIndexChanged += new System.EventHandler(this.lvMatHang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 179;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 98;
            // 
            // btThemMatHang
            // 
            this.btThemMatHang.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMatHang.Image = global::QuanLySanBongMini.Properties.Resources.plus_25px;
            this.btThemMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMatHang.Location = new System.Drawing.Point(87, 52);
            this.btThemMatHang.Name = "btThemMatHang";
            this.btThemMatHang.Size = new System.Drawing.Size(80, 39);
            this.btThemMatHang.TabIndex = 7;
            this.btThemMatHang.Text = "Thêm";
            this.btThemMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemMatHang.UseVisualStyleBackColor = true;
            this.btThemMatHang.Click += new System.EventHandler(this.btThemMatHang_Click);
            // 
            // btSuaMatHang
            // 
            this.btSuaMatHang.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaMatHang.Image = global::QuanLySanBongMini.Properties.Resources.pencil_tip_34px;
            this.btSuaMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaMatHang.Location = new System.Drawing.Point(173, 52);
            this.btSuaMatHang.Name = "btSuaMatHang";
            this.btSuaMatHang.Size = new System.Drawing.Size(80, 39);
            this.btSuaMatHang.TabIndex = 8;
            this.btSuaMatHang.Text = "Sửa";
            this.btSuaMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaMatHang.UseVisualStyleBackColor = true;
            this.btSuaMatHang.Click += new System.EventHandler(this.btSuaMatHang_Click);
            // 
            // btXoaMatHang
            // 
            this.btXoaMatHang.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaMatHang.Image = global::QuanLySanBongMini.Properties.Resources.delete_25px;
            this.btXoaMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaMatHang.Location = new System.Drawing.Point(259, 52);
            this.btXoaMatHang.Name = "btXoaMatHang";
            this.btXoaMatHang.Size = new System.Drawing.Size(80, 39);
            this.btXoaMatHang.TabIndex = 9;
            this.btXoaMatHang.Text = "Xóa";
            this.btXoaMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaMatHang.UseVisualStyleBackColor = true;
            this.btXoaMatHang.Click += new System.EventHandler(this.btXoaMatHang_Click);
            // 
            // cbNganhHang
            // 
            this.cbNganhHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNganhHang.FormattingEnabled = true;
            this.cbNganhHang.Location = new System.Drawing.Point(12, 26);
            this.cbNganhHang.Name = "cbNganhHang";
            this.cbNganhHang.Size = new System.Drawing.Size(121, 21);
            this.cbNganhHang.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngành hàng";
            // 
            // FQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 357);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNganhHang);
            this.Controls.Add(this.btXoaMatHang);
            this.Controls.Add(this.btSuaMatHang);
            this.Controls.Add(this.btThemMatHang);
            this.Controls.Add(this.lvMatHang);
            this.Controls.Add(this.nudDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenMatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FQuanLyMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý mặt hàng";
            this.Load += new System.EventHandler(this.FQuanLyMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTenMatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.ListView lvMatHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btThemMatHang;
        private System.Windows.Forms.Button btSuaMatHang;
        private System.Windows.Forms.Button btXoaMatHang;
        private System.Windows.Forms.ComboBox cbNganhHang;
        private System.Windows.Forms.Label label4;
    }
}