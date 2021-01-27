using System;
using TinderConsoleServer;

namespace Tinder_Server_SocketConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Server FirstSoket = new Server(59072);
            FirstSoket.Run();

        }
    }
}
