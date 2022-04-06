using AutoMapper;
using CardapioApi.Data;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;
using CardapioApi.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CardapioApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProdutoController : Controller
    {
        private ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public IActionResult AdicionaProduto([FromBody] CreateProdutoDto produtoDto)
        {
            ReadProdutoDto readDto = _produtoService.AdicionaProduto(produtoDto);
            return CreatedAtAction(nameof(RecuperaProdutosId), new { Id = readDto.Id }, readDto);
        }

        //[HttpGet]
        //public IEnumerable<Produto> RecuperaProdutos()
        //{
        //    return _context.Produtos;
        //}
        [HttpGet]
        public IActionResult RecuperaProdutos([FromQuery] int? categoriaId = null)
        /*parâmetro de consulta [FromQuery] */
        {

            List<ReadProdutoDto> readDto = _produtoService.RecuperaProdutos(categoriaId);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaProdutosId(int id)
        {
            ReadProdutoDto readDto = _produtoService.RecuperaProdutosId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        //[HttpGet("{categoriaId}")]
        //public IActionResult RecuperaProdutosCategoriaId(int categoriaId)
        //{
        //    Produto produto = _context.Produtos.FirstOrDefault(produto => produto.CategoriaId == categoriaId);
        //    if (produto != null)
        //    {
        //        ReadProdutoDto produtoDto = _mapper.Map<ReadProdutoDto>(produto);
        //        return Ok(produtoDto);
        //    }
        //    return NotFound();
        //}


        [HttpDelete("{id}")]
        public IActionResult DeletaProduto(int id)
        {
            Result resultado = _produtoService.DeletaProduto(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
