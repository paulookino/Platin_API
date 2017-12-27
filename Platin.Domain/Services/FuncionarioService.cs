using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class FuncionarioService : ServiceBase<Funcionario>, IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        
        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
            :base(funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }
    }
}
