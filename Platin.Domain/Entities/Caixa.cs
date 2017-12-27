using System;

namespace Platin.Domain.Entities
{
    public class Caixa
    {
        public int CaiId { get; set; }

        public int FunId { get; set; }

        public int FunIdFechamento{ get; set; }

        public decimal CaiValorInicial { get; set; }

        public decimal CaiValorFinal { get; set; }

        public DateTime CaiDataInicial { get; set; }

        public DateTime CaiDataFinal { get; set; }

        public DateTime CaiHoraInicial { get; set; }

        public DateTime CaiHoraFinal { get; set; }

        public int CaiStatus { get; set; }

        public string CaiInformacao { get; set; }

        public int CaiNumero { get; set; }

    }
}
