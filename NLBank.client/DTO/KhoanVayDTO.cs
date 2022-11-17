using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class KhoanVayDTO
    {
        private int _MaKV; 
        private int _MaKH ;
        private int _MaTSDB ;
        private int _MaLoaiKV ;
        private String _MucDich ;
        private int _SoTienVay ;
        private String _LoaiTien ;
        public int MaKV {
            get { return _MaKV; }
            set { _MaKV = value; }
        }
        public int MaKH {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        public int MaTSDB {
            get { return _MaTSDB; }
            set { _MaTSDB = value; }
        }
        public int MaLoaiKV {
            get { return _MaLoaiKV; }
            set { _MaLoaiKV = value; }
        }
        public String MucDich {
            get { return _MucDich; }
            set { _MucDich = value; }
        }
        public int SoTienVay {
            get { return _SoTienVay; }
            set { _SoTienVay = value; }
        }
        public String LoaiTien {
            get { return _LoaiTien; }
            set { _LoaiTien = value; }
        }
        public KhoanVayDTO KhachHang { set; get; } 

        public KhoanVayDTO(int maKV, int maKH, int maTSDB, int maLoaiKV, String mucDich, int soTienVay, String loaiTien)
        {
            _MaKH = maKH;
            _MaKV = maKV;
            _MaTSDB = maTSDB;
            _MaLoaiKV = maLoaiKV;
            _MucDich = mucDich;
            _SoTienVay = soTienVay;
            _LoaiTien = loaiTien;
        }
        public KhoanVayDTO(int maKH, int maTSDB, int maLoaiKV, String mucDich, int soTienVay, String loaiTien)
        {
            _MaKH = maKH;
            _MaTSDB = maTSDB;
            _MaLoaiKV = maLoaiKV;
            _MucDich = mucDich;
            _SoTienVay = soTienVay;
            _LoaiTien = loaiTien;
        }
        public KhoanVayDTO() { }
        public KhoanVayDTO(DataRow row)
        {
            _MaKH = (int)row["MaKH"]; 
            _MaKV = (int)row["MaKV"] ;
            _MaTSDB = (int) row["MaTSDB"];
            _MaLoaiKV = (int)row["MaLoaiKV"];
            _MucDich = row["MucDich"].ToString(); 
            _SoTienVay = (int)row["SoTienVay"]; ;
            _LoaiTien = row["LoaiTien"].ToString();
        }

    }
}
