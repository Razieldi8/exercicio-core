using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Descriacao { get; set; }
        public string Genero { get; set; }
        public decimal Preco { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }
    }
}
