using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Repositories
{
    public interface IVFunUadCabRepository : IPostgreSQLRepositoryBase<VFunUadCab>
    {
        List<VFunUadCabUsuSis> ConsultaVFunUadCabUsuSis();
    }
}
