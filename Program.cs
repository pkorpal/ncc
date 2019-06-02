﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NCC
{
    public class SynchronousSocketListener
    { 
        public static string data = null;
        public static void StartListening()
        {
            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = IPAddress.Loopback;
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 10000);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.ReceiveBufferSize = 100;
            listener.SendBufferSize = 100;

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // new Input();
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("NCC: Waiting for a connection...");
                    Console.ResetColor();
                    new Handler(listener.Accept());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }
    }
}