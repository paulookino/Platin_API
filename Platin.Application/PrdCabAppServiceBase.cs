using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class PrdCabAppServiceBase : PostgreSQLAppServiceBase<PrdCab>, IPrdCabAppServiceBase
    {

        private readonly IPrdCabService _prdCabService;

       public PrdCabAppServiceBase(IPrdCabService prdCabService)
            :base(prdCabService)
        {
            _prdCabService = prdCabService;
        }
    }
}
