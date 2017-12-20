using System.Collections.Generic;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class CpmIteService : PostgreSQLServiceBase<CpmIte>, ICpmIteService
    {

        private readonly ICpmIteRepository _cpmIteRepository;

        public CpmIteService(ICpmIteRepository cpmIteRepository)
            :base(cpmIteRepository)
        {
            _cpmIteRepository = cpmIteRepository;                
        }

        public List<CpmIteCpmCab> ConsultaCpmIteCpmCab()
        {
            return _cpmIteRepository.ConsultaCpmIteCpmCab();
        }
    }
}
