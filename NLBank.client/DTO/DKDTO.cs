using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class DKDTO
    {
        private String _MaDK;
        private String _NoiDung;
        private decimal _Pct_lai;

        public String MaDK { get { return _MaDK; } set { _MaDK = value;} }
        public String NoiDung { get { return _NoiDung; } set { _NoiDung = value;} }
        public decimal Pct_lai { get { return _Pct_lai; } set { _Pct_lai = value;} }

        public DKDTO(String maDK, String noiDung, decimal pct_lai)
        {
            _MaDK = maDK;
            _NoiDung = noiDung;
            _Pct_lai = pct_lai;
        }
        public DKDTO() { }
    }
}
