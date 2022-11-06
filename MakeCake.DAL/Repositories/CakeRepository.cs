using MakeCake.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCake.DAL.Repositories
{
    public class CakeRepository : BaseRepository, ICakeRepository
    {
        

        public CakeRepository(DataContext context)
        {
            _context = context;
        }

        public int TestCake(TierDto tier)
        {
            //var bis = GetBiscuitById(10);
            return 0;
        }

        

        public List<CreamDto> GetAllCreamByBiscuitId(int biscuitId)
        {
            return new List<CreamDto>();
        }

        public CreamDto GetCreamById()
        {
            return new CreamDto();
        }

        
    }
}
