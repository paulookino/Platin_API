using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Application.Interfaces
{
    public interface ICpmCabAppServiceBase : IPostgreSQLAppServiceBase<CpmCab>
    {
        List<CpmCabLotCxaFunCabCpmFec> ConsultaCpmCabLotCxaFunCabCpmFec();

        List<CpmCabPrdCabCpmIte> ConsultaCpmCabPrdCabCpmIte();
    }
}
