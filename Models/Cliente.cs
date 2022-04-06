using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CardapioApi.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public long Telefone { get; set; }
        [Required]
        public string FormaDePagamento { get; set; }
        [JsonIgnore]
        public virtual List<Pedido> Pedidos { get; set; }

    }
}
