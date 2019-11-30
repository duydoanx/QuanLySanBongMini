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
using QuanLySanBongMini.SecondaryForm;

namespace QuanLySanBongMini
{
    public partial class FMain : Form
    {
        private bool isAdmin;
        private ArrayList sanBongList = new ArrayList();
        private ArrayList nganhHangList = new ArrayList();
        private ArrayList matHangList = new ArrayList();
        private ArrayList phieuDatSanBongList = new ArrayList();
        private ArrayList chiTietHoaDonList = new ArrayList();
        private ArrayList matHangChoList = new ArrayList();

        public FMain(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            if (!isAdmin)
            {
                //menu.Items.Remove(adminItem);
            }
        }

        private void btThemSan_Click(object sender, EventArgs e)
        {
            if (tbTenSan.Text.Length > 0)
            {
                if (!BUS.SanBongBUS.addSan(tbTenSan.Text, (double)nudDonGia.Value))
                {
                    MessageBox.Show("Không thể thêm sân, vui lòng đổi tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi thêm sân!");
                }
                else
                {
                    tbTenSan.Text = "";
                    updateListViewSan();
                    statusBarAddText("Đã thêm sân thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm sân, vui lòng nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusBarAddText("Lỗi khi thêm sân!");
            }
        }

        private void updateListViewSan()
        {
            ArrayList dataList = SanBongBUS.getAllSan();
            lvSanBong.Clear();
            sanBongList.Clear();

            foreach (SanBong sanBong in dataList)
            {
                sanBongList.Add(sanBong);
                if (sanBong.dangThue)
                {
                    lvSanBong.Items.Add(sanBong.tenSan, 1);
                }
                else
                {
                    lvSanBong.Items.Add(sanBong.tenSan, 0);
                }
            }
            btSuaSan.Enabled = false;
            btXoaSan.Enabled = false;
            tabTinhTien.Enabled = false;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            lvSanBong.Sorting = SortOrder.None;
            updateListViewSan();
            updateComboBoxNganhHang();

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
            if (lvSanBong.SelectedItems.Count > 0)
            {
                tbTenSan.Text = (lvSanBong.SelectedItems[0]).Text;
                nudDonGia.Value = (decimal)((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]).donGia;
                btSuaSan.Enabled = true;
                btXoaSan.Enabled = true;
                tabTinhTien.Enabled = true;

                SanBong sanBong = ((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]);
                if (sanBong.dangThue)
                {
                    PhieuDatSanBong phieuDatSanBong = PhieuDatSanBongBUS.getLatestPhieuDatSanBong(sanBong.id);
                    tbTenKhachHang.Text = HoaDonBUS.getHoaDon(phieuDatSanBong.idHoaDon).tenKhachHang;
                    dtpGioVao.Value = phieuDatSanBong.thoiGianBatDau;
                    nudSoGio.Value = phieuDatSanBong.soGioDat;
                    dtpGioRa.Value = phieuDatSanBong.thoiGianBatDau.AddHours((double)phieuDatSanBong.soGioDat);
                    btDatSan.Enabled = false;
                    loadLvChiTietHoaDon(phieuDatSanBong.idHoaDon);
                    btDoiSan.Enabled = true;
                    btCapNhat.Enabled = true;
                    btHuySan.Enabled = true;
                    HoaDon hoaDon = HoaDonBUS.getHoaDon(phieuDatSanBong.idHoaDon);
                    if (hoaDon.daThanhToan)
                    {
                        btThuTien.Enabled = false;

                        btDoiSan.Enabled = false;
                        btCapNhat.Enabled = false;
                        gbMatHangTinhTien.Enabled = false;

                        lbThanhToan.Text = "ĐÃ THANH TOÁN";
                    }
                    else
                    {
                        btThuTien.Enabled = true;
                        lbThanhToan.Text = "CHƯA THANH TOÁN";
                        btDoiSan.Enabled = true;
                        btCapNhat.Enabled = true;
                        gbMatHangTinhTien.Enabled = true;
                    }
                }
                else
                {
                    btDatSan.Enabled = true;
                    matHangChoList.Clear();
                    btDoiSan.Enabled = false;
                    btCapNhat.Enabled = false;
                    btHuySan.Enabled = false;
                    btThuTien.Enabled = false;
                    
                    
                    gbMatHangTinhTien.Enabled = true;
                }
                tbTenSanTT.Text = sanBong.tenSan;
                
            }
            else
            {
                tbTenSan.Text = "";
                btSuaSan.Enabled = false;
                btXoaSan.Enabled = false;
                tabTinhTien.Enabled = false;
                tbTenSanTT.Text = "";
                tbTenKhachHang.Text = "";
                nudSoGio.Value = 0;
                dtpGioVao.Value = DateTime.Now;
                dtpGioRa.Value = DateTime.Now;
                tbTienSan.Text = "";
                tbTienHang.Text = "";
                nudGiamGia.Value = 0;
                nudTienKhac.Value = 0;
                lvChiTietHoaDon.Items.Clear();
                nudDonGia.Value = 0;
                btDoiSan.Enabled = false;
                lbThanhToan.Text = "CHƯA THANH TOÁN";
            }
            loadTinhTien();
        }

        void loadLvChiTietHoaDon(int idHoaDon)
        {
            chiTietHoaDonList = ChiTietHoaDonBUS.getAllChiTietHoaDon(idHoaDon);
            lvChiTietHoaDon.Items.Clear();
            matHangChoList.Clear();
            foreach (ChiTietHoaDon chiTietHoaDon in chiTietHoaDonList)
            {
                MatHang matHang = MatHangBUS.getMatHang(chiTietHoaDon.idMatHang);
                string[] row = { matHang.tenMatHang, chiTietHoaDon.soLuong.ToString(), chiTietHoaDon.donGia.ToString() };
                ListViewItem viewItem = new ListViewItem(row);
                lvChiTietHoaDon.Items.Add(viewItem);
                matHangChoList.Add(new MatHang(matHang.id, matHang.tenMatHang, matHang.idNganhHang, (float)chiTietHoaDon.donGia,
                    chiTietHoaDon.soLuong));
            }
        }

        private void btXoaSan_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa sân " + lvSanBong.SelectedItems[0].Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (!SanBongBUS.deleteSan(((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]).id))
                {
                    MessageBox.Show("Không thể xóa sân " + lvSanBong.SelectedItems[0].Text, "Lỗi khi xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi xóa sân!");
                }
                else
                {
                    updateListViewSan();
                    tbTenSan.Text = "";
                    statusBarAddText("Đã xóa sân thành công!");
                    btSuaSan.Enabled = false;
                    btXoaSan.Enabled = false;
                    tabTinhTien.Enabled = false;
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
                if (sanBong.tenSan == ten)
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
                if (SanBongBUS.updateTenSan(id, tbTenSan.Text, (double)nudDonGia.Value))
                {
                    updateListViewSan();
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

        void updateComboBoxNganhHang()
        {
            ArrayList dataList = NganhHangBUS.getAllNganhHang();
            cbNhom.Items.Clear();
            nganhHangList.Clear();

            foreach (NganhHang nganhHang in dataList)
            {
                nganhHangList.Add(nganhHang);
                cbNhom.Items.Add(nganhHang.tenNganhHang);
            }
            if (cbNhom.Items.Count > 0)
            {
                cbNhom.SelectedItem = cbNhom.Items[0];
                loadMatHang(((NganhHang)nganhHangList[0]).id);
            }

        }

        private void btThemNganhHang_Click(object sender, EventArgs e)
        {
            FQuanLyNganhHang nhapHang = new FQuanLyNganhHang();
            nhapHang.ShowDialog();
            updateComboBoxNganhHang();
        }

        void loadMatHang(int idNganhHang)
        {
            ArrayList dataList = MatHangBUS.getAllMatHangFromNganhHang(idNganhHang);
            lvMatHang.Items.Clear();
            matHangList.Clear();

            foreach (MatHang matHang in dataList)
            {
                matHangList.Add(matHang);
                string[] row = { matHang.tenMatHang, matHang.soLuong.ToString(), matHang.donGia.ToString() };
                ListViewItem viewItem = new ListViewItem(row);
                lvMatHang.Items.Add(viewItem);
            }
            btThemHang.Enabled = false;
        }

        private void lvMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMatHang.SelectedItems.Count > 0)
            {
                tbMatHangTinhTien.Text = lvMatHang.SelectedItems[0].Text;
                nudSoLuongTinhTien.Maximum = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).soLuong;
                if (nudSoLuongTinhTien.Maximum > 0)
                {
                    nudSoLuongTinhTien.Value = 1;
                }
                tbDonGiaTinhTien.Text = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).donGia.ToString();
                loadTinhTien();
                
                btThemHang.Enabled = true;
            }
            else
            {
                btThemHang.Enabled = false;
            }
        }

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMatHang(((NganhHang)nganhHangList[cbNhom.SelectedIndex]).id);
        }

        

        private void nudSoLuongTinhTien_KeyUp(object sender, KeyEventArgs e)
        {
            if (nudSoLuongTinhTien.Value > nudSoLuongTinhTien.Maximum)
            {
                MessageBox.Show("Vượt quá số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoLuongTinhTien.Value = nudSoLuongTinhTien.Maximum;

            }
        }

        private void nhậpHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fNhapMatHang nhapMatHang = new fNhapMatHang();
            nhapMatHang.ShowDialog();
            loadMatHang(((NganhHang)nganhHangList[cbNhom.SelectedIndex]).id);
        }

        private void btQuanLyMatHang_Click(object sender, EventArgs e)
        {
            FQuanLyMatHang fQuanLyMatHang = new FQuanLyMatHang();
            fQuanLyMatHang.ShowDialog();
            loadMatHang(((NganhHang)nganhHangList[cbNhom.SelectedIndex]).id);
        }

        int kiemTraMatHang(MatHang matHang)
        {
            //-1 khi khong ton tai mat hang nao truoc
            int pos = -1;

            for (int i = 0; i<matHangChoList.Count; i++)
            {
                if (((MatHang)matHangChoList[i]).id == matHang.id)
                {
                    pos = i;
                    return pos;
                }
            }

            return pos;
        }

        private void btThemHang_Click(object sender, EventArgs e)
        {
            
            MatHang matHang = (MatHang)matHangList[lvMatHang.SelectedIndices[0]];
            int pos = kiemTraMatHang(matHang);
            if ( pos == -1)
            {
                matHangChoList.Insert(0, new MatHang(matHang.id, matHang.tenMatHang, matHang.idNganhHang, matHang.donGia,
                    Convert.ToInt32(nudSoLuongTinhTien.Value)));
                string[] row = { matHang.tenMatHang, nudSoLuongTinhTien.Value.ToString(), matHang.donGia.ToString() };
                ListViewItem viewItem = new ListViewItem(row);
                lvChiTietHoaDon.Items.Add(viewItem);
            }
            else
            {
                MatHang matHang1 = (MatHang)matHangChoList[pos];
                ((MatHang)matHangChoList[pos]).soLuong = matHang1.soLuong + Convert.ToInt32(nudSoLuongTinhTien.Value);
                lvChiTietHoaDon.Items.Clear();
                foreach(MatHang matHang2 in matHangChoList)
                {
                    string[] row = { matHang2.tenMatHang, matHang2.soLuong.ToString(), matHang2.donGia.ToString() };
                    ListViewItem viewItem = new ListViewItem(row);
                    lvChiTietHoaDon.Items.Add(viewItem);
                }
            }

            lvMatHang.SelectedItems[0].SubItems[1].Text = (Convert.ToInt32(lvMatHang.SelectedItems[0].SubItems[1].Text) - 
                (int)nudSoLuongTinhTien.Value).ToString();
            ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).soLuong += -(int)nudSoLuongTinhTien.Value;
            nudSoLuongTinhTien.Maximum = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).soLuong;
            loadTinhTien();
            
        }

        private void nudSoGio_ValueChanged(object sender, EventArgs e)
        {
            dtpGioRa.Value = dtpGioVao.Value.AddHours((double)nudSoGio.Value);
            loadTinhTien();
            if (nudSoGio.Value == 0 )
            {
                tbTienSan.Text = "";
            }
        }

        void loadTinhTien()
        {
            if (lvSanBong.SelectedItems.Count > 0)
            {
                double tienSan = ((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]).donGia * (double)nudSoGio.Value;
                tbTienSan.Text = tienSan.ToString();
                float tienHang = 0;
                foreach(MatHang matHang in matHangChoList)
                {
                    tienHang += matHang.donGia * matHang.soLuong;
                }
                tbTienHang.Text = tienHang.ToString();
                float giamGia = (float)nudGiamGia.Value;
                float tienKhac = (float)nudTienKhac.Value;
                float tongTien = (float)(tienSan + tienHang + tienKhac) * (100 - giamGia) / 100;
                tbThanhToan.Text = tongTien.ToString();
                float khachDua = (float)nudKhachDua.Value;
                if (khachDua > 0)
                {
                    
                    tbTienThoi.Text = (khachDua - tongTien).ToString();
                }
            }
        }

        private void btDatSan_Click(object sender, EventArgs e)
        {
            HoaDonBUS.addHoaDon(new HoaDon(0, DateTime.Now, tbTenKhachHang.Text, false));
            HoaDon hoaDon = HoaDonBUS.getLastHoaDon();
            SanBong sanBong = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
            PhieuDatSanBongBUS.addPhieuDatSanBong(new PhieuDatSanBong(0, sanBong.id, dtpGioVao.Value, (int)nudSoGio.Value,
                (double)nudDonGia.Value ,hoaDon.id));
            updateListViewSan();
           if (lvChiTietHoaDon.Items.Count > 0)
           {
                foreach(MatHang matHang in matHangChoList)
                {
                    ChiTietHoaDonBUS.addChiTietHoaDon(new ChiTietHoaDon(0, hoaDon.id, matHang.id ,matHang.soLuong,
                        matHang.donGia));
                }
           }
            btDatSan.Enabled = false;
        }

        private void lvChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChiTietHoaDon.SelectedItems.Count > 0)
            {
                btXoaHang.Enabled = true;
            }
            else
            {
                btXoaHang.Enabled = false;
            }
        }

        private void nudGiamGia_ValueChanged(object sender, EventArgs e)
        {
            loadTinhTien();
        }

        private void nudTienKhac_ValueChanged(object sender, EventArgs e)
        {
            loadTinhTien();
        }

        private void nudKhachDua_ValueChanged(object sender, EventArgs e)
        {
            loadTinhTien();
        }

        int matHangInChiTietHoaDon(MatHang matHang)
        {
            int pos = -1;
            for (int i = 0; i < chiTietHoaDonList.Count; i++)
            {
                if(((ChiTietHoaDon)chiTietHoaDonList[i]).idMatHang == matHang.id)
                {
                    pos = i;
                    return pos;
                }
            }
            return pos;
        }

        private void btXoaHang_Click(object sender, EventArgs e)
        {
            MatHang matHang = (MatHang)matHangChoList[lvChiTietHoaDon.SelectedIndices[0]];
            int pos = matHangInChiTietHoaDon(matHang);

            if(pos != -1) 
            {             
                ChiTietHoaDon chiTietHoaDon = (ChiTietHoaDon)chiTietHoaDonList[pos];
                ChiTietHoaDonBUS.deleteChiTietHoaDon(chiTietHoaDon.id);
                chiTietHoaDonList.RemoveAt(pos);
            }
            matHangChoList.RemoveAt(lvChiTietHoaDon.SelectedIndices[0]);
            lvChiTietHoaDon.Items.RemoveAt(lvChiTietHoaDon.SelectedIndices[0]);

            for (int i = 0; i< matHangList.Count; i++)
            {
                if(matHang.id == ((MatHang)matHangList[i]).id)
                {
                    ((MatHang)matHangList[i]).soLuong += matHang.soLuong;
                    lvMatHang.Items[i].SubItems[1].Text = ((MatHang)matHangList[i]).soLuong.ToString();
                    //MatHangBUS.updateMatHang((MatHang)matHangList[i]);
                }
            }
            
        }

        private void btDoiSan_Click(object sender, EventArgs e)
        {
            FDoiSan fDoiSan = new FDoiSan((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]);
            fDoiSan.ShowDialog();
            fMain_Load(sender, e);
        }

        int kiemTraChiTietHoaDon(int idMatHang)
        {
            
            for(int i = 0; i<chiTietHoaDonList.Count; i++)
            {
                if (((ChiTietHoaDon)chiTietHoaDonList[i]).idMatHang == idMatHang)
                {
                    
                    return i;
                }
            }
            
            return -1;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            SanBong sanBong = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
            PhieuDatSanBong phieuDatSanBong = PhieuDatSanBongBUS.getLatestPhieuDatSanBong(sanBong.id);
            HoaDon hoaDon = HoaDonBUS.getHoaDon(phieuDatSanBong.idHoaDon);
            int pos;
            foreach(MatHang matHang in matHangChoList)
            {
                pos = kiemTraChiTietHoaDon(matHang.id);
                if ( pos == -1)
                {
                    ChiTietHoaDonBUS.addChiTietHoaDon(new ChiTietHoaDon(0, hoaDon.id, matHang.id, matHang.soLuong, matHang.donGia));
                }
                else
                {
                    ((ChiTietHoaDon)chiTietHoaDonList[pos]).soLuong = matHang.soLuong;
                    ChiTietHoaDonBUS.updateChiTietHoaDon((ChiTietHoaDon)chiTietHoaDonList[pos]);
                }
            }
            hoaDon.tenKhachHang = tbTenKhachHang.Text;
            HoaDonBUS.updateHoaDon(hoaDon);
            phieuDatSanBong.thoiGianBatDau = dtpGioVao.Value;
            phieuDatSanBong.soGioDat = (int)nudSoGio.Value;

            PhieuDatSanBongBUS.updatePhieuDatSanBong(phieuDatSanBong);
        }

        private void btHuySan_Click(object sender, EventArgs e)
        {
            SanBong sanBong = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
            PhieuDatSanBong phieuDatSanBong = PhieuDatSanBongBUS.getLatestPhieuDatSanBong(sanBong.id);
            if (HoaDonBUS.deleteHoaDon(phieuDatSanBong.idHoaDon))
            {
                statusBarAddText("Hủy sân thành công");
                updateListViewSan();
            }
            else
            {
                MessageBox.Show("Không thể hủy sân!" + lvSanBong.SelectedItems[0].Text, "Lỗi khi hủy sân",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusBarAddText("Lỗi khi hủy sân!");
            }
        }

        private void btThuTien_Click(object sender, EventArgs e)
        {
            SanBong sanBong = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
            PhieuDatSanBong phieuDatSanBong = PhieuDatSanBongBUS.getLatestPhieuDatSanBong(sanBong.id);
            HoaDon hoaDon = HoaDonBUS.getHoaDon(phieuDatSanBong.idHoaDon);
            hoaDon.daThanhToan = true;
            HoaDonBUS.updateHoaDon(hoaDon);
            btThuTien.Enabled = false;
        }

        private void btBanLe_Click(object sender, EventArgs e)
        {

        }
    }
}