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
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult AdicionaCliente(CreateClienteDto dto)
        {
            ReadClienteDto readDto = _clienteService.AdicionaCliente(dto);
            return CreatedAtAction(nameof(RecuperaClientesPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaClientes()
        {
            List<ReadClienteDto> readDto = _clienteService.RecuperaClientes();
            if(readDto == null) return NotFound();
            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaClientesPorId(int id)
        {
            ReadClienteDto readDto = _clienteService.RecuperaClientesPorId(id);
            if (readDto != null)
            {
                return Ok(readDto);
            }
            return NotFound();
        }
    }
}
