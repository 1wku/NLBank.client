using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    public class CNDTO
    {
        private String _MaCN;
        private String _Chi_nhanh;
        private String _Dia_chi;

        public String MaCN { get { return _MaCN; } set { _MaCN = value; } }
        public String Chi_nhanh { get { return _Chi_nhanh; } set { _Chi_nhanh = value; } }
        public String Dia_chi { get { return _Dia_chi; } set { _Dia_chi = value; } }
        public CNDTO( String maCN, String chi_nhanh, String dia_chi)
        {
            _MaCN = maCN;
            _Chi_nhanh = chi_nhanh;
            _Dia_chi = dia_chi;
        }
        public CNDTO() { }
    }
}
