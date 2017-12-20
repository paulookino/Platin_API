using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Platin.Infra.Data.Repositories
{
    public class VFunUadCabRepository : PostgreSQLRepositoryBase<VFunUadCab>, IVFunUadCabRepository
    {
        public List<VFunUadCabUsuSis> ConsultaVFunUadCabUsuSis()
        {
            var result = (from vFunUadCab in db.VFunUadCab
                          from usuSis in db.UsuSis
                          select new VFunUadCabUsuSis
                          {
                            FunId = vFunUadCab.Ide,
                            FunNome = vFunUadCab.Fun,
                            FunUsuario = usuSis.Log,
                            FunSenha = usuSis.Pas,
                            FunNivel = vFunUadCab.Cgo,
                            FunInformacao = usuSis.Pas
                          }).ToList();

            return result;
        }
    }
}
