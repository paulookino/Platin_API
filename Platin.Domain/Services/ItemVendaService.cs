using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class ItemVendaService : ServiceBase<ItemVenda>, IItemVendaService
    {
        private readonly IItemVendaRepository _itemVendaRepository;

        public ItemVendaService(IItemVendaRepository itemVendaRepository)
            :base(itemVendaRepository)
        {
            _itemVendaRepository = itemVendaRepository;
        }
    }
}
