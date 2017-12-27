using Platin.Application;
using Platin.Application.Interfaces;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;
using Platin.Domain.Services;
using Platin.Infra.Data.Repositories;
using SimpleInjector;
namespace Platin.Infra.IOC.ContainerIOC
{

    public class SimpleInjectorContainer
    {
        public static Container _container;

        static SimpleInjectorContainer()
        {
            RegisterServices();
        }

        public static Container RegisterServices()
        {
            _container = new Container();


            //SQL Server
            _container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            _container.Register<IProductAppServiceBase, ProductAppServiceBase>();
            _container.Register<IFuncionarioAppServiceBase, FuncionarioAppServiceBase>();
            _container.Register<ICaixaAppServiceBase, CaixaAppServiceBase>();
            _container.Register<ICategoriaAppServiceBase, CategoriaAppServiceBase>();
            _container.Register<IProdutoAppServiceBase, ProdutoAppServiceBase>();
            _container.Register<IVendaAppServiceBase, VendaAppServiceBase>();
            _container.Register<IItemVendaAppServiceBase, ItemVendaAppServiceBase>();
            _container.Register<ICupomAppServiceBase, CupomAppServiceBase>();
            _container.Register<IInventarioAppServiceBase, InventarioAppServiceBase>();

            _container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            _container.Register<IProductService, ProductService>();
            _container.Register<IFuncionarioService, FuncionarioService>();
            _container.Register<ICaixaService, CaixaService>();
            _container.Register<ICategoriaService, CategoriaService>();
            _container.Register<IProdutoService, ProdutoService>();
            _container.Register<IVendaService, VendaService>();
            _container.Register<ICupomService, CupomService>();
            _container.Register<IInventarioService, InventarioService>();

            _container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            _container.Register<IProductRepository, ProductRepository>();
            _container.Register<IFuncionarioRepository, FuncionarioRepository>();
            _container.Register<ICaixaRepository, CaixaRepository>();
            _container.Register<ICategoriaRepository, CategoriaRepository>();
            _container.Register<IProdutoRepository, ProdutoRepository>();
            _container.Register<IVendaRepository, VendaRepository>();
            _container.Register<IItemVendaRepository, ItemVendaRepository>();
            _container.Register<ICupomRepository, CupomRepository>();
            _container.Register<IInventarioRepository, InventarioRepository>();

            //PostgreSQL
            _container.Register(typeof(IPostgreSQLAppServiceBase<>), typeof(PostgreSQLAppServiceBase<>));
            _container.Register<IPrdCabAppServiceBase, PrdCabAppServiceBase>();
            _container.Register<IVFunUadCabAppServiceBase, VFunUadCabAppServiceBase>();
            _container.Register<IUsuSisAppServiceBase, UsuSisAppServiceBase>();
            _container.Register<ILotCxaAppServiceBase, LotCxaAppServiceBase>();
            _container.Register<IClsCabAppServiceBase, ClsCabAppServiceBase>();
            _container.Register<IPrdBarAppServiceBase, PrdBarAppServiceBase>();
            _container.Register<ICpmIteAppServiceBase, CpmIteAppServiceBase>();
            _container.Register<ICpmCabAppServiceBase, CpmCabAppServiceBase>();
            _container.Register<IFunCabAppServiceBase, FunCabAppServiceBase>();
            _container.Register<ICpmFecAppServiceBase, CpmFecAppServiceBase>();


            _container.Register(typeof(IPostgreSQLServiceBase<>), typeof(PostgreSQLServiceBase<>));
            _container.Register<IPrdCabService, PrdCabService>();
            _container.Register<IVFunUadCabService, VFunUadCabService>();
            _container.Register<IUsuSisService, UsuSisService>();
            _container.Register<ILotCxaService, LotCxaService>();
            _container.Register<IClsCabService, ClsCabService>();
            _container.Register<IPrdBarService, PrdBarService>();
            _container.Register<ICpmIteService, CpmIteService>();
            _container.Register<ICpmCabService, CpmCabService>();
            _container.Register<IFunCabService, FunCabService>();
            _container.Register<ICpmFecService, CpmFecService>();

            _container.Register(typeof(IPostgreSQLRepositoryBase<>), typeof(PostgreSQLRepositoryBase<>));
            _container.Register<IPrdCabRepository, PrdCabRepository>();
            _container.Register<IVFunUadCabRepository, VFunUadCabRepository>();
            _container.Register<IUsuSisRepository, UsuSisRepository>();
            _container.Register<ILotCxaRepository, LotCxaRepository>();
            _container.Register<IClsCabRepository, ClsCabRepository>();
            _container.Register<IPrdBarRepository, PrdBarRepository>();
            _container.Register<ICpmIteRepository, CpmIteRepository>();
            _container.Register<ICpmCabRepository, CpmCabRepository>();
            _container.Register<IFunCabRepository, FunCabRepository>();
            _container.Register<ICpmFecRepository, CpmFecRepository>();

            return _container;
        }
    }

}