using System.Collections.Generic;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class InventarioService : ServiceBase<Inventario>, IInventarioService
    {
        private readonly IInventarioRepository _inventarioRepository;

        public InventarioService(IInventarioRepository inventarioRepository)
            :base(inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }

        public List<InventarioProduto> ConsultaInventarioProduto()
        {
            return _inventarioRepository.ConsultaInventarioProduto();
        }
    }
}
