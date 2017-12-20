using System;

namespace Platin.Domain.Entities
{
    public class CpmCabPrdCabCpmIte
    {

        public long CupId { get; set; }

        public long CupCodigo { get; set; }

        public long CupProduto { get; set; }

        public double CupQuantidade { get; set; }

        public DateTime CupData { get; set; }

        public TimeSpan CupHora { get; set; }

        public double IteValor { get; set; }

        public long CupNumero { get; set; }
    }
}
