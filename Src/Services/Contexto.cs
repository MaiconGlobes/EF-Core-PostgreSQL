using EF_Core_Postgre.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Postgre.Src.Services
{
   public class Contexto : DbContext
   {
      public DbSet<Cliente> CLIENTE { get; set; }
      public DbSet<Operador> OPERADOR { get; set; }
      public DbSet<Funcionario> FUNCIONARIO { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=postgres;Username=postgres;Password=root");
   }
}
