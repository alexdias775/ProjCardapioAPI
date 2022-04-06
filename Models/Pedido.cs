using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardapioApi.Models
{
    public class Pedido
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Endereco Endereco { get; set; } 
        public virtual List<ItemPedido> ItensPedido { get; set; }
        public double ValorTotal { get; set; }  
    }
}
