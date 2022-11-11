using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    public class DKDAL
    {
        public static void ThemDK(DKDTO dk)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_themChiNhanh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDK", SqlDbType.Char);
            command.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
            command.Parameters.Add("@pct", SqlDbType.Decimal);

            command.Parameters["@MaDK"].Value = dk.MaDK;
            command.Parameters["@NoiDung"].Value = dk.NoiDung;
            command.Parameters["@pct"].Value = dk.Pct_lai;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void SuaDK(DKDTO dk)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_suaChiNhanh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDK", SqlDbType.Char);
            command.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
            command.Parameters.Add("@pct", SqlDbType.Decimal);

            command.Parameters["@MaDK"].Value = dk.MaDK;
            command.Parameters["@NoiDung"].Value = dk.NoiDung;
            command.Parameters["@pct"].Value = dk.Pct_lai;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void XoaDK(DKDTO dk)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_xoaChiNhanh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDK", SqlDbType.Char);
            
            command.Parameters["@MaDK"].Value = dk.MaDK;
            
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
