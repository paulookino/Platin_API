using System;

namespace Platin.Domain.Entities
{
    public class CpmIteCpmCab
    {
        public long IteId { get; set; }

        public long ProId { get; set; }

        public long VenId { get; set; }

        public double IteQuantidade { get; set; }

        public double IteValor { get; set; }

        public DateTime IteData { get; set; }

        public TimeSpan IteHora { get; set; }
    }
}
