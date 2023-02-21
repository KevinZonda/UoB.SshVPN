using System.Diagnostics;

namespace KevinZonda.UoB.SshVPN.Controller;

internal class Socks2Http
{
    public static Process Start()
    {
        var p = new Process
        {
            StartInfo =
            {
                FileName = "cmd.exe",
                Arguments = $"/c START /MIN {ConstText.PRIVOXY_BIN} {ConstText.PRIVOXY_CONF}",
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };
        p.Start();
        
        return p;
    }
}
