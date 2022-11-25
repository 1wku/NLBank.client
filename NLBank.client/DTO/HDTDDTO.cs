using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class HDTDDTO
    {
        private int _SoHDTD; 
        private int _MaKH;
        private int _MAKV;
        private String _Muc_dich;
        private decimal _LaiSuat;
        private decimal _LaiQuaHan;
        private int _ThoiHanVay;
        private String _PhuongThucTra;
        private int _MucPhi;
        private DateTime _TGGiaiNgan;
        private String _LoaiTien;
        private DateTime _NgayKi;

        public int SoHDTD
        { 
            get { return _SoHDTD; } 
            set{ _SoHDTD = value;}
        }
        public int MaKH
        { 
            get { return _MaKH; }
            set{ _MaKH = value;}
        }
        public int MAKV
        {
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
        public double SoTienVay { set; get; }
        public HDTDDTO (int soHDTD, int maKH, int mAKV, String muc_dich, decimal laiSuat, decimal laiQuaHan, int thoiHanVay, 
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
        public HDTDDTO(DataRow row)
        {
            this.SoHDTD = row["SoHDTD"] != DBNull.Value ? (int)row["SoHDTD"] : 0;
            this.MaKH = row["MaKH"] != DBNull.Value ? (int)row["MaKH"] : 0;
            this.MAKV = row["MAKV"] != DBNull.Value ? (int)row["MaKV"] : 0;
            this.Muc_dich = row["Muc_dich"] != DBNull.Value ? (string)row["Muc_dich"] :"Chưa cập nhật" ;
            this.LaiQuaHan = row["LaiQuaHan"] != DBNull.Value ? (decimal)row["LaiQuaHan"] :0 ;
            this.LaiSuat = row["LaiSuat"] != DBNull.Value ? (decimal)row["LaiSuat"] : 0;
            this.ThoiHanVay = row["ThoiHanVay"] != DBNull.Value ? (int)row["ThoiHanVay"] : 0;
            this.PhuongThucTra = row["PhuongThucTra"] != DBNull.Value ? (string)row["PhuongThucTra"] : "Chưa cập nhật";
            this.MucPhi = row["MucPhi"] != DBNull.Value ? (int)row["MucPhi"] : 0;
            this.TGGiaiNgan = row["TGGiaiNgan"] != DBNull.Value ? (DateTime)row["TGGiaiNgan"] : default(DateTime);
            this.NgayKi = row["NgayKi"] != DBNull.Value ? (DateTime)row["NgayKi"]:default(DateTime);
            this.LoaiTien = row["LoaiTien"] != DBNull.Value ? (String)row["LoaiTien"] : "Chưa cập nhật";
        }
    }
}
