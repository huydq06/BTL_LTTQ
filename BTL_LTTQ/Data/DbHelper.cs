using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BTL_LTTQ.Data
{
    // Một lệnh SQL kèm tham số, dùng cho giao dịch nhiều bước
    public class Lenh
    {
        public string Sql;
        public SqlParameter[] ThamSo;
        // true: nếu lệnh không ảnh hưởng dòng nào thì hủy cả giao dịch (vd kiểm tra tồn kho)
        public bool PhaiCoDong;

        public Lenh(string sql, params SqlParameter[] thamSo)
        {
            Sql = sql;
            ThamSo = thamSo;
        }

        public Lenh(bool phaiCoDong, string sql, params SqlParameter[] thamSo) : this(sql, thamSo)
        {
            PhaiCoDong = phaiCoDong;
        }
    }

    // Lớp truy cập CSDL dùng chung
    public static class DbHelper
    {
        // Chuỗi kết nối đọc từ App.config
        private static string ChuoiKetNoi
        {
            get { return ConfigurationManager.ConnectionStrings["CyberGameDB"].ConnectionString; }
        }

        // Tạo tham số, tự đổi null thành DBNull
        public static SqlParameter Tham(string ten, object giaTri)
        {
            return new SqlParameter(ten, giaTri ?? DBNull.Value);
        }

        // SELECT trả về DataTable
        public static DataTable LayBang(string sql, params SqlParameter[] thamSo)
        {
            using (var kn = new SqlConnection(ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, kn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                var bang = new DataTable();
                da.Fill(bang);
                return bang;
            }
        }

        // INSERT/UPDATE/DELETE, trả về số dòng bị ảnh hưởng
        public static int ThucThi(string sql, params SqlParameter[] thamSo)
        {
            using (var kn = new SqlConnection(ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, kn))
            {
                if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                kn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Trả về ô đầu tiên của kết quả (COUNT, SUM, SCOPE_IDENTITY...); không có thì null
        public static object LayGiaTri(string sql, params SqlParameter[] thamSo)
        {
            using (var kn = new SqlConnection(ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, kn))
            {
                if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                kn.Open();
                object kq = cmd.ExecuteScalar();
                return kq == DBNull.Value ? null : kq;
            }
        }

        // Chạy nhiều lệnh trong MỘT giao dịch: lỗi hoặc lệnh PhaiCoDong không có dòng nào thì hoàn tác tất cả
        public static void ThucThiGiaoDich(IEnumerable<Lenh> cacLenh)
        {
            using (var kn = new SqlConnection(ChuoiKetNoi))
            {
                kn.Open();
                using (var gd = kn.BeginTransaction())
                {
                    try
                    {
                        foreach (var l in cacLenh)
                        {
                            using (var cmd = new SqlCommand(l.Sql, kn, gd))
                            {
                                if (l.ThamSo != null) cmd.Parameters.AddRange(l.ThamSo);
                                int dong = cmd.ExecuteNonQuery();
                                if (l.PhaiCoDong && dong == 0)
                                    throw new InvalidOperationException("Thao tác không thực hiện được (dữ liệu đã thay đổi hoặc không đủ điều kiện).");
                            }
                        }
                        gd.Commit();
                    }
                    catch
                    {
                        gd.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
