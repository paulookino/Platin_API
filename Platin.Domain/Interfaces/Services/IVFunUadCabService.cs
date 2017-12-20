using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Services
{
    public interface IVFunUadCabService : IPostgreSQLServiceBase<VFunUadCab>
    {
        List<VFunUadCabUsuSis> ConsultaVFunUadCabUsuSis();
    }
}
