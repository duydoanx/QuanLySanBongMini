using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini.SecondaryForm
{
    public partial class FNhapGiaMatHang : Form
    {
        public float donGia { get; set; }
        public FNhapGiaMatHang()
        {
            InitializeComponent();
            
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            donGia = int.Parse(tbDonGia.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
