using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1"; //создаём IP, работающий на одном ПК
            const int port = 8080; //создаём порт
            var tcpEndPint = new IPEndPoint(IPAddress.Parse(ip), port);


            //Создаём сокет и задаём параметры для TCP протокола
            var tcpSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);

            //Выполняем связывание (Переводим сокет в режим ожмдания) укзаываем конктретный порт
            tcpSocket.Bind(tcpEndPint);

            //Сокет на прослушивание и создаём очередь клиентов
            tcpSocket.Listen(5);

            //Создаём процесс прослушивания
            while (true)
            {

            }







        }
    }
}
