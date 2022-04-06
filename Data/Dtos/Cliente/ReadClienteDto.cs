namespace CardapioApi.Data.Dtos
{
    public class ReadClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public string FormaDePagamento { get; set; }
    }
}
