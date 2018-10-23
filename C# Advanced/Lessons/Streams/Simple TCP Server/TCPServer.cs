using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Simple_TCP_Server
{
    class TCPServer
    {
        static void Main(string[] args)
        {
            int PortNumber = 9999;
            var tcpListener = new TcpListener(IPAddress.Any, PortNumber);
            tcpListener.Start();
            Console.WriteLine($"Listening on port {PortNumber}...");
            while (true)
            {
                using (var stream = tcpListener.AcceptTcpClient().GetStream())
                {
                    byte[] buffer = new byte[4096];
                    int readBytes = stream.Read(buffer, 0, buffer.Length);
                    while (readBytes != 0)
                    {
                        Console.Write(Encoding.UTF8.GetString(buffer, 0, readBytes));
                        readBytes = stream.Read(buffer, 0, buffer.Length);
                    }
                    Console.WriteLine();

                    string html = string.Format("{0}{1}{2}{3} - {4}{2}{1}{0}","<html>", "<body>", "<h1>", "Welcome to my awesome site!", DateTime.Now);
                    byte[] htmlBytes = Encoding.UTF8.GetBytes(html);
                    stream.Write(htmlBytes, 0, htmlBytes.Length);
                }
            }
        }
    }
}
