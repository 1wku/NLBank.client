using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    class CTNNDTO
    {
        private String _SoGNN;
        private String _SoHDTD;
        private String _MaKH;
        private DateTime _NgayKyGNN;
        private String _MaCN;
        private int _HanMucTinDung;
        private DateTime _HanTraNo;
        private decimal _LaiQuaHan;
        private decimal _LaiSuat;

        public String SoGNN { 
            get{ return _SoGNN; } 
            set{ _SoGNN = value;}
        }
        public String SoHDTD { 
            get{ return _SoHDTD; }
            set{ _SoHDTD = value;}
        }
        public String MaKH { 
            get{ return _MaKH; } 
            set{ _MaKH = value;}
        }
        public DateTime NgayKyGNN { 
            get{ return _NgayKyGNN; }
            set{ _NgayKyGNN = value;}
        }
        public String MaCN {
            get{ return _MaCN; }
            set{ _MaCN = value;}
        }
        public int HanMucTinDung {
            get{ return _HanMucTinDung; }
            set{ _HanMucTinDung = value;}
        }
        public DateTime HanTraNo {
            get{ return _HanTraNo; } 
            set{ _HanTraNo = value;}
        }
        public decimal LaiQuaHan {
            get{ return _LaiQuaHan; }
            set{ _LaiQuaHan = value;}
        }
        public decimal LaiSuat {
            get{ return _LaiSuat; } 
            set{ _LaiSuat = value;}
        }
        public CTNNDTO( String soGNN, String soHDTD, String maKH, DateTime ngayKyGNN, String maCN, int hanMucTinDung, 
                                DateTime hanTraNo, decimal laiQuaHan, decimal laiSuat)
        {
            _SoGNN = soGNN;
            _SoHDTD = soHDTD;
            _MaKH = maKH;
            _NgayKyGNN = ngayKyGNN;
            _MaCN = maCN;
            _HanMucTinDung = hanMucTinDung;
            _HanTraNo = hanTraNo;
            _LaiQuaHan = laiQuaHan;
            _LaiSuat = laiSuat;
        }
        public CTNNDTO() { }
    }
}
