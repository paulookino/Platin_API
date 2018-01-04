using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Services
{
    public interface IInventarioService : IServiceBase<Inventario>
    {
        List<InventarioProduto> ConsultaInventarioProduto();
    }
}
