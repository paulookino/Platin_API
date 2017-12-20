using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Services
{
    public interface IPrdCabService : IPostgreSQLServiceBase<PrdCab>
    {
        List<PrdCabPrdBarCpmIte> ConsultaPrdCabPrdBarCpmIte();
    }
}
