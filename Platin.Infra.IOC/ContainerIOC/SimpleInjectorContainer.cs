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

            _container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            _container.Register<IProductService, ProductService>();
           
            _container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            _container.Register<IProductRepository, ProductRepository>();

            //PostgreSQL
            _container.Register(typeof(IPostgreSQLAppServiceBase<>), typeof(PostgreSQLAppServiceBase<>));
            _container.Register<IPrdCabAppServiceBase, PrdCabAppServiceBase>();

            _container.Register(typeof(IPostgreSQLServiceBase<>), typeof(PostgreSQLServiceBase<>));
            _container.Register<IPrdCabService, PrdCabService>();

            _container.Register(typeof(IPostgreSQLRepositoryBase<>), typeof(PostgreSQLRepositoryBase<>));
            _container.Register<IPrdCabRepository, PrdCabRepository>();

            return _container;
        }
    }

}