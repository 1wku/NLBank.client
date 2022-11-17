using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLBank.client.DAL
{
    public class TSDBDAL
    {
        public static DataTable getView()
        {
            String cmd = "Select * From TAISANDAMBAO";
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

        public static DataTable GetListTSDB(int makh)
        {
            String sql = "SELECT * FROM TAISANDAMBAO WHERE MaKH = " + makh;
            return Connection.Instance.ExcuteQuery(sql);
        }

        public static DataTable GetListTSDBChuaSD(int makh)
        {
            String sql = "SELECT * FROM f_TSDBChuaSuDung() WHERE MaKH = " + makh;
            return Connection.Instance.ExcuteQuery(sql);
        }

        public static DataTable GetListTSDBDaSD(int makh)
        {
            String sql = "SELECT * FROM f_TSDBDaSuDung() WHERE MaKH = " + makh;
            return Connection.Instance.ExcuteQuery(sql);
        }

        public static DataTable GetListTSDBbyName(String searchString, int makh)
        {
            String sql = "SELECT * from TAISANDAMBAO where TenTSDB like '" + searchString+ "' and MaKH = " + makh;
            return Connection.Instance.ExcuteQuery(sql);
        }

        public static DataTable GetListTSDBbyLoaiTSDB(int maLoaiTSDB)
        {
            String sql = "SELECT * from TAISANDAMBAO where MaLoaiTSDB =" + maLoaiTSDB;
            return Connection.Instance.ExcuteQuery(sql);
        }

        public static DataTable getLoaiTSDB()
        {
            String sql = "SELECT * FROM LOAITSDB";
            return Connection.Instance.ExcuteQuery(sql);
        }
        public static Boolean ThemTSDB(TSDBDTO tsdb)
        {
            try
            {
                SqlConnection Conn = Connection.KetNoi();
                SqlCommand command = new SqlCommand("sp_ThemTaiSanDamBao", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaLoaiTSDB", SqlDbType.Int);
                command.Parameters.Add("@TenTSDB", SqlDbType.NVarChar);
                command.Parameters.Add("@MaKH", SqlDbType.Int);
                command.Parameters.Add("@TriGiaTS", SqlDbType.Int);
                command.Parameters.Add("@HinhThucDB", SqlDbType.NVarChar);
                command.Parameters["@MaLoaiTSDB"].Value = tsdb.MaLoaiTSDB;
                command.Parameters["@TenTSDB"].Value = tsdb.TenTSDB;
                command.Parameters["@MaKH"].Value = tsdb.MaKH;
                command.Parameters["@TriGiaTS"].Value = tsdb.TriGiaTS;
                command.Parameters["@HinhThucDB"].Value = tsdb.HinhThucDB;
                Conn.Open();
                command.ExecuteNonQuery();
                Conn.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }
        public static void SuaTSDB(TSDBDTO tsdb)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_SuaTaiSanDamBao", Conn);
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
        public static void XoaTSDB(int id)
        {
            try {             
                SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_XoaTaiSanDamBao", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTSDB", SqlDbType.Char);
            command.Parameters["@MaTSDB"].Value = id;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        
            }
            catch(Exception e)
            {
                MessageBox.Show("Xóa tài sản không thành công. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
