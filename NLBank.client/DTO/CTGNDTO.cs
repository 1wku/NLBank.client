using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    class CTGNDTO
    {
        private String _SoCTGN;
        private String _SoHDTD;
        private String _MaKH;
        private String _MaCN;
        private int _SoTienGiaiNgan;

        public String SoCTGN{
            get { return _SoCTGN; }
            set{ _SoCTGN = value; }
        }
        public String SoHDTD{
            get { return _SoHDTD; } 
            set{ _SoHDTD = value; }
        }
        public String MaKH{
            get { return _MaKH; }
            set{ _MaKH = value; }
        }
        public String MaCN{
            get { return _MaCN; }
            set{ _MaCN = value; }
        }
        public int SoTienGiaiNgan{
            get { return _SoTienGiaiNgan; } 
            set{ _SoTienGiaiNgan = value; }
        }
        public CTGNDTO(string soCTGN, String soHDTD, String maKH, String maCN, int soTienGiaiNgan)
        {
            _SoCTGN = soCTGN;
            _SoHDTD = soHDTD;
            _MaKH = maKH;
            _MaCN = maCN;
            _SoTienGiaiNgan = soTienGiaiNgan;
        }
        public CTGNDTO() { }
    }
}
