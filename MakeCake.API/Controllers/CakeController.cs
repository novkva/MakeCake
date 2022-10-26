using AutoMapper;
using MakeCake.API.Controllers.Models.InputModels;
using MakeCake.Business.Services;
using MakeCake.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeCake.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CakeController : Controller
    {

        private readonly IMapper _mapper;
        private readonly ICakeService _cakeService;

        public CakeController(IMapper mapper, ICakeService cakeService)
        {
            _mapper = mapper;
            _cakeService = cakeService;
        }

        [HttpPost]
        public int AddTier([FromBody] TierInputModel tier)
        {
            var dto = _mapper.Map<TierDto>(tier);
            _cakeService.AddCake(dto);
            return 0;
        }

        [HttpPut]
        public int UpdateTier([FromBody] TierInputModel tier)
        {
            return 0;
        }

        [HttpGet]
        public int GetTier(int tierId)
        {
            return 0;
        }

        [HttpDelete]
        public int DeleteTier(int tierId)
        {
            return 0;
        }
    }
}
