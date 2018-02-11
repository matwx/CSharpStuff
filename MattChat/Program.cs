using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections;

namespace MattChat
{
    class Program
    {
        static void Main(string[] args)
        {
            Server.Start();
        }
    }
}
