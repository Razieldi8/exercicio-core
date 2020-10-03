using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }
        [HttpGet]
        public async Task<ActionResult> ObterEndereco()
        {
            var listaEnderecos = _enderecoService.ObterEndereco();
            return Ok(listaEnderecos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> ObterEnderecoPorId([FromRoute]Guid id)
        {
            var enderecos = _enderecoService.CriarEnderecoPorId(id);
            return Ok(enderecos);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarEndereco([FromRoute]Guid id)
        {
           _enderecoService.DeletarEndereco(id);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> CriarEndereco([FromBody]Endereco _endereco)
        {
            var enderecoAdd = _enderecoService.CriarEndereco(_endereco);
            return Ok(enderecoAdd);
        }
    }
}
