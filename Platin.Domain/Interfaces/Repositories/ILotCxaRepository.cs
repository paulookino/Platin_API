using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Repositories
{
    public interface ILotCxaRepository : IPostgreSQLRepositoryBase<LotCxa>
    {
        List<LotCxaVFunUadCab> ConsultaLotCxaVFunUadCab();
    }
}
