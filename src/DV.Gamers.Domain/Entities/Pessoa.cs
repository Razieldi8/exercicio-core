using System.Collections.Generic;

namespace DV.Gamers.Domain.Entities
{
    public class Pessoa : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public bool Status { get; set; }
        public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();
    }
}
