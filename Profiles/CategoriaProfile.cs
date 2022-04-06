using AutoMapper;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;

namespace CardapioApi.Profiles
{
    public class CategoriaProfile : Profile
    {   
        public CategoriaProfile()
        {
            CreateMap<CreateCategoriaDto, Categoria>();
            CreateMap<Categoria, ReadCategoriaDto>();
        }
    }
}
