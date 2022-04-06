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
    public class ProdutoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ProdutoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadProdutoDto AdicionaProduto(CreateProdutoDto produtoDto)
        {
            Produto produto = _mapper.Map<Produto>(produtoDto);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return _mapper.Map<ReadProdutoDto>(produto);
        }

        public List<ReadProdutoDto> RecuperaProdutos(int? categoriaId)
        {
            List<Produto> produtos;
            if (categoriaId == null)
            {
                produtos = _context.Produtos.ToList();
            }
            else
            {
                produtos = _context
                .Produtos.Where(produtos => produtos.CategoriaId == categoriaId).ToList();
            }
            if (produtos != null)
            {
                List<ReadProdutoDto> readDto = _mapper.Map<List<ReadProdutoDto>>(produtos);
                return readDto;
            }
            return null;
        }

        public ReadProdutoDto RecuperaProdutosId(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto != null)
            {
                ReadProdutoDto produtoDto = _mapper.Map<ReadProdutoDto>(produto);
                return produtoDto;
            }
            return null;
        }

        public Result DeletaProduto(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
            {
                return Result.Fail("Filme não encontrado");
            }
            _context.Remove(produto);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
