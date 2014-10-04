using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps;
using System.Drawing.Printing;
using System.IO;
using System.Drawing;
using System.Net.Sockets;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {

            TcpClient client = new TcpClient(AddressFamily.InterNetwork);
            client.Connect(IPAddress.Parse("127.0.0.1"), 6101);
            if (client.Connected)
            {
                client.Client.SendFile(@"D:\teste.txt");
                client.Close();
            }

        }
    }
}
