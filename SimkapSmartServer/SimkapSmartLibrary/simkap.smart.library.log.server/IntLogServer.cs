
namespace SimkapSmartLibrary.simkap.smart.library.log.server
{
    public interface IntLogServer
    {
        void writeLogTrasaction(string method);

        void writeLogRunningServer(string data);
    }
}
