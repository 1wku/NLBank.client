﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class HDTDDTO
    {
        private String _SoHDTD;
        private String _MaKH;
        private String _MAKV;
        private String _Muc_dich;
        private decimal _LaiSuat;
        private decimal _LaiQuaHan;
        private int _ThoiHanVay;
        private String _PhuongThucTra;
        private int _MucPhi;
        private DateTime _TGGiaiNgan;
        private String _LoaiTien;
        private DateTime _NgayKi;

        public String SoHDTD{ 
            get { return _SoHDTD; } 
            set{ _SoHDTD = value;}
        }
        public String MaKH{ 
            get { return _MaKH; }
            set{ _MaKH = value;}
        }
        public String MAKV{
            get { return _MAKV; }
            set{ _MAKV = value;}
        }
        public String Muc_dich{
            get { return _Muc_dich; }
            set{ _Muc_dich = value;}
        }
        public decimal LaiSuat{ 
            get { return _LaiSuat; }
            set{ _LaiSuat = value;}
        }
        public decimal LaiQuaHan{ 
            get { return _LaiQuaHan; } 
            set{ _LaiQuaHan = value;}
        }
        public int ThoiHanVay{ 
            get { return _ThoiHanVay; } 
            set{ _ThoiHanVay = value;}
        }
        public String PhuongThucTra{ 
            get { return _PhuongThucTra; } 
            set{ _PhuongThucTra = value;}
        }
        public int MucPhi{ 
            get { return _MucPhi; }
            set{ _MucPhi = value;}
        }
        public DateTime TGGiaiNgan{
            get { return _TGGiaiNgan; }
            set{ _TGGiaiNgan = value;}
        }
        public String LoaiTien{
            get { return _LoaiTien; } 
            set{ _LoaiTien = value;}
        }
        public DateTime NgayKi{ 
            get { return _NgayKi; } 
            set{ _NgayKi = value;}
        }
        public HDTDDTO ( String soHDTD, String maKH, String mAKV, String muc_dich, decimal laiSuat, decimal laiQuaHan, int thoiHanVay, 
                        String phuongThucTra, int mucPhi, DateTime tGGiaiNgan, String loaiTien, DateTime ngayKi)
        {
            _SoHDTD = soHDTD;
            _MaKH = maKH;
            _MAKV = mAKV;
            _Muc_dich = muc_dich;
            _LaiSuat = laiSuat;
            _LaiQuaHan = laiQuaHan;
            _ThoiHanVay = thoiHanVay;
            _PhuongThucTra = phuongThucTra;
            _MucPhi = mucPhi;
            _TGGiaiNgan = tGGiaiNgan;
            _LoaiTien = loaiTien;
            _NgayKi = ngayKi;
        }
        public HDTDDTO() { }
    }
}