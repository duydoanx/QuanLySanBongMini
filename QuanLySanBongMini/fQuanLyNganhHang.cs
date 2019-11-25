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
    public partial class FQuanLyNganhHang : Form
    {
        private ArrayList nganhHangList = new ArrayList();
        public FQuanLyNganhHang()
        {
            InitializeComponent();
        }

        private void updateListViewSan()
        {
            ArrayList dataList = NganhHangBUS.getAllNganhHang();
            lvNganhHang.Clear();
            nganhHangList.Clear();

            foreach (NganhHang nganhHang in dataList)
            {
                nganhHangList.Add(nganhHang);
                lvNganhHang.Items.Add(nganhHang.tenNganhHang, 0);
            }
            btSuaNganhHang.Enabled = false;
            btXoaNganhHang.Enabled = false;
        }

        private void fNhapHang_Load(object sender, EventArgs e)
        {
            updateListViewSan();
        }

        private void btThemNganhHang_Click(object sender, EventArgs e)
        {
            if (tbtenNganhHang.Text.Length > 0)
            {
                if (!BUS.NganhHangBUS.addNganhHang(tbtenNganhHang.Text))
                {
                    MessageBox.Show("Không thể thêm ngành hàng, vui lòng đổi tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    tbtenNganhHang.Text = "";
                    updateListViewSan();
                   
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm ngành hàng, vui lòng nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        bool kiemTraTrungTen(string ten)
        {
            bool kt = true;

            foreach (NganhHang nganhHang in nganhHangList)
            {
                if (nganhHang.tenNganhHang == ten)
                {
                    kt = false;
                    break;
                }
            }

            return kt;
        }

        private void btSuaNganhHang_Click(object sender, EventArgs e)
        {
            int id = ((NganhHang)nganhHangList[lvNganhHang.SelectedIndices[0]]).id;
            if (tbtenNganhHang.Text != "" && kiemTraTrungTen(tbtenNganhHang.Text))
            {
                if (NganhHangBUS.updateTenNganhHang(id, tbtenNganhHang.Text))
                {
                    updateListViewSan();
                    
                }
                else
                {
                    MessageBox.Show("Không thể sửa tên ngành hàng!" + lvNganhHang.SelectedItems[0].Text, "Lỗi khi sửa tên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            else
            {
                MessageBox.Show("Không thể sửa tên ngành hàng!" + lvNganhHang.SelectedItems[0].Text, "Lỗi khi sửa tên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void lvNganhHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNganhHang.SelectedItems.Count > 0)
            {
                tbtenNganhHang.Text = (lvNganhHang.SelectedItems[0]).Text;
                btSuaNganhHang.Enabled = true;
                btXoaNganhHang.Enabled = true;
            }
            else
            {
                tbtenNganhHang.Text = "";
                btSuaNganhHang.Enabled = false;
                btXoaNganhHang.Enabled = false;
            }
        }

        private void btXoaNganhHang_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa ngành hàng " + lvNganhHang.SelectedItems[0].Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (!NganhHangBUS.deleteNganhHang(((NganhHang)nganhHangList[lvNganhHang.SelectedIndices[0]]).id))
                {
                    MessageBox.Show("Không thể xóa ngành hàng " + lvNganhHang.SelectedItems[0].Text, "Lỗi khi xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                else
                {
                    updateListViewSan();
                    tbtenNganhHang.Text = "";                   
                    btSuaNganhHang.Enabled = false;
                    btSuaNganhHang.Enabled = false;
                }
            }
        }

        private void tbtenNganhHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btThemNganhHang_Click(sender, e);
            }
        }
    }
}
