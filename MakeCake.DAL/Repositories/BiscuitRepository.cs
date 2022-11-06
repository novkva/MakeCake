using MakeCake.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCake.DAL.Repositories
{
    public class BiscuitRepository: BaseRepository
    {
        public BiscuitRepository(DataContext context)
        {
            _context = context;
        }

        public BiscuitDto GetBiscuitById(int id)
        {
            return _context.Biscuits
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }

        public void AddBiscuit(BiscuitDto biscuit)
        {

        }

        public void AddCreamsToBiscuit(int biscuitId, List<int> creamIds)
        {

        }

        public void AddFillingsToBiscuit(int biscuitId, List<int> fillingIds)
        {

        }

        public void DeleteBiscuit()
        {

        }
    }
}
