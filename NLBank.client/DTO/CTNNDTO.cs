using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class CTNNDTO
    {
        private int _SoGNN;
        private int _SoHDTD;
        private int _MaKH;
        private DateTime _NgayKyGNN;
        private int _MaCN;
        private int _HanMucTinDung;
        private DateTime _HanTraNo;
        private decimal _LaiQuaHan;
        private decimal _LaiSuat;

        public int SoGNN { 
            get{ return _SoGNN; } 
            set{ _SoGNN = value;}
        }
        public int SoHDTD { 
            get{ return _SoHDTD; }
            set{ _SoHDTD = value;}
        }
        public int MaKH { 
            get{ return _MaKH; } 
            set{ _MaKH = value;}
        }
        public DateTime NgayKyGNN { 
            get{ return _NgayKyGNN; }
            set{ _NgayKyGNN = value;}
        }
        public int MaCN {
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
        public CTNNDTO(int soGNN, int soHDTD, int maKH, DateTime ngayKyGNN, int maCN, int hanMucTinDung, 
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
        public HDTDDTO hd { set; get; }
    }
}
