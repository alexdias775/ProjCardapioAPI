using AutoMapper;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;

namespace CardapioApi.Profiles
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<CreatePedidoDto, Pedido>();
            CreateMap<Pedido, ReadPedidoDto>();
        }
    }
}
