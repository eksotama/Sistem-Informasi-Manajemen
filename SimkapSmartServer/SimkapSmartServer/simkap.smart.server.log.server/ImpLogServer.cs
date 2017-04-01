  using System.IO;
using SimkapSmartLibrary.simkap.smart.library.log.server;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartServer.simkap.smart.server.log.server
{
    public class ImpLogServer : IntLogServer, IntRemoteSaveWriteTransactionClient
    {
        private StreamWriter fileRunning;
        private StreamWriter fileTransaction;
        private StreamWriter fileTransactionClient;
        private string pathRunning = "C:\\logSIMKAP\\log_panel_kontrol.txt";
        private string pathTransaction = "C:\\logSIMKAP\\log_server.txt";
        private string pathTransactionClient = "C:\\logSIMKAP\\log_client.txt";

        public void writeLogTrasaction(string method)
        {
            fileTransaction = new StreamWriter(pathTransaction, true);
            fileTransaction.WriteLine(method);
            fileTransaction.Close();
        }

        public void writeLogRunningServer(string data)
        {
            fileRunning = new StreamWriter(pathRunning, true);
            fileRunning.WriteLine(data);
            fileRunning.Close();
        }

        public void writeSaveLogTransactionClient(string text)
        {
            fileTransactionClient = new StreamWriter(pathTransactionClient, true);
            fileTransactionClient.WriteLine(text);
            fileTransactionClient.Close();
        }
    }
}
