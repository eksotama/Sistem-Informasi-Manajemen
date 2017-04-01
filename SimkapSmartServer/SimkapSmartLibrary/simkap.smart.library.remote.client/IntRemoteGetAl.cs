namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteGetAl <T,C>
    {
        bool save(T et, C rtc);
        bool edit(T et, C rtc);
        bool delete(T et, C rtc);
    }
}
