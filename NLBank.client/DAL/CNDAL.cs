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
    public class CNDAL
    {
        public static void ThemCN (CNDTO cn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_themChiNhanh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaCN", SqlDbType.Char);
            command.Parameters.Add("@TenChiNhanh", SqlDbType.Char);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
           
            command.Parameters["@MaCN"].Value = cn.MaCN;
            command.Parameters["@TenChiNhanh"].Value = cn.Chi_nhanh;
            command.Parameters["@DiaChi"].Value = cn.Dia_chi;
            
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void SuaCN(CNDTO cn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_suaChiNhanh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaCN", SqlDbType.Char);
            command.Parameters.Add("@TenChiNhanh", SqlDbType.Char);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar);

            command.Parameters["@MaCN"].Value = cn.MaCN;
            command.Parameters["@TenChiNhanh"].Value = cn.Chi_nhanh;
            command.Parameters["@DiaChi"].Value = cn.Dia_chi;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void XoaCN(CNDTO cn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_xoaChiNhanh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaCN", SqlDbType.Char);
            command.Parameters.Add("@TenChiNhanh", SqlDbType.Char);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar);

            command.Parameters["@MaCN"].Value = cn.MaCN;
            command.Parameters["@TenChiNhanh"].Value = cn.Chi_nhanh;
            command.Parameters["@DiaChi"].Value = cn.Dia_chi;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
