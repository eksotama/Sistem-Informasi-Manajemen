using System.Net.Sockets;
using SimkapSmartLibrary.simkap.smart.library.log.client;

namespace SimkapSmartServer.simkap.smart.server.log.client
{
    public class ImpLogClient : IntLogClient
    {
        private TcpClient mcClient;
        private NetworkStream stream;

        public byte[] readTransactionClient(object client)
        {
            mcClient = (TcpClient)client;
            stream = mcClient.GetStream();

            byte[] message = new byte[1024];
            stream.Read(message, 0, message.Length);

            return message;
        }
    }
}
