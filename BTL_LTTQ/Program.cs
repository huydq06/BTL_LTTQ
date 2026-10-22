using System;
using System.Windows.Forms;

namespace BTL_LTTQ
{
    internal static class Program
    {
        /// <summary>
        /// Điểm vào của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Đăng nhập thành công mới vào form chính
            using (var dangNhap = new FrmDangNhap())
            {
                if (dangNhap.ShowDialog() != DialogResult.OK) return;
            }
            Application.Run(new FrmChinh());
        }
    }
}
