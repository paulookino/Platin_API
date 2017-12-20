using System.Collections.Generic;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class CpmCabService : PostgreSQLServiceBase<CpmCab>, ICpmCabService
    {
        private readonly ICpmCabRepository _cpmCabRepository;

        public CpmCabService(ICpmCabRepository cpmCabRepository)
            :base(cpmCabRepository)
        {
            _cpmCabRepository = cpmCabRepository;
        }

        public List<CpmCabLotCxaFunCabCpmFec> ConsultaCpmCabLotCxaFunCabCpmFec()
        {
            return _cpmCabRepository.ConsultaCpmCabLotCxaFunCabCpmFec();
        }

        public List<CpmCabPrdCabCpmIte> ConsultaCpmCabPrdCabCpmIte()
        {
            return _cpmCabRepository.ConsultaCpmCabPrdCabCpmIte();
        }
    }
}
