using System.Collections.Generic;
using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Services;

namespace Platin.Application
{
    public class VFunUadCabAppServiceBase : PostgreSQLAppServiceBase<VFunUadCab>, IVFunUadCabAppServiceBase
    {
        private readonly IVFunUadCabService _vFunUadCabService;

        public VFunUadCabAppServiceBase(IVFunUadCabService vFunUadCabService)
            :base(vFunUadCabService)
        {
            _vFunUadCabService = vFunUadCabService;
        }

        public List<VFunUadCabUsuSis> ConsultaVFunUadCabUsuSis()
        {
            return _vFunUadCabService.ConsultaVFunUadCabUsuSis();
        }
    } 
}
