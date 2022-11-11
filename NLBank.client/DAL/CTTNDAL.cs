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
    public class CTTNDAL
    {
        public static DataTable getView()
        {
            String cmd = "Select * From payBackPaper";
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
        public static void ThemCTTN(CTTNDTO cttn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_addPayBackPaper", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@payBackCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters.Add("@branchCode", SqlDbType.Char);
            command.Parameters.Add("@originalSign", SqlDbType.Date);
            command.Parameters.Add("@raisedSign", SqlDbType.Date);
            command.Parameters.Add("@leftMoney", SqlDbType.Int);
            command.Parameters.Add("@payBackMoney", SqlDbType.Int);
            command.Parameters.Add("@leftDebt", SqlDbType.Int);
            command.Parameters.Add("@payBackDate", SqlDbType.Date);
            command.Parameters["@payBackCode"].Value = cttn.SoCTThuNo;
            command.Parameters["@HDTDCode"].Value = cttn.SoHDTD;
            command.Parameters["@branchCode"].Value = cttn.MaCN;
            command.Parameters["@originalSign"].Value = cttn.KyThuNoGoc;
            command.Parameters["@raisedSign"].Value = cttn.KyThuNoLai;
            command.Parameters["@leftMoney"].Value = cttn.SoDuNo;
            command.Parameters["@payBackMoney"].Value = cttn.SoTienTra;
            command.Parameters["@leftDebt"].Value = cttn.SoDuNoGoc;
            command.Parameters["@payBackDate"].Value = cttn.NgayThuNo;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void SuaCTTN(CTTNDTO cttn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_updatePayBackPaper", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@payBackCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters.Add("@branchCode", SqlDbType.Char);
            command.Parameters.Add("@originalSign", SqlDbType.Date);
            command.Parameters.Add("@raisedSign", SqlDbType.Date);
            command.Parameters.Add("@leftMoney", SqlDbType.Int);
            command.Parameters.Add("@payBackMoney", SqlDbType.Int);
            command.Parameters.Add("@leftDebt", SqlDbType.Int);
            command.Parameters.Add("@payBackDate", SqlDbType.Date);
            command.Parameters["@payBackCode"].Value = cttn.SoCTThuNo;
            command.Parameters["@HDTDCode"].Value = cttn.SoHDTD;
            command.Parameters["@branchCode"].Value = cttn.MaCN;
            command.Parameters["@originalSign"].Value = cttn.KyThuNoGoc;
            command.Parameters["@raisedSign"].Value = cttn.KyThuNoLai;
            command.Parameters["@leftMoney"].Value = cttn.SoDuNo;
            command.Parameters["@payBackMoney"].Value = cttn.SoTienTra;
            command.Parameters["@leftDebt"].Value = cttn.SoDuNoGoc;
            command.Parameters["@payBackDate"].Value = cttn.NgayThuNo;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaCTTN(CTTNDTO cttn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_deletePayBackPaper", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@payBackCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters["@payBackCode"].Value = cttn.SoCTThuNo;
            command.Parameters["@HDTDCode"].Value = cttn.SoHDTD;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
