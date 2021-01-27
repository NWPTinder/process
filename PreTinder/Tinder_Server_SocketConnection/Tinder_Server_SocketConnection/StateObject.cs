using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TinderConsoleServer
{
 
        public class StateObject
        {
            public Socket ClientSocket { get; set; }
            public const int BufferSize = 1024;
            public byte[] Buffer { get; } = new byte[BufferSize];
        }
   
}
