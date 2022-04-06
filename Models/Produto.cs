using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CardapioApi.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo preço é obrigatório")]
        public double Preco { get; set; } 
        [JsonIgnore]
        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        [JsonIgnore]
        public virtual List<ItemPedido> ItensPedido { get; set; }

    }
}