﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoFinalSSL
{
    public class Program
    {
        private const int PORT = 7777;
        static void Main(string[] args)
        {
            Server server = new Server(PORT);
            server.StartServer();

            Console.ReadLine();
        }
    }
}
