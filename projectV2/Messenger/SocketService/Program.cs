using MessageSocketData.SocketObj;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;

namespace SocketService
{
    class Program
    {
        const string ip = "127.0.0.1";
        const int port = 40000;

        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse(ip), port);
            tcpListener.Start();

            Console.WriteLine($"<<SOCKET>> Server(ip:{ip}, port: {port}) started...");


            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                NetworkStream networkStream = tcpClient.GetStream();
                
               
               
                Console.WriteLine("Connect");
                try
                {


                    ///Get data from client


                    BinaryFormatter bf1 = new BinaryFormatter();
                    DataToSend dataRequest = bf1.Deserialize(tcpClient.GetStream()) as DataToSend;
                    
                    Console.WriteLine(dataRequest.FirstObject.ToString() +" "+ dataRequest.Action.ToString());


                    DataToSend answerData = new DataToSend();
                    ///Do something with data
                    DataProcessing dataProcessing = new DataProcessing();
                   
                    
                  
                    answerData = dataProcessing.Processing(dataRequest);

                    ///Send data to client
                    BinaryFormatter bf2 = new BinaryFormatter();
                    bf2.Serialize(networkStream, answerData);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    tcpClient.Close();
                   
                }
            }
            Console.ReadKey();
        }
    }
}
