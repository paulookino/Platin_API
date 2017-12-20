using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Application.Interfaces
{
    public interface ICpmIteAppServiceBase : IPostgreSQLAppServiceBase<CpmIte>
    {
        List<CpmIteCpmCab> ConsultaCpmIteCpmCab();
    }
}
