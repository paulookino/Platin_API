using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Services
{
    public interface ICpmCabService : IPostgreSQLServiceBase<CpmCab>
    {
        List<CpmCabLotCxaFunCabCpmFec> ConsultaCpmCabLotCxaFunCabCpmFec();

        List<CpmCabPrdCabCpmIte> ConsultaCpmCabPrdCabCpmIte();
    }
}
