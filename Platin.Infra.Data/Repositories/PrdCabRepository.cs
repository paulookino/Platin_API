using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Platin.Infra.Data.Repositories
{
    public class PrdCabRepository : PostgreSQLRepositoryBase<PrdCab>, IPrdCabRepository
    {
        public List<PrdCabPrdBarCpmIte> ConsultaPrdCabPrdBarCpmIte()
        {
            var result = (from prdCab in db.PrdCab
                          from prdBar in db.PrdBar
                          from cpmIte in db.CpmIte
                          select new PrdCabPrdBarCpmIte
                          {
                              ProId = prdCab.Ide,
                              ProNome = prdCab.Des,
                              ProDescricao = prdCab.Des,
                              ProValor = cpmIte.Vlr,
                              ProCodigo = prdBar.Bar
                          }).Take(100).ToList();

            return result;
        }
    }
}
