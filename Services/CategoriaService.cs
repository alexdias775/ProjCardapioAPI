using AutoMapper;
using CardapioApi.Data;
using CardapioApi.Data.Dtos;
using CardapioApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardapioApi.Services
{
    public class CategoriaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public CategoriaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Categoria AdicionaProduto(CreateCategoriaDto categoriaDto)
        {
            Categoria categoria = _mapper.Map<Categoria>(categoriaDto);
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }

        public List<ReadCategoriaDto> RecuperaCategoria()
        {
            List<Categoria> categoria = _context.Categorias.ToList();
            if(categoria == null) return null;
            return _mapper.Map<List<ReadCategoriaDto>>(categoria);
        }

        public ReadCategoriaDto RecuperaCategoriasId(int id)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria != null)
            {
                return _mapper.Map<ReadCategoriaDto>(categoria);
            }
            return null;
        }
    }
}
