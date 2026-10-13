namespace MdiManager;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Vòng lặp: Đăng nhập -> FormMain. Đăng xuất thì quay lại màn hình đăng nhập.
        while (true)
        {
            string userName;
            using (var login = new FormLogin())
            {
                if (login.ShowDialog() != DialogResult.OK) return;
                userName = login.UserName;
            }

            using var main = new FormMain { UserName = userName };
            Application.Run(main);

            if (!main.LoggedOut) return;
        }
    }
}
