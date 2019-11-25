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

namespace QuanLySanBongMini
{
    public partial class FQuanLyMatHang : Form
    {
        private ArrayList nganhHangList = new ArrayList();
        private ArrayList matHangList = new ArrayList();
        public FQuanLyMatHang()
        {
            InitializeComponent();
        }

        void LoadNganhHang()
        {
            ArrayList dataList = NganhHangBUS.getAllNganhHang();
            cbNganhHang.Items.Clear();
            nganhHangList.Clear();

            foreach (NganhHang nganhHang in dataList)
            {
                nganhHangList.Add(nganhHang);
                cbNganhHang.Items.Add(nganhHang.tenNganhHang);
            }
            if (cbNganhHang.Items.Count > 0)
            {
                cbNganhHang.SelectedItem = cbNganhHang.Items[0];
                loadLvMatHang();
                btThemMatHang.Enabled = true;
            }
            else
            {
                btThemMatHang.Enabled = false;
            }
        }

        private void loadLvMatHang()
        {
            ArrayList dataList = MatHangBUS.getAllMatHang();
            lvMatHang.Items.Clear();
            matHangList.Clear();

            foreach (MatHang matHang in dataList)
            {
                matHangList.Add(matHang);
                string[] row = { matHang.tenMatHang, matHang.soLuong.ToString(), matHang.donGia.ToString()};
                var listViewItem = new ListViewItem(row);
                lvMatHang.Items.Add(listViewItem);
            }

            btSuaMatHang.Enabled = false;
            btXoaMatHang.Enabled = false;
        }

        private void btThemMatHang_Click(object sender, EventArgs e)
        {
            if (tbTenMatHang.Text != "" || nudDonGia.Value != 0)
            {
                int id = ((NganhHang)nganhHangList[cbNganhHang.SelectedIndex]).id;
                if (!MatHangBUS.addMatHang(new MatHang(tbTenMatHang.Text, id, (float)nudDonGia.Value)))
                {
                    MessageBox.Show("Không thể thêm mặt hàng, vui lòng đổi tên hoặc đơn giá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    loadLvMatHang();
                    tbTenMatHang.Text = "";
                    nudDonGia.Value = 0;
                }
            }
        }

        private void FQuanLyMatHang_Load(object sender, EventArgs e)
        {
            LoadNganhHang();
        }

        private void lvMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMatHang.SelectedItems.Count > 0)
            {
                int idNganhHang = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).idNganhHang;
                int count = 0;
                for(int i = 0; i<nganhHangList.Count; i++)
                {
                    if (idNganhHang == ((NganhHang)nganhHangList[i]).id) 
                    {
                        count = i;
                        break;
                    }
                }

                cbNganhHang.SelectedIndex = count;

                tbTenMatHang.Text = (lvMatHang.SelectedItems[0]).Text;
                nudDonGia.Value = Decimal.Parse(lvMatHang.SelectedItems[0].SubItems[2].Text);
                btSuaMatHang.Enabled = true;
                btXoaMatHang.Enabled = true;
            }
            else
            {
                tbTenMatHang.Text = "";
                nudDonGia.Value = 0;
                btSuaMatHang.Enabled = false;
                btXoaMatHang.Enabled = false;
            }
        }

        private void btSuaMatHang_Click(object sender, EventArgs e)
        {
            int id = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).id;
            int idNganhHang = ((NganhHang)nganhHangList[cbNganhHang.SelectedIndex]).id;

            if (MatHangBUS.updateMatHang(new MatHang(id, tbTenMatHang.Text, idNganhHang, (float)nudDonGia.Value, 0)))
            {
                loadLvMatHang();
            }
            else
            {
                MessageBox.Show("Không thể sửa mặt hàng!", "Lỗi khi sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btXoaMatHang_Click(object sender, EventArgs e)
        {
            int id = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).id;
            if (!MatHangBUS.deleteMatHang(id))
            {
                MessageBox.Show("Không thể xóa mặt hàng!", "Lỗi khi sửa tên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadLvMatHang();
            }
        }
    }
}
