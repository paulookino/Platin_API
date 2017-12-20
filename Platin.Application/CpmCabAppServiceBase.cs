using System.Collections.Generic;
using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class CpmCabAppServiceBase : PostgreSQLAppServiceBase<CpmCab>, ICpmCabAppServiceBase
    {
        private readonly ICpmCabService _cpmCabService;

        public CpmCabAppServiceBase(ICpmCabService cpmCabService)
            :base(cpmCabService)
        {
            _cpmCabService = cpmCabService;
        }

        public List<CpmCabLotCxaFunCabCpmFec> ConsultaCpmCabLotCxaFunCabCpmFec()
        {
            return _cpmCabService.ConsultaCpmCabLotCxaFunCabCpmFec();
        }

        public List<CpmCabPrdCabCpmIte> ConsultaCpmCabPrdCabCpmIte()
        {
            return _cpmCabService.ConsultaCpmCabPrdCabCpmIte();
        }
    }
}
