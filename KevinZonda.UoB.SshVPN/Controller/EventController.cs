using System;

namespace KevinZonda.UoB.SshVPN.Controller;

internal class EventController
{
    public delegate void SshExitEventHandler(int exitCode);

    public event SshExitEventHandler OnSshExit = (x) => { };

    public static EventController Self = new();

    public void EmitSshExit(int exitCode)
    {
        OnSshExit(exitCode);
    }
}
