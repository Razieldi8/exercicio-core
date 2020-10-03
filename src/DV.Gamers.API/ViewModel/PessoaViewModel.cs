using System.Collections.Generic;

namespace DV.Gamers.API.ViewModel
{
    public class PessoaViewModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public IList<EnderecoViewModel> Enderecos { get; set; }

        public PessoaViewModel()
        {
            Enderecos = new List<EnderecoViewModel>();
        }
    }
}
