using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Application.Interfaces
{
    public interface IVFunUadCabAppServiceBase : IPostgreSQLAppServiceBase<VFunUadCab>
    {
        List<VFunUadCabUsuSis> ConsultaVFunUadCabUsuSis();
    }
}
