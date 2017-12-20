using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Services
{
    public interface ICpmIteService : IPostgreSQLServiceBase<CpmIte>
    {
        List<CpmIteCpmCab> ConsultaCpmIteCpmCab();
    }
}
