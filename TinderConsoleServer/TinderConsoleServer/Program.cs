using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinderConsoleServer
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
