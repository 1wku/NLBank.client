using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    class DOANHNGHIEPDAL
    {
        public static DOANHNGHIEPDTO GetDoanhNghiep(int MaKH)
        {
            DataTable data = Connection.Instance.ExcuteQuery($"sp_LayCaNhanHayDoanhNghiep {MaKH}, 1");
            foreach (DataRow item in data.Rows)
            {
                return new DOANHNGHIEPDTO(item);
            }
            return null;
        }
    }
}
