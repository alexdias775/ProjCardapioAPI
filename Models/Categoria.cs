using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardapioApi.Models
{
    public class Categoria
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}
