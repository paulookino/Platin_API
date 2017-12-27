using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class InventarioAppServiceBase : AppServiceBase<Inventario>, IInventarioAppServiceBase
    {
        private readonly IInventarioService _inventarioService;


        public InventarioAppServiceBase(IInventarioService inventarioService)
            :base(inventarioService)
        {
            _inventarioService = inventarioService;
        }
    }
}
