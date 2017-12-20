using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Services
{
    public interface ILotCxaService : IPostgreSQLServiceBase<LotCxa>
    {
        List<LotCxaVFunUadCab> ConsultaLotCxaVFunUadCab();
    }
}
