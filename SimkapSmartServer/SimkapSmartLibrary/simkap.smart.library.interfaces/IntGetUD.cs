
namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntGetUD<T>
    {
        bool save(T et, string dt);

        bool delete(T et, string dt);
    }
}
