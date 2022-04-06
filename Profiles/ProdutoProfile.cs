using AutoMapper;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;

namespace CardapioApi.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
        }
    }
}

    
