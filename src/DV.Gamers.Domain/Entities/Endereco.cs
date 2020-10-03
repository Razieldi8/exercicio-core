using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Entities
{
   public class Endereco
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Estado { get; set; }

    }
}
