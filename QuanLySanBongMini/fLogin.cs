using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLySanBongMini
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            String username = tbUserName.Text;
            String password = tbPassWord.Text;
            //User user = UserDAO.getUser(username, password);
            if (UserBUS.isExist(username, password))
            {
                MessageBox.Show("thanh cong");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   

        private void tbPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btLogin_Click(sender, e);
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
