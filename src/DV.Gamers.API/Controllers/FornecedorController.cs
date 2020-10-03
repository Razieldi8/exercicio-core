using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using DV.Gamers.Domain.Entities;
using DV.Gamers.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DV.Gamers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterFornecedorPorId([FromRoute]Guid id)
        {
            var fornecedores = _fornecedorService.ObterFornecedorId(id);
            return Ok(fornecedores);
        }
        [HttpGet]
        public async Task<ActionResult> ObterFornecedor()
        {
            var fornecedor = _fornecedorService.ObterFornecedor();
            return Ok(fornecedor) ;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarFornecedor(Guid id)
        {
            _fornecedorService.Delete(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CriarFornecedor([FromBody]Fornecedor _fornecedor)
        {
            var fornecedorAdd = _fornecedorService.CriarFornecedor(_fornecedor);
            return Ok(fornecedorAdd);
        }
            
    }
}
