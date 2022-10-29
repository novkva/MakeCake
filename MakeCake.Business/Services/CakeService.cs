using MakeCake.DAL.Models;
using MakeCake.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCake.Business.Services
{
    public class CakeService : ICakeService
    {
        private readonly ICakeRepository _cakeRepository;

        public CakeService(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }


        public int AddCake(TierDto tier)
        {
            
            _cakeRepository.AddCake(tier);
            return 0;
        }
    }
}
