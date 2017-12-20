using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class UsuSisAppServiceBase : PostgreSQLAppServiceBase<UsuSis>, IUsuSisAppServiceBase
    {
        private readonly IUsuSisService _usuSisService;

        public UsuSisAppServiceBase(IUsuSisService usuSisService)
            :base(usuSisService)
        {
            _usuSisService = usuSisService;
        }
    }
}
