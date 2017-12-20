using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Application.Interfaces
{
    public interface IPrdCabAppServiceBase : IPostgreSQLAppServiceBase<PrdCab>
    {
        List<PrdCabPrdBarCpmIte> ConsultaPrdCabPrdBarCpmIte();
    }
}
