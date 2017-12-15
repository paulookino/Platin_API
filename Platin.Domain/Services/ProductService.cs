using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            :base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
