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

            // TODO: khi đã có FrmDangNhap và FrmChinh (Form1 đã đổi tên), bỏ dòng Form1 bên dưới
            // và bật lại đoạn comment này: đăng nhập OK mới vào form chính.
            //
            // using (var dangNhap = new FrmDangNhap())
            // {
            //     if (dangNhap.ShowDialog() != DialogResult.OK) return;
            // }
            // Application.Run(new FrmChinh());

            Application.Run(new Form1());
        }
    }
}
