using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Repositories
{
    public interface ICpmCabRepository : IPostgreSQLRepositoryBase<CpmCab>
    {
        List<CpmCabLotCxaFunCabCpmFec> ConsultaCpmCabLotCxaFunCabCpmFec();

        List<CpmCabPrdCabCpmIte> ConsultaCpmCabPrdCabCpmIte();
    }
}
