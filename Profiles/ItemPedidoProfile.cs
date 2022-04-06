using AutoMapper;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;

namespace CardapioApi.Profiles
{
    public class ItemPedidoProfile : Profile
    {
        public ItemPedidoProfile()
        {
            CreateMap<CreateItemPedidoDto, ItemPedido>();
            CreateMap<ItemPedido, ReadItemPedidoDto>();
        }
    }
}
