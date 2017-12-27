using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class FuncionarioAppServiceBase : AppServiceBase<Funcionario>, IFuncionarioAppServiceBase
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioAppServiceBase(IFuncionarioService funcionarioService)
            :base(funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
    }
}
