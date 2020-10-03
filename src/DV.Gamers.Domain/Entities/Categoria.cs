using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Entities
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string  Descricao { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }

    }
}
