namespace QuanLySanBongMini
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.tbPassWord);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.lbPassWord);
            this.panel1.Controls.Add(this.lbUserName);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Image = global::QuanLySanBongMini.Properties.Resources.delete_sign_64px;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbPassWord
            // 
            resources.ApplyResources(this.tbPassWord, "tbPassWord");
            this.tbPassWord.Name = "tbPassWord";
            this.toolTip1.SetToolTip(this.tbPassWord, resources.GetString("tbPassWord.ToolTip"));
            this.tbPassWord.UseSystemPasswordChar = true;
            this.tbPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassWord_KeyPress);
            // 
            // tbUserName
            // 
            resources.ApplyResources(this.tbUserName, "tbUserName");
            this.tbUserName.Name = "tbUserName";
            this.toolTip1.SetToolTip(this.tbUserName, resources.GetString("tbUserName.ToolTip"));
            // 
            // lbPassWord
            // 
            resources.ApplyResources(this.lbPassWord, "lbPassWord");
            this.lbPassWord.Name = "lbPassWord";
            // 
            // lbUserName
            // 
            resources.ApplyResources(this.lbUserName, "lbUserName");
            this.lbUserName.Name = "lbUserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLySanBongMini.Properties.Resources.password_64px;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btLogin, "btLogin");
            this.btLogin.Image = global::QuanLySanBongMini.Properties.Resources.forward_64px;
            this.btLogin.Name = "btLogin";
            this.btLogin.Tag = "";
            this.toolTip1.SetToolTip(this.btLogin, resources.GetString("btLogin.ToolTip"));
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // FLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FLogin";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

