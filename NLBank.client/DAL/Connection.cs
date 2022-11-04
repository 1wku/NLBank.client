using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    class Connection
    {
        public static SqlConnection KetNoi()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=NLBank;Integrated Security=True");
            return Con;
        }
    }
}
