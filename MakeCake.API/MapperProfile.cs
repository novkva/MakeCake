using AutoMapper;
using MakeCake.API.Controllers.Models.InputModels;
using MakeCake.DAL.Models;

namespace MakeCake.API
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {
            CreateMappingToDto();
            CreateMappingFromDto();
        }

        private void CreateMappingToDto()
        {
            CreateMap<TierInputModel, TestDto>();

            CreateMap<TierInputModel, TierDto>();
        }

        private void CreateMappingFromDto()
        {
            //CreateMap<, >();
            
        }
    }
}
