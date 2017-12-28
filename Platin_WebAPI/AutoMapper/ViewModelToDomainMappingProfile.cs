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
            Mapper.CreateMap<Caixa, CaixaViewModel>();
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Cupom, CupomViewModel>();
            Mapper.CreateMap<Funcionario, FuncionarioViewModel>();
            Mapper.CreateMap<Inventario, InventarioViewModel>();
            Mapper.CreateMap<ItemVenda, ItemVendaViewModel>();
            Mapper.CreateMap<PrdCab, PrdCabViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Venda, VendaViewModel>();

        }
    }
}