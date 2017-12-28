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
            Mapper.CreateMap<CaixaViewModel, Caixa>();
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<CupomViewModel, Cupom>();
            Mapper.CreateMap<FuncionarioViewModel, Funcionario>();
            Mapper.CreateMap<InventarioViewModel, Inventario>();
            Mapper.CreateMap<ItemVendaViewModel, ItemVenda>();
            Mapper.CreateMap<PrdCabViewModel, PrdCab>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<VendaViewModel, Venda>();

        }
    }
}