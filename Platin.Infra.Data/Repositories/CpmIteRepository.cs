using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace Platin.Infra.Data.Repositories
{
    public class CpmIteRepository : PostgreSQLRepositoryBase<CpmIte>, ICpmIteRepository
    {
        public List<CpmIteCpmCab> ConsultaCpmIteCpmCab()
        {
            var result = (from cpmIte in db.CpmIte
                          from cpmCab in db.CpmCab
                          select new CpmIteCpmCab
                          {
                             IteId = cpmIte.Ide,
                             ProId = cpmIte.Prd,
                             VenId = cpmIte.Lot,
                             IteQuantidade = cpmIte.Qtd,
                             IteValor = cpmIte.Vlr,
                             IteHora = cpmCab.Hor,
                             IteData = cpmCab.Dat
                          }).Take(30).ToList();

            return result;
        }
    }
}
