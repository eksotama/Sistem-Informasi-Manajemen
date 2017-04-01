
namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntGetAll <T>
    {
        bool save(T et, string dt);

        bool edit(T et, string dt);

        bool delete(T et, string dt);
    }
}
