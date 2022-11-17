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
    public class HDTDDAL
    {
        public static DataTable getView()
        {           
            String cmd = "Select * From HopDong";
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
        public static Boolean ThemHDTD(HDTDDTO hdtd)
        {
            try
            {
                SqlConnection Conn = Connection.KetNoi();
                SqlCommand command = new SqlCommand("sp_ThemHopDongTinDung", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaKH", SqlDbType.Int);
                command.Parameters.Add("@MaKV", SqlDbType.Int);
                command.Parameters.Add("@Muc_dich", SqlDbType.NVarChar);
                command.Parameters.Add("@LaiSuat", SqlDbType.Decimal);
                command.Parameters.Add("@LaiQuaHan", SqlDbType.Decimal);
                command.Parameters.Add("@ThoiHanVay", SqlDbType.Int);
                command.Parameters.Add("@PhuongThucTra", SqlDbType.Char);
                command.Parameters.Add("@MucPhi", SqlDbType.Int);
                command.Parameters.Add("@TGGiaiNgan", SqlDbType.Date);
                command.Parameters.Add("@LoaiTien", SqlDbType.Char);
                command.Parameters.Add("@NgayKi", SqlDbType.Date);

                command.Parameters["@MaKH"].Value = hdtd.MaKH;
                command.Parameters["@MakV"].Value = hdtd.MAKV;
                command.Parameters["@Muc_dich"].Value = hdtd.Muc_dich;
                command.Parameters["@LaiSuat"].Value = hdtd.LaiSuat;
                command.Parameters["@LaiQuaHan"].Value = hdtd.LaiQuaHan;
                command.Parameters["@ThoiHanVay"].Value = hdtd.ThoiHanVay;
                command.Parameters["@PhuongThucTra"].Value = hdtd.PhuongThucTra;
                command.Parameters["@MucPhi"].Value = hdtd.MucPhi;
                command.Parameters["@TGGiaiNgan"].Value = hdtd.TGGiaiNgan;
                command.Parameters["@LoaiTien"].Value = hdtd.LoaiTien;
                command.Parameters["@NgayKi"].Value = hdtd.NgayKi;

                Conn.Open();
                var reader = (string)command.ExecuteScalar();
                Console.WriteLine(reader);
                Conn.Close();
                return true; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false; 
            }
           
        }
        public static void SuaHDTD(HDTDDTO hdtd)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_SuaHopDongTinDung", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SoHDTD", SqlDbType.Int);
            command.Parameters.Add("@MaKH", SqlDbType.Int);
            command.Parameters.Add("@MaKV", SqlDbType.Int);
            command.Parameters.Add("@Muc_dich", SqlDbType.NVarChar);
            command.Parameters.Add("@LaiSuat", SqlDbType.Decimal);
            command.Parameters.Add("@LaiQuaHan", SqlDbType.Decimal);
            command.Parameters.Add("@ThoiHanVay", SqlDbType.Int);
            command.Parameters.Add("@PhuongThucTra", SqlDbType.Char);
            command.Parameters.Add("@MucPhi", SqlDbType.Int);
            command.Parameters.Add("@TGGiaiNgan", SqlDbType.Date);
            command.Parameters.Add("@LoaiTien", SqlDbType.Char);
            command.Parameters.Add("@NgayKi", SqlDbType.Date);

            command.Parameters["@SoHDTD"].Value = hdtd.SoHDTD;
            command.Parameters["@MaKH"].Value = hdtd.MaKH;
            command.Parameters["@MakV"].Value = hdtd.MAKV;
            command.Parameters["@Muc_dich"].Value = hdtd.Muc_dich;
            command.Parameters["@LaiSuat"].Value = hdtd.LaiSuat;
            command.Parameters["@LaiQuaHan"].Value = hdtd.LaiQuaHan;
            command.Parameters["@ThoiHanVay"].Value = hdtd.ThoiHanVay;
            command.Parameters["@PhuongThucTra"].Value = hdtd.PhuongThucTra;
            command.Parameters["@MucPhi"].Value = hdtd.MucPhi;
            command.Parameters["@TGGiaiNgan"].Value = hdtd.TGGiaiNgan;
            command.Parameters["@LoaiTien"].Value = hdtd.LoaiTien;
            command.Parameters["@NgayKi"].Value = hdtd.NgayKi;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaHDTD(HDTDDTO hdtd)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_XoaHopDongTinDung", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SoHDTD", SqlDbType.Int); 

            command.Parameters["@SoHDTD"].Value = hdtd.SoHDTD;
            
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static Boolean CheckOverTimeHDTD(int id)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("select dbo.f_LaHDTDQuaHan('" + id+"')", Conn);

            Conn.Open();
             var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // Đọc từng dòng tập kết quả
                while (reader.Read())
                {
                    var data = reader.GetInt32(0);
                    if (data == 0) return false;
                    else return true; 

                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu trả về");
                return true; 
            }
            Conn.Close();
            return true; 
        }


    }
}
