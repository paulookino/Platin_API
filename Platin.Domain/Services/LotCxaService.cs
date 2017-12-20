using System.Collections.Generic;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class LotCxaService : PostgreSQLServiceBase<LotCxa>, ILotCxaService
    {
        private readonly ILotCxaRepository _lotCxaRepository;
        
        public LotCxaService(ILotCxaRepository lotCxaRepository)
            :base(lotCxaRepository)
        {
            _lotCxaRepository = lotCxaRepository;
        }

        public List<LotCxaVFunUadCab> ConsultaLotCxaVFunUadCab()
        {
            return _lotCxaRepository.ConsultaLotCxaVFunUadCab();
        }
    }
}
