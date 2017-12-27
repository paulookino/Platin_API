using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class ItemVendaAppServiceBase : AppServiceBase<ItemVenda>, IItemVendaAppServiceBase
    {
        private readonly IItemVendaService _itemVendaService;

        public ItemVendaAppServiceBase(IItemVendaService itemVendaService)
            :base(itemVendaService)
        {
            _itemVendaService = itemVendaService;
        }
    }
}
