using QuanLySanBongMini.BUS;
using QuanLySanBongMini.DTO;
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

namespace QuanLySanBongMini.SecondaryForm
{
    public partial class FDoiSan : Form
    {
        private ArrayList sanBongList = new ArrayList();
        private SanBong sanBong;
        public FDoiSan(SanBong sanBong)
        {
            InitializeComponent();
            this.sanBong = sanBong;
        }
        private void updateListViewSan()
        {
            ArrayList dataList = SanBongBUS.getAllSan();
            lvSanBong.Clear();
            sanBongList.Clear();

            foreach (SanBong sanBong in dataList)
            {                
                if (!sanBong.dangThue)
                {
                    lvSanBong.Items.Add(sanBong.tenSan, 0);
                    sanBongList.Add(sanBong);
                }
                else
                {
                    
                }
            }
            
        }

        private void btDoiSan_Click(object sender, EventArgs e)
        {
            PhieuDatSanBong phieuDatSanBong = PhieuDatSanBongBUS.getLatestPhieuDatSanBong(sanBong.id);
            SanBong sanBongDoi = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
            phieuDatSanBong.idSanBong = sanBongDoi.id;
            

            if (!PhieuDatSanBongBUS.updatePhieuDatSanBong(phieuDatSanBong))
            {
                MessageBox.Show("That Bai");
            }
            this.Close();
        }

        private void FDoiSan_Load(object sender, EventArgs e)
        {
            updateListViewSan();
        }
    }
}
