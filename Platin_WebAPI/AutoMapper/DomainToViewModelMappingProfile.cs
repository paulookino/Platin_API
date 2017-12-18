using AutoMapper;
using Platin.Domain.Entities;
using Platin_WebAPI.ViewModels;

namespace Platin_WebAPI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ProductViewModel, Product>();

        }
    }
}