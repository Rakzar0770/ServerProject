using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1"; //создаём IP, работающий на одном ПК
            const int port = 8080; //создаём порт

            var tcpEndPint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Введите сообщение!");
            var message = Console.ReadLine();

            //кодируем сообщение
            var data = Encoding.UTF8.GetBytes(message);
            // подключаемся
            tcpSocket.Connect(tcpEndPint);

            //отправляем сообщение
            tcpSocket.Send(data);

            //буффер для сообщения байтовый массив
            var buffer = new byte[256];

            //количество реально получеснных байт
            var size = 0;
            var answer = new StringBuilder();
            do
            {
                size = tcpSocket.Receive(buffer);

                //добавляем данные (перекодируем из listener и добавляем в строку)
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));


            } while (tcpSocket.Available > 0);

            Console.WriteLine(answer.ToString());

            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();

            Console.ReadLine();




        }
    }
}
