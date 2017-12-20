using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;

namespace Platin.Infra.Data.Repositories
{
    public class PrdBarRepository : PostgreSQLRepositoryBase<PrdBar>, IPrdBarRepository
    {
        
    }
}
