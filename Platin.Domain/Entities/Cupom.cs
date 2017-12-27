using System;

namespace Platin.Domain.Entities
{
    public class Cupom
    {
        public int CupId { get; set; }

        public string CupCodigo { get; set; }

        public string CupProduto { get; set; }

        public string CupAliquota { get; set; }

        public string CupQuantidade { get; set; }

        public DateTime CupData { get; set; }

        public DateTime CupHora { get; set; }

        public decimal CupTotal { get; set; }
    }
}
