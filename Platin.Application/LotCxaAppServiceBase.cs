using System.Collections.Generic;
using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class LotCxaAppServiceBase : PostgreSQLAppServiceBase<LotCxa>, ILotCxaAppServiceBase
    {
        private readonly ILotCxaService _lotCxaService;

        public LotCxaAppServiceBase(ILotCxaService lotCxaService)
            :base(lotCxaService)
        {
            _lotCxaService = lotCxaService;
        }

        public List<LotCxaVFunUadCab> ConsultaLotCxaVFunUadCab()
        {
            return _lotCxaService.ConsultaLotCxaVFunUadCab();
        }
    }
}
