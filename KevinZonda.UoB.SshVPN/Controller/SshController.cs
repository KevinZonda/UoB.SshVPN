using System.Diagnostics;

namespace KevinZonda.UoB.SshVPN.Controller;

internal static class SshController
{
    private const string ADDRESS = "tw.cs.bham.ac.uk";
    private static Process? _p = null;
    public static void Start(string username, string password)
    {
        Stop();
        _p = new()
        {
            StartInfo = new()
            {
                FileName = "cmd.exe",
                Arguments = $"/c echo \"n\" | {ConstText.PLINK_BIN} {username}@{ADDRESS} -pw \"{password}\" -D 127.0.0.1:{ConstText.SOCKS_LISTEN} -N",
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };
        _p.Start();

        Task.Run(() =>
        {
            while (_p != null && !_p.HasExited) ;
            EventController.Self.EmitSshExit(_p == null ? 0 : _p.ExitCode);
        });
    }

    public static void Stop()
    {
        if (_p is not null)
        {
            _p.Kill();
            _p.Dispose();
        }
    }
}
