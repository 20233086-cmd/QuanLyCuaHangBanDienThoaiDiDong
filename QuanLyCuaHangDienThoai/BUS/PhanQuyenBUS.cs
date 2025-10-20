using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangDienThoai.DAL;

namespace QuanLyCuaHangDienThoai.BUS
{
    public class PhanQuyenBUS
    {
        private PhanQuyenDAL dal = new PhanQuyenDAL();

        public string LayTenQuyen(int maQuyen)
        {
            return dal.LayTenQuyenTheoMa(maQuyen);
        }
    }
}
