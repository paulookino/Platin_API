using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;


        public ProdutoService(IProdutoRepository produtoRepository)
            :base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
