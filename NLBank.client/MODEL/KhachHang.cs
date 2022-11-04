using NLBank.client.MODEL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.MODEL
{
    public class KhachHang
    {
        public String MaKH { set; get; }
        public String Ten { set; get; }
        public String DiaChi { set; get; }
        public String Email { set; get; }
        public String Sdt { set; get; }
        public Role RoleID { set; get; }
        public CaNhan ThongTinCaNhan { set; get; }
        public DoanhNghiep ThongTinDoanhNghiep { set; get; }

        public KhachHang()
        {

        }

        public class CaNhan
        {
            public string MaKH { set; get; }
            public DateTime NgaySinh { set; get; }
            public string CCCD { set; get; }
            public int FICO_score { set; get; }
        }
        public class DoanhNghiep
        {
            public string MaKH { set; get; }
            public string MaDN { set; get; }
            public int DnB_rating { set; get; }
        }

    }
}
