using System.Security.Cryptography;
using System.Text;

namespace BTL_LTTQ.Common
{
    // Băm mật khẩu SHA256, kết quả là chuỗi hex HOA (khớp HASHBYTES('SHA2_256') trong SQL)
    public static class BaoMat
    {
        public static string Bam(string matKhau)
        {
            using (var sha = SHA256.Create())
            {
                byte[] kq = sha.ComputeHash(Encoding.UTF8.GetBytes(matKhau ?? ""));
                var sb = new StringBuilder(64);
                foreach (byte b in kq) sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }

        // So khớp mật khẩu nhập với chuỗi băm đã lưu
        public static bool KhopMatKhau(string matKhau, string bamDaLuu)
        {
            return string.Equals(Bam(matKhau), bamDaLuu, System.StringComparison.OrdinalIgnoreCase);
        }
    }
}
