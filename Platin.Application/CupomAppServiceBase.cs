using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class CupomAppServiceBase : AppServiceBase<Cupom>, ICupomAppServiceBase
    {
        private readonly ICupomService _cupomService;

        public CupomAppServiceBase(ICupomService cupomService)
            :base(cupomService)
        {
            _cupomService = cupomService;
        }
    }
}
