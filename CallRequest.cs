using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;

namespace NCC
{
    class CallRequest
    {
        String message;
        String source;
        String destination;
        String path = "";
        int throughput;
        private bool running = false;

        Policy policy = new Policy();
        Directory directory = new Directory();

        public CallRequest(string msg)
        {
            this.message = msg;
            string[] smsg = msg.Split(' ');
            source = smsg[2];
            destination = smsg[4];
            throughput = Int16.Parse(smsg[6]);
            path += source + " ";
            start();
        }

        private void start()
        {
            Thread callConnection = new Thread(new ThreadStart(run));
            callConnection.Start();
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
            // socket.Connect(IPAddress.Loopback);
            // socket.Send(msg);
            // socket.Shutdown(SocketShutdown.Both);  
            // socket.Close();  
        }

        public string getNextHop() {
            return "";
        }

        public bool checkIfPathComplete() {
            return false;
        }

        private void run()
        {
            while (running)
            {

            }
        }
    }
}
