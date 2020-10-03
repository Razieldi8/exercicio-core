using System;

namespace DV.Gamers.Domain.Entities
{
    public class Endereco : Base
    {
       public string Logradouro { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
