using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class CHUCVUDTO
    {
        private String _MaCV;
        private String _TenCV;
        private String _HSLuong;

        public String MaCV { get { return _MaCV; } set { _MaCV = value;} }
        public String TenCV { get { return _TenCV; } set { _TenCV = value;} }
        public String HSLuong { get { return _HSLuong; } set { _HSLuong = value;} }
    }
}
