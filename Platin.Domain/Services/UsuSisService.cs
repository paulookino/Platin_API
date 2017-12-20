using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class UsuSisService : PostgreSQLServiceBase<UsuSis>, IUsuSisService
    {
        private readonly IUsuSisRepository _usuSisRepository;

        public UsuSisService(IUsuSisRepository usuSisRepository)
            :base(usuSisRepository)
        {
            _usuSisRepository = usuSisRepository;
        }
    }
}
