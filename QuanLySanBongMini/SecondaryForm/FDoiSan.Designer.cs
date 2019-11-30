namespace QuanLySanBongMini.SecondaryForm
{
    partial class FDoiSan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Sân 1", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDoiSan));
            this.btDoiSan = new System.Windows.Forms.Button();
            this.lvSanBong = new System.Windows.Forms.ListView();
            this.largeIcon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btDoiSan
            // 
            this.btDoiSan.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiSan.Image = global::QuanLySanBongMini.Properties.Resources.available_updates_34px;
            this.btDoiSan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDoiSan.Location = new System.Drawing.Point(111, 471);
            this.btDoiSan.Name = "btDoiSan";
            this.btDoiSan.Size = new System.Drawing.Size(93, 65);
            this.btDoiSan.TabIndex = 1;
            this.btDoiSan.Text = "Đổi Sân";
            this.btDoiSan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDoiSan.UseVisualStyleBackColor = true;
            this.btDoiSan.Click += new System.EventHandler(this.btDoiSan_Click);
            // 
            // lvSanBong
            // 
            this.lvSanBong.AutoArrange = false;
            this.lvSanBong.HideSelection = false;
            this.lvSanBong.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvSanBong.LargeImageList = this.largeIcon;
            this.lvSanBong.Location = new System.Drawing.Point(13, 13);
            this.lvSanBong.Margin = new System.Windows.Forms.Padding(4);
            this.lvSanBong.MultiSelect = false;
            this.lvSanBong.Name = "lvSanBong";
            this.lvSanBong.Size = new System.Drawing.Size(295, 451);
            this.lvSanBong.TabIndex = 35;
            this.lvSanBong.UseCompatibleStateImageBehavior = false;
            // 
            // largeIcon
            // 
            this.largeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeIcon.ImageStream")));
            this.largeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.largeIcon.Images.SetKeyName(0, "pitch.png");
            this.largeIcon.Images.SetKeyName(1, "pitch (1).png");
            // 
            // FDoiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 544);
            this.Controls.Add(this.lvSanBong);
            this.Controls.Add(this.btDoiSan);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDoiSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi Sân";
            this.Load += new System.EventHandler(this.FDoiSan_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btDoiSan;
        private System.Windows.Forms.ListView lvSanBong;
        private System.Windows.Forms.ImageList largeIcon;
    }
}