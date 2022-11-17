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
    public class CTTNDAL
    {
        public static DataTable getView()
        {
            String cmd = "Select * From payBackPaper ";
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
        public static void ThemCTTN(int mahd , int macn , int sotienvay)
        {

            try
            {
                Console.WriteLine($"EXEC sp_ThemCTTN {mahd} ,{macn} , {sotienvay}"); 
                Connection.Instance.ExcuteNonQuery($"EXEC sp_ThemCTTN {mahd} ,{macn} , {sotienvay}");   
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm chứng từ thu nợ không thành công. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
        public static void SuaCTTN(CTTNDTO cttn)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("sp_CapNhatCTTN", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@payBackCode", SqlDbType.Int);
            command.Parameters.Add("@HDTDCode", SqlDbType.Int);
            command.Parameters.Add("@branchCode", SqlDbType.Int);
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
            try
            {
                //CTTNDAL.ThemCTTN(thuno); 
                SqlConnection Conn = Connection.KetNoi();
                SqlCommand command = new SqlCommand("sp_XoaCTTN", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@payBackCode", SqlDbType.Int);
                command.Parameters.Add("@HDTDCode", SqlDbType.Int);
                command.Parameters["@payBackCode"].Value = cttn.SoCTThuNo;
                command.Parameters["@HDTDCode"].Value = cttn.SoHDTD;

                Conn.Open();
                command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa chứng từ không thành công. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
