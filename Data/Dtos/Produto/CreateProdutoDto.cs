using System.ComponentModel.DataAnnotations;

namespace CardapioApi.Data.Dtos
{
    public class CreateProdutoDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo preço é obrigatório")]
        public double Preco { get; set; } //procurar um tipo adequado para preço
        public int CategoriaId { get; set; }
    }
}
