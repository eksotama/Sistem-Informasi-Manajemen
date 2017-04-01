using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntAdministrator
    {
        bool edit(EntAdministrator et, string dt);
        DataTable selectAdministrator();
    }
}
