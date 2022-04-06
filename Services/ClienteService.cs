using AutoMapper;
using CardapioApi.Data;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardapioApi.Services
{
    public class ClienteService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ClienteService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadClienteDto AdicionaCliente(CreateClienteDto dto)
        {
            Cliente cliente = _mapper.Map<Cliente>(dto);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return _mapper.Map<ReadClienteDto>(cliente);
        }

        public List<ReadClienteDto> RecuperaClientes()
        {
            List<Cliente> cliente = _context.Clientes.ToList();
            if (cliente != null)
            {
                return _mapper.Map<List<ReadClienteDto>>(cliente);
            }
            return null;
        }

        public ReadClienteDto RecuperaClientesPorId(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            if (cliente != null)
            {
                return _mapper.Map<ReadClienteDto>(cliente);
            }
            return null;
        }
    }
}
