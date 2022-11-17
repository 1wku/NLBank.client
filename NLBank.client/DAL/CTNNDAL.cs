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
    public class CTNNDAL
    {
        public static DataTable getView()
        {
            String cmd = "Select * From GiayNo";
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
        public static DataTable GetListNN(int makh)
        {
            String sql = "SELECT SoHDTD, NgayKyGNN, HanTraNo FROM GIAYNHANNO WHERE MaKH =" + makh;
            return Connection.Instance.ExcuteQuery(sql);
        }
        public static void ThemCTNN(CTNNDTO ctnn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_ThemGiayNhanNo", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@DebtCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters.Add("@guestCode", SqlDbType.Char);
            command.Parameters.Add("@signDate", SqlDbType.Date);
            command.Parameters.Add("@branchCode", SqlDbType.Char);
            command.Parameters.Add("@creditLimit", SqlDbType.Int);
            command.Parameters.Add("@promiseDate", SqlDbType.Date);
            command.Parameters.Add("@overTimeRate", SqlDbType.Decimal);
            command.Parameters.Add("@originRate", SqlDbType.Decimal);
            command.Parameters["@DebtCode"].Value = ctnn.SoGNN;
            command.Parameters["@HDTDCode"].Value = ctnn.SoHDTD;
            command.Parameters["@guestCode"].Value = ctnn.MaKH;
            command.Parameters["@signDate"].Value = ctnn.NgayKyGNN;
            command.Parameters["@branchCode"].Value = ctnn.MaCN;
            command.Parameters["@creditLimit"].Value = ctnn.HanMucTinDung;
            command.Parameters["@promiseDate"].Value = ctnn.HanTraNo;
            command.Parameters["@overTimeRate"].Value = ctnn.LaiQuaHan;
            command.Parameters["@originRate"].Value = ctnn.LaiSuat;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void SuaCTNN(CTNNDTO ctnn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_CapNhatGiayNhanNo", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@DebtCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters.Add("@guestCode", SqlDbType.Char);
            command.Parameters.Add("@signDate", SqlDbType.Date);
            command.Parameters.Add("@branchCode", SqlDbType.Char);
            command.Parameters.Add("@creditLimit", SqlDbType.Int);
            command.Parameters.Add("@promiseDate", SqlDbType.Date);
            command.Parameters.Add("@overTimeRate", SqlDbType.Decimal);
            command.Parameters.Add("@originRate", SqlDbType.Decimal);
            command.Parameters["@DebtCode"].Value = ctnn.SoGNN;
            command.Parameters["@HDTDCode"].Value = ctnn.SoHDTD;
            command.Parameters["@guestCode"].Value = ctnn.MaKH;
            command.Parameters["@signDate"].Value = ctnn.NgayKyGNN;
            command.Parameters["@branchCode"].Value = ctnn.MaCN;
            command.Parameters["@creditLimit"].Value = ctnn.HanMucTinDung;
            command.Parameters["@promiseDate"].Value = ctnn.HanTraNo;
            command.Parameters["@overTimeRate"].Value = ctnn.LaiQuaHan;
            command.Parameters["@originRate"].Value = ctnn.LaiSuat;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaCTNN(CTNNDTO ctnn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_XoaGiayNhanNo", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@DebtCode", SqlDbType.Char);
            command.Parameters.Add("@HDTDCode", SqlDbType.Char);
            command.Parameters["@DebtCode"].Value = ctnn.SoGNN;
            command.Parameters["@HDTDCode"].Value = ctnn.SoHDTD;
            
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static int GetSoduNo(int hdid)
        {
            try
            {
                object rs = Connection.Instance.ExecuteScalar($"SELECT TOP 1 SoDuNo FROM CHUNGTUTHUNO WHERE SoHDTD = {hdid} ORDER BY SoCTThuNo DESC");
                if (rs != null)
                    return (int)rs;
                return 0;
            }
            catch(Exception e)
            {
                return 0; 
            }

        }
    }
}
