using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class ClsCabAppServiceBase : PostgreSQLAppServiceBase<ClsCab>, IClsCabAppServiceBase
    {
        private readonly IClsCabService _clsCabService;

        public ClsCabAppServiceBase(IClsCabService clsCabService)
            :base(clsCabService)
        {
            _clsCabService = clsCabService;
        }
    }
}
