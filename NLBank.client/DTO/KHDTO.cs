using NLBank.client.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class KHDTO
    {
        private int _MaKH; 
        private String _Ten;
        private String _Dia_chi;
        private String _Email;
        private String _Sdt;
        private int _RoleID;
        public CANHANDTO canhan;
        public DOANHNGHIEPDTO doanhNghiep;

        public int MaKH {
            get { return _MaKH; }
            set { _MaKH = value;} 
        }
        public String Ten { 
            get { return _Ten; }
            set { _Ten = value;} 
        }
        public String Dia_chi {
            get { return _Dia_chi; } 
            set { _Dia_chi = value;}
        }
        public String Email {
            get { return _Email; } 
            set { _Email = value;}
        }
        public String Sdt { 
            get { return _Sdt; } 
            set { _Sdt = value;}
        }
        public int RoleID {
            get { return _RoleID; }
            set { _RoleID = value;} 
        }
        public KHDTO (int maKH, String ten,  String dia_chi, String email, String sdt, int roleID)
        {
            _MaKH = maKH;
            _Ten = ten;
            _Dia_chi = dia_chi;
            _Email = email;
            _Sdt = sdt;
            _RoleID = roleID;
            if (_RoleID == 0)
            {
                canhan = CANHANDAL.GetCaNhan(_MaKH);
            }
            if (_RoleID == 1) {
                doanhNghiep = DOANHNGHIEPDAL.GetDoanhNghiep(_MaKH);
            }
        }
        public KHDTO() { }
        public KHDTO(DataRow row) {
            _MaKH = (int)row["MaKH"];
            _Ten = row["Ten"].ToString();
            _Dia_chi = row["Dia_chi"].ToString();
            _Email = row["Email"].ToString();
            _Sdt = row["Sdt"].ToString();
            _RoleID = (byte)row["RoleID"];
            if (_RoleID == 0)
            {
                canhan = CANHANDAL.GetCaNhan(_MaKH);
            }
            if (_RoleID == 1)
            {
                doanhNghiep = DOANHNGHIEPDAL.GetDoanhNghiep(_MaKH);
            }
        }
    }
}
