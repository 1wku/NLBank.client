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
    public class CTGNDAL
    {
        public static DataTable getView()
        {
            String cmd = "Select * From disbursementPaper";
            SqlConnection Con = Connection.KetNoi();
            SqlCommand command = new SqlCommand(cmd, Con);
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();
            return dt;
        }
        public static DataTable GetListGN(int makh)
        {
            String sql = "SELECT SoHDTD , SoTienGiaiNgan FROM CHUNGTUGIAINGAN WHERE MaKH = " + makh;
            return Connection.Instance.ExcuteQuery(sql);
        }
        public static void ThemCTGN(CTGNDTO ctgn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_addDisbursementPaper", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@disbursementCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters.Add("@branchCode", SqlDbType.Char);
            command.Parameters.Add("@moneyDisbursement", SqlDbType.Int);
            command.Parameters["@disbursementCode"].Value = ctgn.SoCTGN;
            command.Parameters["@HDTDCode"].Value = ctgn.SoHDTD;
            command.Parameters["@branchCode"].Value = ctgn.MaCN;
            command.Parameters["@moneyDisbursement"].Value = ctgn.SoTienGiaiNgan;
           
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void SuaCTGN(CTGNDTO ctgn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_updateDisbursementPaper", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@disbursementCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters.Add("@branchCode", SqlDbType.Char);
            command.Parameters.Add("@moneyDisbursement", SqlDbType.Int);
            command.Parameters["@disbursementCode"].Value = ctgn.SoCTGN;
            command.Parameters["@HDTDCode"].Value = ctgn.SoHDTD;
            command.Parameters["@branchCode"].Value = ctgn.MaCN;
            command.Parameters["@moneyDisbursement"].Value = ctgn.SoTienGiaiNgan;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaCTGN(CTGNDTO ctgn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_deleteDisbursementPaper", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@disbursementCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters["@disbursementCode"].Value = ctgn.SoCTGN;
            command.Parameters["@HDTDCode"].Value = ctgn.SoHDTD;
           
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
