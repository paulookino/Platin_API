using System;

namespace Platin_WebAPI.ViewModels
{
    public class VendaViewModel
    {
        public int VenId { get; set; }

        public int CliId { get; set; }

        public int FunId { get; set; }

        public DateTime VenData { get; set; }

        public DateTime VenHora { get; set; }

        public decimal VenTotal { get; set; }

        public decimal VenDesconto { get; set; }

        public int VenStatus { get; set; }

        public string VenSenha { get; set; }

        public decimal VenEntrega { get; set; }

        public int MesNumero { get; set; }

        public int EntNumero { get; set; }

        public int VenViagem { get; set; }

        public int VenImpresso { get; set; }

        public int CaiId { get; set; }
    }
}
