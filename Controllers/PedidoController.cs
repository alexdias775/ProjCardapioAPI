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
    public class PedidoController : Controller
    {
        private PedidoService _pedidoService;

        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public IActionResult AdicionaPedidos([FromBody] CreatePedidoDto pedidoDto)
        {
            Pedido pedido = _pedidoService.AdicionaPedidos(pedidoDto);
            return CreatedAtAction(nameof(RecuperaPedidosId), new { Id = pedido.Id }, pedido);
        }

        [HttpGet]
        public IActionResult RecuperaPedidos()
        {
            List<ReadPedidoDto> readDto = _pedidoService.RecuperaPedidos();
            if (readDto == null) return NotFound();
            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPedidosId(int id)
        {
            ReadPedidoDto readDto = _pedidoService.RecuperaPedidosId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();

        }
    }
}
