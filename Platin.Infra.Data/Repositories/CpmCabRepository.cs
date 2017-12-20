using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Platin.Infra.Data.Repositories
{
    public class CpmCabRepository : PostgreSQLRepositoryBase<CpmCab>, ICpmCabRepository
    {
        public List<CpmCabLotCxaFunCabCpmFec> ConsultaCpmCabLotCxaFunCabCpmFec()
        {
            var result = (from cpmCab in db.CpmCab
                          from lotCxa in db.LotCxa
                          from funCab in db.FunCab
                          from cpmFec in db.CpmFec
                          select new CpmCabLotCxaFunCabCpmFec
                          {
                             VenId = cpmCab.Ide,
                             VenData = cpmCab.Dat,
                             VenHora = cpmCab.Hor,
                             VenTotal = cpmFec.Vlt,
                             CaiId = lotCxa.Ide,
                             FunId = funCab.Ide
                          }).Take(30).ToList();

            return result;
        }


        public List<CpmCabPrdCabCpmIte> ConsultaCpmCabPrdCabCpmIte()
        {
            var result = (from cpmCab in db.CpmCab
                          from prdCab in db.PrdCab
                          from cpmIte in db.CpmIte
                          select new CpmCabPrdCabCpmIte
                          {
                             CupId = cpmCab.Ide,
                             CupCodigo = cpmCab.Cpm,
                             CupProduto = prdCab.Ide,
                             CupQuantidade = cpmIte.Qtd,
                             CupData = cpmCab.Dat,
                             CupHora = cpmCab.Hor,
                             IteValor = cpmIte.Vlr,
                             CupNumero = cpmIte.Cod
                          }).Take(30).ToList();

            return result;
        }
    }
}
