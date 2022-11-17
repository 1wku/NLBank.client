using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class ChucVuDTO
    {
        public int MaCV { set; get; }
        public string TenCV { set; get; }
        public decimal HSLuong { set; get; }
        public ChucVuDTO(int maCV, string tenCV, decimal hSLuong)
        {
            MaCV = maCV;
            TenCV = tenCV;
            HSLuong = hSLuong;
        }
        public ChucVuDTO()
        {

        }
    }
}
