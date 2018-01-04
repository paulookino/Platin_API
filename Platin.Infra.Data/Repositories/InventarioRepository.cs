using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Platin.Infra.Data.Repositories
{
    public class InventarioRepository : RepositoryBase<Inventario>, IInventarioRepository
    {
        public List<InventarioProduto> ConsultaInventarioProduto()
        {
            var result = (from inventario in db.Inventario
                          join produto in db.Produto on inventario.InvCodigo equals produto.ProCodigo
                          
                          select new InventarioProduto
                          {
                              InvId = inventario.InvId,
                              InvCodigo = produto.ProCodigo,
                              ProId = produto.ProId,
                              ProNome = produto.ProNome,
                          }).ToList();

            return result;
        }

    }
}
