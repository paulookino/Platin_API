using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class CupomService : ServiceBase<Cupom>, ICupomService
    {
        private readonly ICupomRepository _cupomRepository;

        public CupomService(ICupomRepository cupomRepository)
            :base(cupomRepository)
        {
            _cupomRepository = cupomRepository;
        }
    }
}
