using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Entities
{
   public class Telefone : Base
    {
        public string DDD { get; set; }
        public string Numero { get; set; }
        public Pessoa Pessoa { get; set; }
        public Guid PessoaId { get; set; }
    }
}
