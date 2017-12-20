using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Application.Interfaces
{
    public interface ILotCxaAppServiceBase : IPostgreSQLAppServiceBase<LotCxa>
    {
        List<LotCxaVFunUadCab> ConsultaLotCxaVFunUadCab();
    }
}
