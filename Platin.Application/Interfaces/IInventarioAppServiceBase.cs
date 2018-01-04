using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Application.Interfaces
{
    public interface IInventarioAppServiceBase : IAppServiceBase<Inventario>
    {
        List<InventarioProduto> ConsultaInventarioProduto();
    }
}
