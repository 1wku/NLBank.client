using NLBank.client.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
        private ChucVuDTO ChucVu;

        public NhanvienDTO(string maNV, string cCCD, string ten, string dia_chi, string email, string sdt, int maCV)
        {
            MaNV = maNV;
            CCCD = cCCD;
            Ten = ten;
            Dia_chi = dia_chi;
            Email = email;
            Sdt = sdt;
        }
        public NhanvienDTO() { }
        public NhanvienDTO(DataRow row) { 
            MaNV = row["MaNV"].ToString();
            CCCD = row["CCCD"].ToString();
            Ten = row["Ten"].ToString();
            Dia_chi = row["Dia_chi"].ToString();
            Email = row["Dia_chi"].ToString();
            Sdt = row["Dia_chi"].ToString();
            MaCV = (int)row["MaCV"];
            DataTable data = Connection.Instance.ExcuteQuery($"SELECT * FROM CHUCVU WHERE MaCV = {MaCV}");
            foreach (DataRow item in data.Rows)
            {
                ChucVu = new ChucVuDTO(item);
            }
        }
    }
}
