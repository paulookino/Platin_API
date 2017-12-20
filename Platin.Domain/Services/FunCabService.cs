using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class FunCabService : PostgreSQLServiceBase<FunCab>, IFunCabService
    {
        private readonly IFunCabRepository _funCabRepository;
        
        public FunCabService(IFunCabRepository funCabRepository)
            :base(funCabRepository)
        {
            _funCabRepository = funCabRepository;
        }
    }
}
