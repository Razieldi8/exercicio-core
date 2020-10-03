using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DV.Gamers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult> ObterCategoria()
        {
            var ListaCategoria = _categoriaService.ObterCategoria();

            return Ok(ListaCategoria);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult> ObterCategoriaId([FromRoute]Guid id) 
        {
            var categorias = _categoriaService.CriarCategoriaId(id);
            return Ok(categorias);
        }

        [HttpDelete("{id}")]
       
        public async Task<ActionResult> DeletarCategoria([FromRoute]Guid id) 
        {
            _categoriaService.deletarCategoria(id);
            return Ok();
        }
        [HttpPost]

        public async Task<ActionResult> CriarCategoria([FromBody]string descricao) 
        {

            var categoria = new Categoria
            {
                Descricao = descricao,
                CriadoEm = DateTime.Now,
                Ativo = true

            };

            var categoriaAdd = _categoriaService.CriarCategoria(categoria);
            return Ok(categoriaAdd);

        }

    }
}
