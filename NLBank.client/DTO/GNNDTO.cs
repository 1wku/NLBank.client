using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class GNNDTO
    {
        private int _SoGNN;
        private String _Ten;
        private int _MaKH;
        private int _SoHDTD;
        private decimal _LaiSuat;
        private decimal _LaiQuaHan;
        private int _ThoiHanVay;
        private String _PhuongThucTra;
        private String _LoaiTien;
        private DateTime _NgayKi;
        private int _SoTienVay;
        private int _HanMucTinDung;
        private DateTime _NgayKyGNN;
        private String _Chi_nhanh;
        private DateTime _NgayNN;
        private DateTime _HanTraNo;

        public int SoGNN { get; set; }
        public String Ten { get; set; }
        public int MaKH { get; set; }
        public int SoHDTD { get; set; }
        public decimal LaiSuat { get; set; }
        public decimal LaiQuaHan { get; set; }
        public int ThoiHanVay { get; set; }
        public String PhuongThucTra { get; set; }
        public String LoaiTien { get; set; }
        public DateTime NgayKi { get; set; }
        public int SoTienVay { get; set; }
        public int HanMucTinDung { get; set; }
        public DateTime NgayKyGNN { get; set; }
        public String Chi_nhanh { get; set; }
        public DateTime NgayNN { get; set; }
        public DateTime HanTraNo { get; set; }

        public GNNDTO (int soGNN, String ten, int maKH,int soHDTD, decimal laiSuat, decimal laiQuaHan, int thoiHanVay, String phuongThucTra, 
            String loaiTien,  DateTime ngayKi, int soTienVay, int hanMucTinDung,DateTime ngayKyGNN, String chi_nhanh,  DateTime ngayNN, DateTime hanTraNo)
        {
            _SoGNN = soGNN;
            _Ten = ten;
            _MaKH = maKH;
            _LaiSuat = laiSuat;
            _LaiQuaHan = laiQuaHan;
            _ThoiHanVay = thoiHanVay;
            _PhuongThucTra = phuongThucTra;
            _LoaiTien = loaiTien;
            _NgayKi = ngayKi;
            _SoTienVay = soTienVay;
            _HanMucTinDung = hanMucTinDung;
            _NgayKyGNN = ngayKyGNN;
            _Chi_nhanh = chi_nhanh;
            _NgayNN = ngayNN;
            _HanTraNo = hanTraNo;
        }
        public GNNDTO() { }
    }
}
