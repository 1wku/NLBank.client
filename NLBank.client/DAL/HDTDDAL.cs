﻿using NLBank.client.DTO;
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
            String cmd = "Select * From contract";
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
        public static void ThemHDTD(HDTDDTO hdtd)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("ThemHopDongTinDung", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SoHDTD", SqlDbType.Char);
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@MaKV", SqlDbType.Char);
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
        public static void SuaHDTD(HDTDDTO hdtd)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("SuaHopDongTinDung", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SoHDTD", SqlDbType.Char);
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@MaKV", SqlDbType.Char);
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
            SqlCommand command = new SqlCommand("XoaHopDongTinDung", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SoHDTD", SqlDbType.Char); 

            command.Parameters["@SoHDTD"].Value = hdtd.SoHDTD;
            
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}