using System;

namespace Platin.Domain.Entities
{
    public class LotCxaVFunUadCab
    {
        public long CaiId { get; set; }

        public long FunId { get; set; }

        public double CaiValorInicial { get; set; }

        public DateTime CaiDataInicial { get; set; }

        public TimeSpan CaiHoraInicial { get; set; }

        public string CaiStatus { get; set; }

        public string CaiNumero { get; set; }
    }
}
