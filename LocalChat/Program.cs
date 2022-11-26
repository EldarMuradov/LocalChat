using System;
using System.Net;
using System.Threading;
using LocalChat.Chat;

namespace LocalChat
{
    sealed class Program
    {
        public static int LocalPort;
        public static int RemotePort;
        public static IPAddress Ip;
        public static string Name = "";

        private static void Main(string[] args)
        {
            Ip = IPAddress.Parse("127.0.0.1");

            Console.Write("Enter your name: ");
            Name = Console.ReadLine();

            Console.Write("Enter port to recieve messages: ");
            LocalPort = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter port to send messages: ");
            RemotePort = Convert.ToInt32(Console.ReadLine());

            Thread thread = new(Reciever.ReceiveMessage);
            thread.Start();

            Sender.SendMessage();

            Console.ReadLine();
        }
    }
}
