using AutoMapper;
using CardapioApi.Data;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardapioApi.Services
{
    public class PedidoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public PedidoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Pedido AdicionaPedidos(CreatePedidoDto pedidoDto)
        {
            Pedido pedido = _mapper.Map<Pedido>(pedidoDto);
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return pedido;


        }

        public List<ReadPedidoDto> RecuperaPedidos()
        {
            List<Pedido> pedido = _context.Pedidos.ToList();
            if (pedido == null) return null;
            return _mapper.Map<List<ReadPedidoDto>>(pedido);
        }

        public ReadPedidoDto RecuperaPedidosId(int id)
        {
            Pedido pedido = _context.Pedidos.FirstOrDefault(pedido => pedido.Id == id);
            if (pedido != null)
            {
                return _mapper.Map<ReadPedidoDto>(pedido);
            }
            return null;
        }
    }
}
