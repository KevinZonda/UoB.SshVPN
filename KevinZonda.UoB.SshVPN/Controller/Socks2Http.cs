using System.Diagnostics;

namespace KevinZonda.UoB.SshVPN.Controller
{
    internal class Socks2Http
    {
        const string PrivoxyExe = "bin\\privoxy.exe";
        const string PrivoxyConf = "bin\\conf";

        public static Process Start()
        {
            var p = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c START /MIN {PrivoxyExe} {PrivoxyConf}",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            p.Start();
            return p;
        }
    }
}
