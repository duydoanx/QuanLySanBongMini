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
using QuanLySanBongMini.DTO;
using QuanLySanBongMini.BUS;
 
namespace QuanLySanBongMini
{
    public partial class fMain : Form
    {
        private bool isAdmin;
        private ArrayList sanBongList = new ArrayList();       

        public fMain(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            if (!isAdmin)
            {
                menu.Items.Remove(adminItem);
            }
        }        

        private void btThemSan_Click(object sender, EventArgs e)
        {
            if (tbTenSan.Text.Length > 0)
            {
                if (!BUS.SanBongBUS.addSan(tbTenSan.Text))
                {
                    MessageBox.Show("Không thể thêm sân, vui lòng đổi tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi thêm sân!");
                }
                else
                {
                    tbTenSan.Text = "";
                    updateListView();
                    statusBarAddText("Đã thêm sân thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm sân, vui lòng nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusBarAddText("Lỗi khi thêm sân!");
            }
        }

        private void updateListView()
        {
            ArrayList dataList = SanBongBUS.getAllSan();
            lvSanBong.Clear();
            sanBongList.Clear();
            
            foreach(SanBong sanBong in dataList)
            {
                sanBongList.Add(sanBong);
                lvSanBong.Items.Add(sanBong.tenSan, 0);                
            }
            btSuaSan.Enabled = false;
            btXoaSan.Enabled = false;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            lvSanBong.Sorting = SortOrder.None;
            updateListView();            
        }        

        private void tbTenSan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btThemSan_Click(sender, e);
            }
        }

        private void lvSanBong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanBong.SelectedItems.Count > 0 )
            {
                tbTenSan.Text = (lvSanBong.SelectedItems[0]).Text;
                btSuaSan.Enabled = true;
                btXoaSan.Enabled = true;
            }
            else
            {
                tbTenSan.Text = "";
                btSuaSan.Enabled = false;
                btXoaSan.Enabled = false;
            }
        }

        private void btXoaSan_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa sân " + lvSanBong.SelectedItems[0].Text, 
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (!SanBongBUS.deleteSan(lvSanBong.SelectedItems[0].Text))
                {
                    MessageBox.Show("Không thể xóa sân " + lvSanBong.SelectedItems[0].Text, "Lỗi khi xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi xóa sân!");
                }
                else
                {
                    updateListView();
                    tbTenSan.Text = "";
                    statusBarAddText("Đã xóa sân thành công!");
                    btSuaSan.Enabled = false;
                    btXoaSan.Enabled = false;
                }
            }
        }

        private void btFormLoad_Click(object sender, EventArgs e)
        {
            fMain_Load(sender, e);
            statusBarAddText("Đã cập nhật dữ liệu!");
        }

        void statusBarAddText(String text)
        {
            statusBar.Items[0].Text = text;
        }

        bool kiemTraTrungTen(string ten)
        {
            bool kt = true;

            foreach (SanBong sanBong in sanBongList)
            {
                if(sanBong.tenSan == ten)
                {
                    kt = false;
                    break;
                }
            }

            return kt;
        }

        private void btSuaSan_Click(object sender, EventArgs e)
        {
            int id = ((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]).id;
            if (tbTenSan.Text != "" && kiemTraTrungTen(tbTenSan.Text))
            {
                if (SanBongBUS.updateTenSan(id, tbTenSan.Text))
                {
                    updateListView();
                    statusBarAddText("Đã sửa tên sân thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể sửa tên sân!" + lvSanBong.SelectedItems[0].Text, "Lỗi khi sửa tên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi sửa tên sân!");
                }
            }
            else
            {
                MessageBox.Show("Không thể sửa tên sân!" + lvSanBong.SelectedItems[0].Text, "Lỗi khi sửa tên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusBarAddText("Lỗi khi sửa tên sân!");
            }
        }

        private void btThemNganhHang_Click(object sender, EventArgs e)
        {
            fNhapHang nhapHang = new fNhapHang();
            nhapHang.ShowDialog();
        }
    }
}