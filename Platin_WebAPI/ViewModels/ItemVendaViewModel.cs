using System;

namespace Platin_WebAPI.ViewModels
{
    public class ItemVendaViewModel
    {
        public int IteId { get; set; }

        public int ProId { get; set; }

        public int VenId { get; set; }

        public decimal IteQuantidade { get; set; }

        public decimal IteValor { get; set; }

        public string IteInformacao { get; set; }

        public DateTime IteHora { get; set; }

        public DateTime IteData { get; set; }
    }
}
