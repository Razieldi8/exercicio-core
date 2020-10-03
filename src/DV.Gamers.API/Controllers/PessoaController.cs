using DV.Gamers.API.ViewModel;
using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DV.Gamers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public async Task<ActionResult> ObterPessoa()
        {
            var pessoas = _pessoaService.ObterPessoa();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterPessoaPorId([FromRoute] Guid id)
        {
            var pessoa = _pessoaService.ObterPessoaPorId(id);
            return Ok(pessoa);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarPessoa([FromRoute] Guid id)
        {
            _pessoaService.Deletar(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CriarPessoa([FromBody] PessoaViewModel pessoaViewModel)
        {
            var listaEnderecos = new List<Endereco>();
            var pessoa = new Pessoa
            {
                Nome = pessoaViewModel.Nome,
                Sobrenome = pessoaViewModel.Sobrenome,
                Ativo = true,
                CriadoEm = DateTime.Now,
            };

            foreach (var item in pessoaViewModel.Enderecos)
            {
                var endereco = new Endereco
                {
                    Logradouro = item.Logradouro,
                    Numero = item.Numero,
                    Ativo = true,
                    Cidade = item.Cidade,
                    CriadoEm = DateTime.Now,
                    Estado = item.Estado,

                };

                pessoa.Enderecos.Add(endereco);
            }

            var pessoaAdd = _pessoaService.CriarPessoa(pessoa);
            return Ok(pessoaAdd);
        }

    }
}
