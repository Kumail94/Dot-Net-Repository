using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgrammingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcp = new TcpListener(8888);
            tcp.Start();
            Console.WriteLine("Server has start and waiting for clients:");
            Socket socketForClients = tcp.AcceptSocket();
            if (socketForClients.Connected)
            {
                /* Send Message to Client */
                NetworkStream ns = new NetworkStream(socketForClients);
                StreamWriter swWriter = new StreamWriter(ns);
                Console.WriteLine("Server >> : Wellcome Client:");
                swWriter.WriteLine("Wellcome to Client..");
                swWriter.Flush();

                /* Get Message From Client */
                StreamReader sr = new StreamReader(ns);
                Console.WriteLine("Client:>> " + sr.ReadLine());
                swWriter.Close();
                ns.Close();

            }
            socketForClients.Close();
        }
    }
}
