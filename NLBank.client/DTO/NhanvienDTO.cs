using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class NhanvienDTO
    {
        public string MaNV { set; get; }
        public string CCCD { set; get; }
        public string Ten { set; get; }
        public string Dia_chi { set; get; }
        public string Email { set; get; }
        public string Sdt { set; get; }
        public int MaCV { set; get; }
        public NhanvienDTO(string maNV, string cCCD, string ten, string dia_chi, string email, string sdt, int maCV)
        {
            MaNV = maNV;
            CCCD = cCCD;
            Ten = ten;
            Dia_chi = dia_chi;
            Email = email;
            Sdt = sdt;
            MaCV = maCV;
        }
        public NhanvienDTO() { }
        public ChucVuDTO ChucVu { set; get; }
        
    }
}
