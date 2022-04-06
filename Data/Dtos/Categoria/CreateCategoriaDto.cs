using System.ComponentModel.DataAnnotations;

namespace CardapioApi.Data.Dtos
{
    public class CreateCategoriaDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
    }
}
