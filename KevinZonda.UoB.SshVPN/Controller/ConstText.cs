using System;
using System.Linq;

namespace KevinZonda.UoB.SshVPN.Controller;

internal class ConstText
{
    public const string PLINK = "uoblink";
    public static readonly string PLINK_BIN = Path.Combine("bin", PLINK + ".exe");
    public const string PRIVOXY = "privoxy";
    public static readonly string PRIVOXY_BIN = Path.Combine("bin", PRIVOXY + ".exe");
    public static readonly string PRIVOXY_CONF = Path.Combine("bin", "conf");

    public const int HTTP_LISTEN = 1903;
    public const int SOCKS_LISTEN = 1902;
}
