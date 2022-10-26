using MakeCake.DAL.Models;

namespace MakeCake.Business.Services
{
    public interface ICakeService
    {
        int AddCake(TierDto tier);
    }
}