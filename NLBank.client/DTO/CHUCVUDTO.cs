using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class ChucVuDTO
    {
        private int _MaCV;
        private String _TenCV;
        private decimal _HsLuong;

        public int MaCV {
            get { return _MaCV; }
            set { _MaCV = value; }
        }
        public String TenCV
        {
            get { return _TenCV; }
            set { _TenCV = value; }
        }
        public decimal HsLuong
        {
            get { return _HsLuong; }
            set { _HsLuong = value; }
        }

        public ChucVuDTO() { }

        public ChucVuDTO(DataRow row)
        {
            _MaCV = (int)row["MaCV"];
            _TenCV = row["TenCV"].ToString();
            _HsLuong = (decimal)row["HSLuong"];
        }
    }
}
