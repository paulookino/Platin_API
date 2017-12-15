using System;

namespace Platin.Domain.Entities
{
    public class EntityBase
    {
        public int EntityId { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime UltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
