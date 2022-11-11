using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class DOANHNGHIEPDTO
    {
        private String _MaKH;
        private String _MADN;
        private int _DnB_rating;

        public  String MaKH { get { return _MaKH; } set { _MaKH = value;} }
        public  String MADN { get { return _MADN; } set { _MADN = value;} }
        public  int DnB_rating { get { return _DnB_rating; } set { _DnB_rating = value;} }

        public DOANHNGHIEPDTO(String maKH, String mADN, int dnB_rating)
        {
            _MaKH = maKH;
            _MADN = MADN;
            _DnB_rating = dnB_rating;
        }
    }

}
