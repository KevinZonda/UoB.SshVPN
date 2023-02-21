using System.Diagnostics;

namespace KevinZonda.UoB.SshVPN.Controller;

internal class BaseController
{
    public static void Stop()
    {
        WinProxyConfig.Unset();
        Socks2Http.Stop();
        SshController.Stop();
    }

    public static void StartLocally(string username, string password)
    {
        Stop();
        SshController.Start(username, password);
    }

    public static void StartGlobally(string username, string password)
    {
        StartLocally(username, password);
        Socks2Http.Start();
        WinProxyConfig.Set("127.0.0.1", ConstText.HTTP_LISTEN);
    }
}
