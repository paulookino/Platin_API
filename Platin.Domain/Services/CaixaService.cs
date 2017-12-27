using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class CaixaService : ServiceBase<Caixa>, ICaixaService
    {
        private readonly ICaixaRepository _caixaRepository;


        public CaixaService(ICaixaRepository caixaRepository)
            :base(caixaRepository)
        {
            _caixaRepository = caixaRepository;
        }
    }
}
