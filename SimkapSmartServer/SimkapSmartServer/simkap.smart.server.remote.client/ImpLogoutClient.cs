using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using SimkapSmartLibrary.simkap.smart.library.remote.client;


namespace SimkapSmartServer.simkap.smart.server.remote.client
{
    public class ImpLogoutClient : MarshalByRefObject, IntRemoteSaveWriteTransactionClient, IntRemoteWriteTransactionClient
    {
        private TcpClient client;
        private NetworkStream stream;
        private StreamWriter fileTransactionClient;
        private string pathTransactionClient = "C:\\logSIMKAP\\log_client.txt";

        public void writeSaveLogTransactionClient(string text)
        {
            fileTransactionClient = new StreamWriter(pathTransactionClient, true);
            fileTransactionClient.WriteLine(text);
            fileTransactionClient.Close();
        }

        public void writeLogTransactionClient(string dt, string ip, int port)
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse("127.0.0.1"), 1111);

                stream = client.GetStream();

                byte[] message = Encoding.ASCII.GetBytes(dt);
                stream.Write(message, 0, message.Length);

            }
            catch { }
        }
    }
}
