using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class VendaAppServiceBase : AppServiceBase<Venda>, IVendaAppServiceBase
    {
        private readonly IVendaService _vendaService;
        
        public VendaAppServiceBase(IVendaService vendaService)
            :base(vendaService)
        {
            _vendaService = vendaService;
        }
    }
}
