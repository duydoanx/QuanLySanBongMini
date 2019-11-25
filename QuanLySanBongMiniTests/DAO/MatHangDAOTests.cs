using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLySanBongMini.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanBongMini.DTO;

namespace QuanLySanBongMini.DAO.Tests
{
    [TestClass()]
    public class MatHangDAOTests
    {
        [TestMethod()]
        public void getMatHangFromIdNganhHangTest()
        {
            DataSet list = MatHangDAO.getMatHangFromIdNganhHang(20);

            List<MatHang> matHang = new List<MatHang>();

            foreach(DataRow row in list.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string tenMatHang = row["tenMatHang"].ToString();
                int idNganhHang = Convert.ToInt32(row["idNganhHang"]);
                float donGian = (float)Convert.ToDouble(row["donGia"]);
                int soLuong = Convert.ToInt32(row["soLuong"]);
                matHang.Add (new MatHang(id, tenMatHang, idNganhHang, donGian, soLuong));              
            }

            Assert.IsTrue(matHang[0].tenMatHang == "Mì ly");
            Assert.IsTrue(matHang[1].tenMatHang == "Poca");
        }
    }
}