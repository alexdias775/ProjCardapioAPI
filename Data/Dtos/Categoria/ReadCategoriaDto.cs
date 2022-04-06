using System.Collections.Generic;
using CardapioApi.Models;

namespace CardapioApi.Data.Dtos
{
    public class ReadCategoriaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
