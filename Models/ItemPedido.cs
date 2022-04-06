using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CardapioApi.Models
{
    public class ItemPedido
    {
        [Key]
        [Required]
        [JsonIgnore]
        public int Id { get; set; }
        //public int Quantidade { get; set; }
        public double ValorTotalItem { get; set; }
        public virtual Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        [JsonIgnore]
        public virtual Pedido Pedido { get; set; }
        [JsonIgnore]
        public int PedidoId { get; set; }
        public int Indice { get; set; }
    }
}
