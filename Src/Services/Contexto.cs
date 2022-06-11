using EF_Core_Postgre.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Postgre.Src.Services
{
   public class Contexto : DbContext
   {
      public DbSet<Cliente> CLIENTE { get; set; }
      public DbSet<Pedido> PEDIDO { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Cliente)
            .WithMany(b => b.Pedidos)
            .HasForeignKey(p => p.ClienteId);

         modelBuilder.Entity<PedidoItem>()
            .HasOne(p => p.Pedido)
            .WithMany(b => b.ItensPedido)
            .HasForeignKey(p => p.PedidoId);
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=postgres;Username=postgres;Password=root");
   }
}
