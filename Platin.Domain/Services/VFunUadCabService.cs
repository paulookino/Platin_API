using System.Collections.Generic;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using Platin.Domain.Interfaces.Services;

namespace Platin.Domain.Services
{
    public class VFunUadCabService : PostgreSQLServiceBase<VFunUadCab>, IVFunUadCabService
    {
        private readonly IVFunUadCabRepository _vFunUadCabRepository;


        public VFunUadCabService(IVFunUadCabRepository vFunUadCabRepository)
            :base(vFunUadCabRepository)
        {
            _vFunUadCabRepository = vFunUadCabRepository;
        }

        public List<VFunUadCabUsuSis> ConsultaVFunUadCabUsuSis()
        {
            return _vFunUadCabRepository.ConsultaVFunUadCabUsuSis();
        }
    }
}
