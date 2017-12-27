using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class CaixaAppServiceBase : AppServiceBase<Caixa>, ICaixaAppServiceBase
    {

        private readonly ICaixaService _caixaService;

        public CaixaAppServiceBase(ICaixaService caixaService)
            :base(caixaService)
        {
            _caixaService = caixaService;
        }
    }
}
