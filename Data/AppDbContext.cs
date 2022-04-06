using CardapioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>()
                .HasOne(produto => produto.Categoria)
                .WithMany(categoria => categoria.Produtos)
                .HasForeignKey(produto => produto.CategoriaId);

            //builder.Entity<Pedido>()
            //    .HasOne(pedido => pedido.Cliente)
            //    .WithMany(cliente => cliente.Pedidos)
            //    .HasForeignKey(pedido => pedido.ClienteId);

            //builder.Entity<Pedido>()
            //    .HasOne(pedido => pedido.Endereco)
            //    .WithMany(endereco => endereco.Pedidos)
            //    .HasForeignKey(pedido => pedido.EnderecoId);

            builder.Entity<ItemPedido>()
                .HasOne(itemPedido => itemPedido.Pedido)
                .WithMany(pedido => pedido.ItensPedido)
                .HasForeignKey(itemPedido => itemPedido.PedidoId);

            //builder.Entity<Pedido>() //apagar depois (só teste)
            //    .HasOne(pedido => pedido.ItemPedido)
            //    .WithMany(itemPedido => itemPedido.Pedidos)
            //    .HasForeignKey(pedido => pedido.ItemPedidoId);

            builder.Entity<ItemPedido>()
                .HasOne(itemPedido => itemPedido.Produto)
                .WithMany(produto => produto.ItensPedido)
                .HasForeignKey(itemPedido => itemPedido.ProdutoId);

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }  
    }
}
