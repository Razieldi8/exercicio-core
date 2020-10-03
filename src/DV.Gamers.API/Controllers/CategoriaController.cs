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

        public async Task<ActionResult> CriarCategoria([FromBody]Categoria _categoria) 
        {
            var categoriaAdd = _categoriaService.CriarCategoria(_categoria);
            return Ok(categoriaAdd);

        }

    }
}
