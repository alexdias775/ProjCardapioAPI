using AutoMapper;
using CardapioApi.Data;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;
using CardapioApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CardapioApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CategoriaController : Controller
    {
        private CategoriaService _categoriaService;

        public CategoriaController(CategoriaService categoriaService)
        { 
            _categoriaService = categoriaService;
        }

        [HttpPost]
        public IActionResult AdicionaProduto([FromBody] CreateCategoriaDto categoriaDto)
        {
           Categoria categoria = _categoriaService.AdicionaProduto(categoriaDto);
           return CreatedAtAction(nameof(RecuperaCategoriasId), new { Id = categoria.Id }, categoria);
        }

        [HttpGet]
        public IActionResult RecuperaCategorias()
        {
            List<ReadCategoriaDto> readDto = _categoriaService.RecuperaCategoria();
            if (readDto == null) return NotFound();
            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCategoriasId(int id)
        {
            ReadCategoriaDto readDto = _categoriaService.RecuperaCategoriasId(id);
            if (readDto != null)    return Ok(readDto);
            return NotFound();
        }
    }
}
