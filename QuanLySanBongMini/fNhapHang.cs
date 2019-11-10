using QuanLySanBongMini.BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class fNhapHang : Form
    {
        private ArrayList nganhHangList = new ArrayList();
        public fNhapHang()
        {
            InitializeComponent();
        }

        private void updateListView()
        {
            ArrayList dataList = NganhHangBUS.getAllNganhHang();
            lvNganhHang.Clear();
            nganhHangList.Clear();

            foreach (SanBong sanBong in dataList)
            {
                sanBongList.Add(sanBong);
                lvSanBong.Items.Add(sanBong.tenSan, 0);
            }
            btSuaSan.Enabled = false;
            btXoaSan.Enabled = false;
        }

        private void fNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void btThemNganhHang_Click(object sender, EventArgs e)
        {

        }
    }
}
