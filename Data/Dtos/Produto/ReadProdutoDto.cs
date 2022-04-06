using System.ComponentModel.DataAnnotations;

namespace CardapioApi.Data.Dtos
{
    public class ReadProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; } //procurar um tipo adequado para preço
    }
}
