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
    public class TSDBDAL
    {
        public static DataTable getView()
        {
            String cmd = "Select * From DanhSachTSDB";
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
        public static void ThemTSDB(TSDBDTO tsdb)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("ThemTaiSanDamBao", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTSDB", SqlDbType.Char);
            command.Parameters.Add("@MaLoaiTSDB", SqlDbType.Char);
            command.Parameters.Add("@TenTSDB", SqlDbType.NVarChar);
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@TriGiaTS", SqlDbType.Int);
            command.Parameters.Add("@HinhThucDB", SqlDbType.NVarChar);
            command.Parameters["@MaTSDB"].Value = tsdb.MaTSDB;
            command.Parameters["@MaLoaiTSDB"].Value = tsdb.MaLoaiTSDB;
            command.Parameters["@TenTSDB"].Value = tsdb.TenTSDB;
            command.Parameters["@MaKH"].Value = tsdb.MaKH;
            command.Parameters["@TriGiaTS"].Value = tsdb.TriGiaTS;
            command.Parameters["@HinhThucDB"].Value = tsdb.HinhThucDB;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void SuaTSDB(TSDBDTO tsdb)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("SuaTaiSanDamBao", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTSDB", SqlDbType.Char);
            command.Parameters.Add("@MaLoaiTSDB", SqlDbType.Char);
            command.Parameters.Add("@TenTSDB", SqlDbType.NVarChar);
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@TriGiaTS", SqlDbType.Int);
            command.Parameters.Add("@HinhThucDB", SqlDbType.NVarChar);
            command.Parameters["@MaTSDB"].Value = tsdb.MaTSDB;
            command.Parameters["@MaLoaiTSDB"].Value = tsdb.MaLoaiTSDB;
            command.Parameters["@TenTSDB"].Value = tsdb.TenTSDB;
            command.Parameters["@MaKH"].Value = tsdb.MaKH;
            command.Parameters["@TriGiaTS"].Value = tsdb.TriGiaTS;
            command.Parameters["@HinhThucDB"].Value = tsdb.HinhThucDB;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaTSDB(TSDBDTO tsdb)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("XoaTaiSanDamBao", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTSDB", SqlDbType.Char);
            command.Parameters["@MaTSDB"].Value = tsdb.MaTSDB;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
