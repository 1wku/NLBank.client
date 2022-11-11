using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class CTTNDTO
    {
        private String _SoCTThuNo;
        private String _SoHDTD;
        private String _MaCN;
        private DateTime _KyThuNoGoc;
        private DateTime _KyThuNoLai;
        private int _SoDuNo;
        private int _SoTienTra;
        private int _SoDuNoGoc;
        private DateTime _NgayThuNo;

        public String SoCTThuNo { 
            get {return _SoCTThuNo; }
            set { _SoCTThuNo = value;}
        }
        public String SoHDTD { 
            get {return _SoHDTD; }
            set { _SoHDTD = value;}
        }
        public String MaCN { 
            get {return _MaCN; }
            set { _MaCN = value;}
        }
        public DateTime KyThuNoGoc {
            get {return _KyThuNoGoc; } 
            set { _KyThuNoGoc = value;}
        }
        public DateTime KyThuNoLai {
            get {return _KyThuNoLai; } 
            set { _KyThuNoLai = value;}
        }
        public int SoDuNo { 
            get {return _SoDuNo; } 
            set { _SoDuNo = value;}
        }
        public int SoTienTra { 
            get {return _SoTienTra; } 
            set { _SoTienTra = value;}
        }
        public int SoDuNoGoc {
            get {return _SoDuNoGoc; } 
            set { _SoDuNoGoc = value;}
        }
        public DateTime NgayThuNo { 
            get {return _NgayThuNo; } 
            set { _NgayThuNo = value;}
        }
        public CTTNDTO(String soCTThuNo, String soHDTD, String maCN, DateTime kyThuNoGoc,DateTime kyThuNoLai, 
                            int soDuNo, int soTienTra, int soDuNoGoc, DateTime ngayThuNo)
        {
            _SoCTThuNo = soCTThuNo;
            _SoHDTD = soHDTD;
            _MaCN = maCN;
            _KyThuNoGoc = kyThuNoGoc;
            _KyThuNoLai = kyThuNoLai;
            _SoDuNo = soDuNo;
            _SoTienTra = soTienTra;
            _SoDuNoGoc = soDuNoGoc;
            _NgayThuNo = ngayThuNo;
        }
        public CTTNDTO() { }
    }
}
