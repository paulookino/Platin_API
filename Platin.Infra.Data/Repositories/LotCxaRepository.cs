using Platin.Domain.Entities;
using Platin.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace Platin.Infra.Data.Repositories
{
    public class LotCxaRepository : PostgreSQLRepositoryBase<LotCxa>, ILotCxaRepository
    {
        public List<LotCxaVFunUadCab> ConsultaLotCxaVFunUadCab()
        {
            var result = (from lotCxa in db.LotCxa
                          from vFunUadCab in db.VFunUadCab
                          select new LotCxaVFunUadCab
                          {
                                CaiId = lotCxa.Ide,
                                FunId = vFunUadCab.Ide,
                                CaiValorInicial = lotCxa.Vlc,
                                CaiDataInicial = lotCxa.Dat,
                                CaiHoraInicial = lotCxa.Hor,
                                CaiStatus = lotCxa.Stt,
                                CaiNumero = lotCxa.Maq
                          }).Take(30).ToList();

            return result;
        }
    }
}
