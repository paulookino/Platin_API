using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class ClsCabService : PostgreSQLServiceBase<ClsCab>, IClsCabService
    {
        private readonly IClsCabRepository _clsCabRepository;

        public ClsCabService(IClsCabRepository clsCabRepository)
            :base(clsCabRepository)
        {
            _clsCabRepository = clsCabRepository;
        }
    }
}
