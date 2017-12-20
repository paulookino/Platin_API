using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class PrdBarService : PostgreSQLServiceBase<PrdBar>, IPrdBarService
    {
        private readonly IPrdBarRepository _prdBarRepository;

        public PrdBarService(IPrdBarRepository prdBarRepository)
            :base(prdBarRepository)
        {
            _prdBarRepository = prdBarRepository;
        }
    }
}
