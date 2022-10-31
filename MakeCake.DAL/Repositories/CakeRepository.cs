using MakeCake.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCake.DAL.Repositories
{
    public class CakeRepository : ICakeRepository
    {
        private DataContext _context;

        public CakeRepository(DataContext context)
        {
            _context = context;
        }

        public int TestCake(TierDto tier)
        {
            var bis = GetBiscuit(10);
            return 0;
        }

        public BiscuitDto GetBiscuit(int id)
        {
            return _context.Biscuits
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }
    }
}
