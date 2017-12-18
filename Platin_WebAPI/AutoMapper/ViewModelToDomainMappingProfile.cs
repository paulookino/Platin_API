using AutoMapper;
using Platin.Domain.Entities;
using Platin_WebAPI.ViewModels;

namespace Platin_WebAPI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Product, ProductViewModel>();

        }
    }
}