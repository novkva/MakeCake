using MakeCake.DAL.Models;

namespace MakeCake.DAL.Repositories
{
    public interface ICakeRepository
    {
        int TestCake(TierDto tier);
    }
}