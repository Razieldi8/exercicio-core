using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DV.Gamers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefoneController : ControllerBase
    {
        private readonly ITelefoneService _telefoneService;

        public TelefoneController(ITelefoneService telefoneService)
        {
            _telefoneService = telefoneService;
        }

        [HttpGet]
        public async Task<ActionResult> ObterTelefone()
        {
            var telefone = _telefoneService.ObterTelefone();
            return Ok(telefone);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> ObterTelefoneId([FromRoute] Guid id)
        {
            var _telefone = _telefoneService.ObterTelefoneId(id);
            return Ok(_telefone);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarTelefone([FromRoute] Guid id)
        {
            _telefoneService.DeletarTelefone(id);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> CriarTelefone([FromBody] Telefone _telefones)
        {
            var telefoneAdd = _telefoneService.CriarTelefone(_telefones);
            return Ok(telefoneAdd);

        }
    }
}
