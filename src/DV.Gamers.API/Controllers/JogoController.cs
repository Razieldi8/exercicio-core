using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DV.Gamers.Application.Services;
using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Services;
using DV.Gamers.Infra.Data.EF.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DV.Gamers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {

        private readonly IJogoService _jogoService;

        public JogoController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }

        [HttpGet]
        public async Task<ActionResult> ObterJogos()
        {

            var listaJogos = _jogoService.ObterJogos();
            return Ok(listaJogos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterJogosPorId([FromRoute] Guid id)
        {
            //return BadRequest();
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CriarJogo([FromBody] Jogo jogo)
        {
            try
            {
                var jogoCriado = _jogoService.CriarJogo(jogo);
                return Ok(jogoCriado);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
