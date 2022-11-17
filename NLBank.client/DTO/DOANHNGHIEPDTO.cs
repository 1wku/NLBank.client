using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class DOANHNGHIEPDTO
    {
        private int _MaKH;
        private String _MADN;
        private int _DnB_rating;

        public  int MaKH { get { return _MaKH; } set { _MaKH = value;} }
        public  String MADN { get { return _MADN; } set { _MADN = value;} }
        public  int DnB_rating { get { return _DnB_rating; } set { _DnB_rating = value;} }

        public DOANHNGHIEPDTO(int maKH, string mADN, int dnB_rating)
        {
            _MaKH = maKH;
            _MADN = mADN;
            _DnB_rating = dnB_rating;
        }

        public DOANHNGHIEPDTO() { }
        public DOANHNGHIEPDTO(DataRow row)
        {
            this._MaKH = (int)row["MaKH"];
            this._MADN = (String)row["MADN"];
            this._DnB_rating = (int)row["DnB_rating"];
        }
    }
}
