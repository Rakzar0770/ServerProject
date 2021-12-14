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
            #region TCP
            //const string ip = "127.0.0.1"; //создаём IP, работающий на одном ПК
            //const int port = 8080; //создаём порт
            //var tcpEndPint = new IPEndPoint(IPAddress.Parse(ip), port);


            ////Создаём сокет и задаём параметры для TCP протокола
            //var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ////Выполняем связывание (Переводим сокет в режим ожмдания) укзаываем конктретный порт
            //tcpSocket.Bind(tcpEndPint);

            ////Сокет на прослушивание и создаём очередь клиентов
            //tcpSocket.Listen(5);

            ////Создаём процесс прослушивания
            //while (true)
            //{
            //    //создаётся новый сокет для подключения конкретного клиента
            //    var listener = tcpSocket.Accept(); // обработали данные, отправили ответ и уничтожили

            //    //буффер для сообщения байтовый массив
            //    var buffer = new byte[256];

            //    //количество реально получеснных байт
            //    var size = 0;
            //    var data = new StringBuilder();
            //    do
            //    {
            //        size = listener.Receive(buffer);

            //        //добавляем данные (перекодируем из listener и добавляем в строку)
            //        data.Append(Encoding.UTF8.GetString(buffer, 0, size));


            //    } while (listener.Available > 0);

            //    Console.WriteLine(data);

            //    listener.Send(Encoding.UTF8.GetBytes("Успех"));

            //    //закрываем подключение
            //    listener.Shutdown(SocketShutdown.Both);
            //    listener.Close();





            //}
            #endregion

            const string ip = "127.0.0.1"; //создаём IP, работающий на одном ПК
            const int port = 8081; //создаём порт

            var udpEndPint = new IPEndPoint(IPAddress.Parse(ip), port);

            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            udpSocket.Bind(udpEndPint);






        }
    }
}
