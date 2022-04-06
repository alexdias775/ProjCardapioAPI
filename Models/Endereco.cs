using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CardapioApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; } 
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        [JsonIgnore]
        public virtual List<Pedido> Pedidos { get; set; }
    }
}
