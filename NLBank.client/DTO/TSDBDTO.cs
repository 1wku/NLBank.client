using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class TSDBDTO
    {
        private int _MaTSDB; 
        private int _MaLoaiTSDB ; 
        private String _TenTSDB ; 
        private int _MaKH ; 
        private int _TriGiaTS =0;  
        private String _HinhThucDB ; 
        public int MaTSDB {
            get { return _MaTSDB; }
            set { _MaTSDB = value; } 
        }
        public int MaLoaiTSDB {
            get { return _MaLoaiTSDB; }
            set { _MaLoaiTSDB = value; }
        }
        public String TenLoaiTSDB { set; get; }
        public String TenTSDB {
            get { return _TenTSDB; }
            set { _TenTSDB = value; }
        }
        public int MaKH {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        public int TriGiaTS {
            get { return _TriGiaTS; }
            set { _TriGiaTS = value; }
        }
        public String HinhThucDB {
            get { return _HinhThucDB; }
            set { _HinhThucDB = value; }
        }
        public TSDBDTO(int maTSDB, int maLoaiTSDB, String tenTSDB, int maKH, int triGiaTS, String hinhThucDB)
        {
            _MaTSDB = maTSDB;
            _MaLoaiTSDB = maLoaiTSDB;
            _TenTSDB = tenTSDB;
            _MaKH = maKH;
            _TriGiaTS = triGiaTS;
            _HinhThucDB = hinhThucDB;
        }
        public TSDBDTO() { }
    }
}
