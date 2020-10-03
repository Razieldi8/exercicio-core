using System;

namespace DV.Gamers.Domain.Entities
{
    public class Base
    {
        public Guid Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }

        public Base()
        {
            Id = Guid.NewGuid();
        }
    }
}
