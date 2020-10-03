using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DV.Gamers.Application.Services;
using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult> ObterPessoaPorId([FromRoute]Guid id)
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
        public async Task<ActionResult> CriarPessoa([FromBody]Pessoa pessoa)
        {
            var pessoaAdd = _pessoaService.CriarPessoa(pessoa);
            return Ok(pessoaAdd);
        }

    }
}
