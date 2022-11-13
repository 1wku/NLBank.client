using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;

namespace NLBank.client.DAL
{
    public class NhanvienDAL
    {
        public static DataTable getView()
        {
            String cmd = "select * from BanLanhDao_DanhSachNhanVien";
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
        public static void ThemNhanVien(NhanvienDTO nv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_ThemNhanVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.Char);
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar);
            command.Parameters.Add("@Ten", SqlDbType.NVarChar);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            command.Parameters.Add("@Email", SqlDbType.Char);
            command.Parameters.Add("@Sdt", SqlDbType.Char);
            command.Parameters.Add("@MaCV", SqlDbType.Char);

            command.Parameters["@MaNV"].Value = nv.MaNV; 
            command.Parameters["@CCD"].Value = nv.CCCD;
            command.Parameters["@Ten"].Value = nv.Ten;
            command.Parameters["@DiaChi"].Value = nv.Dia_chi;
            command.Parameters["@Email"].Value = nv.Email;
            command.Parameters["@Sdt"].Value = nv.Sdt; 
            command.Parameters["@MaCV"].Value = nv.MaCV; 

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void SuaNhanVien(NhanvienDTO nv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_SuaNhanVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.Char);
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar);
            command.Parameters.Add("@Ten", SqlDbType.NVarChar);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            command.Parameters.Add("@Email", SqlDbType.Char);
            command.Parameters.Add("@Sdt", SqlDbType.Char);
            command.Parameters.Add("@MaCV", SqlDbType.Char);

            command.Parameters["@MaNV"].Value = nv.MaNV;
            command.Parameters["@CCD"].Value = nv.CCCD;
            command.Parameters["@Ten"].Value = nv.Ten;
            command.Parameters["@DiaChi"].Value = nv.Dia_chi;
            command.Parameters["@Email"].Value = nv.Email;
            command.Parameters["@Sdt"].Value = nv.Sdt;
            command.Parameters["@MaCV"].Value = nv.MaCV;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaNhanVien(KHDTO kh)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_XoaNhanVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.Char);

            command.Parameters["@MaNV"].Value = kh.MaKH;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
