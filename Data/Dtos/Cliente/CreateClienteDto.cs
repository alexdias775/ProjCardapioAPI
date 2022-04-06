using System.ComponentModel.DataAnnotations;

namespace CardapioApi.Data.Dtos
{
    public class CreateClienteDto
    {
        [Required(ErrorMessage = "Digite seu nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite seu telefone")]
        public long Telefone { get; set; }
        [Required(ErrorMessage = "Digite seu telefone")]
        public string FormaDePagamento { get; set; }
    }
}
