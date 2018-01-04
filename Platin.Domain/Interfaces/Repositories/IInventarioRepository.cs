using Platin.Domain.Entities;
using System.Collections.Generic;

namespace Platin.Domain.Interfaces.Repositories
{
    public interface IInventarioRepository : IRepositoryBase<Inventario>
    {
        List<InventarioProduto> ConsultaInventarioProduto();
    }
}
