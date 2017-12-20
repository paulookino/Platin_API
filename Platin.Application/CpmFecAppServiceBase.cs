using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class CpmFecAppServiceBase : PostgreSQLAppServiceBase<CpmFec>, ICpmFecAppServiceBase
    {
        private readonly ICpmFecService _cpmFecService;

        public CpmFecAppServiceBase(ICpmFecService cpmFecService)
            :base(cpmFecService)
        {
            _cpmFecService = cpmFecService;
        }

    }
}
