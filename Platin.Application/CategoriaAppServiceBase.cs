using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class CategoriaAppServiceBase : AppServiceBase<Categoria>, ICategoriaAppServiceBase
    {
        private readonly ICategoriaService _categoriaService;
        
        public CategoriaAppServiceBase(ICategoriaService categoriaService)
            :base(categoriaService)
        {
            _categoriaService = categoriaService;
        }
    }
}
