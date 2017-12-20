using System.Collections.Generic;
using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class CpmIteAppServiceBase : PostgreSQLAppServiceBase<CpmIte>, ICpmIteAppServiceBase
    {
        private readonly ICpmIteService _cpmIteService;

        public CpmIteAppServiceBase(ICpmIteService cpmIteService)
            :base(cpmIteService)
        {
            _cpmIteService = cpmIteService;
        }

        public List<CpmIteCpmCab> ConsultaCpmIteCpmCab()
        {
            return _cpmIteService.ConsultaCpmIteCpmCab();
        }
    }
}
