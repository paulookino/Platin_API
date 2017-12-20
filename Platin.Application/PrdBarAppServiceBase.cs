using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class PrdBarAppServiceBase : PostgreSQLAppServiceBase<PrdBar>, IPrdBarAppServiceBase
    {
        private readonly IPrdBarService _prdBarService;

        public PrdBarAppServiceBase(IPrdBarService prdBarService)
            :base(prdBarService)
        {
            _prdBarService = prdBarService;
        }

    }
}
