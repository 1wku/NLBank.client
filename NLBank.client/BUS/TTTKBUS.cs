using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLBank.client.DTO;
using NLBank.client.DAL;

namespace NLBank.client.BUS
{
    class TTTKBUS
    {
        public static CANHANDTO getCaNhan(int makh)
        {
            return CANHANDAL.getCaNhan(makh);
        }
        public static DOANHNGHIEPDTO getDoanhNghiep(int makh)
        {
            return DOANHNGHIEPDAL.getDoanhNghiep(makh);
        }

        public static Boolean SuaCaNhan(CANHANDTO cn, KHDTO kh)
        {
            if (KHDAL.SuaKH(kh) && CANHANDAL.SuaCaNhan(cn))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean SuaDN(DOANHNGHIEPDTO dn, KHDTO kh)
        {
            if (KHDAL.SuaKH(kh) && DOANHNGHIEPDAL.SuaDoanhNghiep(dn))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
