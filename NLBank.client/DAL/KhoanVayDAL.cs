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
    public class KhoanVayDAL
    {
        public static DataTable getView()
        {
            String cmd = "Select * From KhoanVay";
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

        public static DataTable GetListKVChuaDuyet(int makh)
        {
            string sql = "SELECT * FROM f_KVChuaSuDung() WHERE MaKH = "+ makh;
            return Connection.Instance.ExcuteQuery(sql);
        }

        public static DataTable getListSoTienVayByMaKH(int makh)
        {
            String sql = "SELECT SoTienVay FROM dbo.f_KVChuaSuDung() WHERE MaKH =" + makh;
            return Connection.Instance.ExcuteQuery(sql);
        }
        public static DataTable GetLoaiKV()
        {
            String sql = "SELECT * FROM LOAIKV";
            return Connection.Instance.ExcuteQuery(sql);
        }
        public static Boolean ThemKhoanVay(KhoanVayDTO kv)
        {
            try
            {
                SqlConnection Conn = Connection.KetNoi();
                SqlCommand command = new SqlCommand("sp_ThemKhoanVay", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaKH", SqlDbType.Char);
                command.Parameters.Add("@MaTSDB", SqlDbType.Char);
                command.Parameters.Add("@MaLoaiKV", SqlDbType.Char);
                command.Parameters.Add("@MucDich", SqlDbType.NVarChar);
                command.Parameters.Add("@SoTienVay", SqlDbType.Int);
                command.Parameters.Add("@LoaiTien", SqlDbType.Char);
                command.Parameters["@MaKH"].Value = kv.MaKH;
                command.Parameters["@MaTSDB"].Value = kv.MaTSDB;
                command.Parameters["@MaLoaiKV"].Value = kv.MaLoaiKV;
                command.Parameters["@MucDich"].Value = kv.MucDich;
                command.Parameters["@SoTienVay"].Value = kv.SoTienVay;
                command.Parameters["@LoaiTien"].Value = kv.LoaiTien;

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
        public static void SuaKhoanVay(KhoanVayDTO kv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("SuaKhoanVay", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKV", SqlDbType.Char);
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@MaTSDB", SqlDbType.Char);
            command.Parameters.Add("@MaLoaiKV", SqlDbType.Char);
            command.Parameters.Add("@MucDich", SqlDbType.NVarChar);
            command.Parameters.Add("@SoTienVay", SqlDbType.Int);
            command.Parameters.Add("@LoaiTien", SqlDbType.Char);
            command.Parameters["@MaKV"].Value = kv.MaKV;
            command.Parameters["@MaKH"].Value = kv.MaKH;
            command.Parameters["@MaTSDB"].Value = kv.MaTSDB;
            command.Parameters["@MaLoaiKV"].Value = kv.MaLoaiKV;
            command.Parameters["@MucDich"].Value = kv.MucDich;
            command.Parameters["@SoTienVay"].Value = kv.SoTienVay;
            command.Parameters["@LoaiTien"].Value = kv.LoaiTien;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaKhoanVay(int id)
        {
            try
            {
                if (KhoanVayDAL.LaKhoanVayDangSuDung(id))
                {
                    MessageBox.Show("Khoản vay đã có hợp đồng. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return; 
                }
                SqlConnection Conn = Connection.KetNoi();
                SqlCommand command = new SqlCommand("XoaKhoanVay", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaKV", SqlDbType.Int);
                command.Parameters["@MaKV"].Value = id;

                Conn.Open();
                command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e); 
                MessageBox.Show("Xóa khoản vay không thành công. Vui lòng thử lại hoặc báo cho quản trị viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public static List<KhoanVayDTO> getAll()
        {
           
            List<KhoanVayDTO> danhsach = new List<KhoanVayDTO>();

            DataTable data = Connection.Instance.ExcuteQuery("select * from KHOANVAY");

            foreach (DataRow item in data.Rows)
            {
                KhoanVayDTO ban = new KhoanVayDTO(item);
                danhsach.Add(ban);
            }

            return danhsach;
        }
        public static Boolean LaKhoanVayDangSuDung(int id)
        {
            DataTable result = Connection.Instance.ExcuteQuery($"SELECT dbo.La_KV_DangSuDung({id}) ");
            return (Boolean) result.Rows[0][0]; 

        }
        public static DataTable getKVChuaSuDung()
        {
            return Connection.Instance.ExcuteQuery("select * from f_KVChuaSuDung() "); 
        }
        public static DataTable getKVDaSuDung()
        {
            return Connection.Instance.ExcuteQuery("select * from f_KVDaSuDung() ");
        }

    }
}
