using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    class CANHANDAL
    {
        public static CANHANDTO GetCaNhan(int MaKH) {
            DataTable data = Connection.Instance.ExcuteQuery($"sp_LayCaNhanHayDoanhNghiep {MaKH}, 0");
            foreach (DataRow item in data.Rows) { 
                return new CANHANDTO(item);
            }
            return null;
        }
    }
}
