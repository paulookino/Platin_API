using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class CpmFecService : PostgreSQLServiceBase<CpmFec>, ICpmFecService
    {
        private readonly ICpmFecRepository _cpmFecRepository;

        public CpmFecService(ICpmFecRepository cpmFecRepository)
            :base(cpmFecRepository)
        {
            _cpmFecRepository = cpmFecRepository;
        }
    }
}
