using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Repositories
{
    public interface ICpmIteRepository : IPostgreSQLRepositoryBase<CpmIte>
    {
        List<CpmIteCpmCab> ConsultaCpmIteCpmCab();

    }
}
