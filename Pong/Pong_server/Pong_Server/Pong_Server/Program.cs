using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Pong_Server
{
    class Program
    {


        public static List<TcpClient> ClientL;
        public static List<Thread> ThreadL;
        public static int numClien = 0;




        static void Main(string[] args)
        {
            ClientL = new List<TcpClient>();
            ThreadL = new List<Thread>();
            bool start = true;
            try
            {

                TcpListener myListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8001);
                myListener.Start();

                Console.WriteLine("The server is running at port 8001...");
                Console.WriteLine("The local End point is :" + myListener.LocalEndpoint);
                Console.WriteLine("Waiting for a connection.....");

                while (start)
                {
                    try
                    {
                        TcpClient client = myListener.AcceptTcpClient();//accepte une connexion de la part d'un client

                        Console.WriteLine("Client is connected : " + client.Client.RemoteEndPoint);

                        ClientL.Add(client);// ajout du client a la liste de client

                        Console.WriteLine("Number of connected clients :  " + ClientL.Count);



                        Thread Clientcom = new Thread(Com);

                        ThreadL.Add(Clientcom);//ajout du thread a la liste de threads

                        Clientcom.Start();//debut du thread


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error..... " + e.StackTrace);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
                Console.ReadLine();


            }
        }




        private static void Com()
        {
            int Num = ClientL.Count - 1;

            TcpClient client = ClientL.ElementAt(Num); 
            NetworkStream stream = client.GetStream();

            bool start = true;

            while (start)    // Bocle d'ecoute
            {
                if (stream.DataAvailable)
                {
                    byte[] rcvBytes = new byte[1024];
                    stream.Read(rcvBytes, 0, rcvBytes.Length);
                    ASCIIEncoding msg = new ASCIIEncoding();

                    string rcv = msg.GetString(rcvBytes);
                                  

                    Console.WriteLine(rcv);
                    
                }

                

            }
            //ClientL.Remove(ClientL.ElementAt(Num));
            //Console.WriteLine("Number of connected Clients :  " + ClientL.Count);




        }
    }
}


    

