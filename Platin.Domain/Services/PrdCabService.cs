using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class PrdCabService : PostgreSQLServiceBase<PrdCab>, IPrdCabService
    {

        private readonly IPrdCabRepository _prdCabRepository;

        public PrdCabService(IPrdCabRepository prdCabRepository)
            :base(prdCabRepository)
        {
            _prdCabRepository = prdCabRepository;
        }
    }

}
