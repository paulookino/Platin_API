using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Repositories
{
    public interface IPrdCabRepository : IPostgreSQLRepositoryBase<PrdCab>
    {
        List<PrdCabPrdBarCpmIte> ConsultaPrdCabPrdBarCpmIte();
    }
}
