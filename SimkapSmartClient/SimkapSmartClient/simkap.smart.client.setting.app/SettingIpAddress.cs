
namespace SimkapSmartClient.simkap.smart.client.setting.app
{
    public class SettingIpAddress
    {
        private string server;
        private string port1;
        private int port2;
        private string url;
        
        public int getPort2()
        {
            port2 = 1111;

            return port2;
        }

        public string getServer()
        {
            server = Properties.Settings.Default.ipServer;

            return server;
        }

        public string getUrl(string uri)
        {
            port1 = "1001";

            url = "tcp://" + getServer() + ":" + port1 + "/" + uri;

            return url;
        }

    }
}
