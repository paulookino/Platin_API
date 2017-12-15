using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class ProductAppServiceBase : AppServiceBase<Product>, IProductAppServiceBase
    {

        private readonly IProductService _productService;

        public ProductAppServiceBase(IProductService productService)
            :base(productService)
        {
            _productService = productService;
        }
    }
}
