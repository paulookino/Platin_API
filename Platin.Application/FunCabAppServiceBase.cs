using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class FunCabAppServiceBase : PostgreSQLAppServiceBase<FunCab>, IFunCabAppServiceBase
    {
        private readonly IFunCabService _funCabService;

        public FunCabAppServiceBase(IFunCabService funCabService)
            :base(funCabService)
        {
            _funCabService = funCabService;
        }
    }
}
