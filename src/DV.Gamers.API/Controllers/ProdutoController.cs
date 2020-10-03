using DV.Gamers.API.ViewModel;
using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DV.Gamers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult> ObterProduto()
        {

            var listaJogos = _produtoService.ObterProduto();
            return Ok(listaJogos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterProdutosPorId([FromRoute] Guid id)
        {
            var produto = _produtoService.ObterProdutoPorId(id);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult> CriarProduto([FromBody] ProdutoViewModel produtoViewModel)
        {
            try
            {

                var produto = new Produto
                {
                    Descriacao = produtoViewModel.Descriacao,
                    CategoriaId = produtoViewModel.CategoriaId,
                    Ativo = produtoViewModel.Ativo,
                    CriadoEm = DateTime.Now
                };

                var produtoCriado = _produtoService.CriarProduto(produto);
                return Ok(produtoCriado);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
