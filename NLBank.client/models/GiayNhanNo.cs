using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.models
{
    public class GiayNhanNo
    {
        public string SoGNN { set; get ;}
        public string SoHDTD { set;get ;}
        public string MaKH { set;get ;}
        public DateTime NgayKyGNN { set;get ;}
        public string MaCN { set;get ;}
        public int HanMucTinDung { set;get ;}
        public DateTime HanTraNo { set;get ;}
        public double LaiQuaHan { set;get ;}
        public double LaiSuat { set;get ;}
    }
}
