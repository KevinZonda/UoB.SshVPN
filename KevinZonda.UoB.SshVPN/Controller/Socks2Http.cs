﻿using System.Diagnostics;
using System.Net;

namespace KevinZonda.UoB.SshVPN.Controller;

internal class Socks2Http
{
    private static Process? _p = null;

    public static void Start()
    {
        if (_p is not null)
        {
            _p.Kill();
            _p.Dispose();
        }
        _p = new()
        {
            StartInfo = new()
            {
                FileName = "cmd.exe",
                Arguments = $"/c START /MIN {ConstText.PRIVOXY_BIN} {ConstText.PRIVOXY_CONF}",
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };
        _p.Start();
    }
}
