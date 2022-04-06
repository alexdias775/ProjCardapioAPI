using System.ComponentModel.DataAnnotations;

namespace CardapioApi.Data.Dtos
{
    public class CreateEnderecoDto
    {
        [Required(ErrorMessage = "Digite seu Logradouro")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Digite seu Bairro")]
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}
