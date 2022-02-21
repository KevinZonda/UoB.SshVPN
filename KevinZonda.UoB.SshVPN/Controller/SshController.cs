using System.Diagnostics;

namespace KevinZonda.UoB.SshVPN.Controller
{
    internal class SshController
    {
        private const string ADDRESS = "tw.cs.bham.ac.uk";
        private const string PLINK = "bin\\uoblink.exe";

        public static Process Start(string username, string password)
        {

            var p = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c echo \"n\" | {PLINK} {username}@{ADDRESS} -pw \"{password}\" -D 127.0.0.1:1902 -N",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            p.Start();
            return p;
        }
    }
}
