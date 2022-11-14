using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class LoaiTSDTO    {
        public int MaLoaiTS { set; get; }
        public string LoaiTS { set; get; }
        public LoaiTSDTO(int id, string name) {
            MaLoaiTS = id;
            LoaiTS = name;  
        }
    }
}
