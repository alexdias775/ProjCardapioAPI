using CardapioApi.Models;
using System.Collections.Generic;

namespace CardapioApi.Data.Dtos 
{ 
    public class ReadPedidoDto
    {
        public virtual Cliente Cliente { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual List<ItemPedido> ItensPedido { get; set; }
        public double ValorTotal { get; set; }
    }
}
