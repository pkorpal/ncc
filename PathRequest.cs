using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;

namespace NCC
{
    class PathRequest
    {
        String message;
        private bool running = false;

        public PathRequest()
        {
            start();
        }

        private void start()
        {
            Thread pathRequest = new Thread(new ThreadStart(run));
            pathRequest.Start();
            running = true;
        }

        public void send(string smsg)
        {
            // Byte[] msg = Encoding.UTF8.GetBytes(smsg);
            // byte[] bytes = new byte[1024]; 
            // Socket socket = new Socket(IPAddress.Loopback.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            // socket.ReceiveBufferSize = 256;
            // socket.SendBufferSize = 256;
            // socket.DontFragment = true;
            // socket.NoDelay = true;
            // socket.SendTimeout = 500;
            // socket.LingerState = new LingerOption(true, 2);
            // socket.Connect(IPAddress.Loopback, ds.port);
            // socket.Send(msg);
            // socket.Shutdown(SocketShutdown.Both);  
            // socket.Close();  
        }

        private void run()
        {
            while (running)
            {
            }
        }
    }
}
