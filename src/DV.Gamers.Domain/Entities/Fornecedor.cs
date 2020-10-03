using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Domain.Entities
{
   public class Fornecedor
    {
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}
