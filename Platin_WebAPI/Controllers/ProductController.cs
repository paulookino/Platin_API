using Platin.Application.Interfaces;

namespace Platin_WebAPI.Controllers
{
    public class ProductController
    {
        private readonly IProductAppServiceBase _productAppServiceBase;

        public ProductController(IProductAppServiceBase 
            productAppServiceBase)
        {
            _productAppServiceBase = productAppServiceBase;
        }
    }
}