using CardapioApi.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardapioApi.Data.Dtos
{
    public class CreatePedidoDto
    {
        public CreateClienteDto Cliente { get; set; }
        public CreateEnderecoDto Endereco { get; set; }
        public List<CreateItemPedidoDto> ItensPedido { get; set; }
        public double ValorTotal { get; set; }
    }
}
