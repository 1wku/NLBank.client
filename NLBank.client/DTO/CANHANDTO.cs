using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class CANHANDTO
    {
        private int _MaKH;
        private DateTime _NgaySinh;
        private String _CCCD;
        private int _FICO_score;

        public int MaKH { get { return _MaKH; } set { _MaKH = value;} }
        public DateTime NgaySinh { get { return _NgaySinh; } set { _NgaySinh = value;} }
        public String CCCD { get { return _CCCD; } set { _CCCD = value;} }
        public int FICO_score { get { return _FICO_score; } set { _FICO_score = value;} }

        public CANHANDTO(int maKH, DateTime ngaySinh, String cCCD, int fICO_score)
        {
            _MaKH = maKH;
            _NgaySinh = ngaySinh;
            _CCCD = cCCD;
            _FICO_score = fICO_score;
        }
        public CANHANDTO() { }

        public CANHANDTO(DataRow row)
        {
            this._MaKH = (int)row["MaKH"];
            this._NgaySinh = (DateTime)row["NgaySinh"];
            this._CCCD = (String)row["CCCD"];
            this._FICO_score = (int)row["FICO_score"];
        }
    }
}
