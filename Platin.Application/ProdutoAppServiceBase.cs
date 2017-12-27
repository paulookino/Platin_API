using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class ProdutoAppServiceBase : AppServiceBase<Produto>, IProdutoAppServiceBase
    {
        private readonly IProdutoService _produtoService;
        
        public ProdutoAppServiceBase(IProdutoService produtoService)
            :base(produtoService)
        {
            _produtoService = produtoService;
        }
    }
}
