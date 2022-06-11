using EF_Core_Postgre.Src.Models;
using System.Collections.Generic;
using System.Linq;

namespace EF_Core_Postgre.Src.Services
{
   public class ClienteServices
   {
      private static ClienteServices FInstancia;

      public static ClienteServices Instancia()
      {
         if (FInstancia == null)
            FInstancia = new ClienteServices();

         return FInstancia;
      }

      public List<Cliente> Listar()
      {
         using (var Contexto = new Contexto())
         {
            var clientes = Contexto.CLIENTE.OrderBy(x => x.Id).ToList();

            return clientes;
         }
      }

      public void Inserir(string ANomeCliente)
      {
         using (var Contexto = new Contexto())
         {
            var cliente = new Cliente
            {
               Nome = ANomeCliente,
               Email = $"{ANomeCliente}@entityframework.com",
               Telefone = 1935353535,
               Celular = 19999999999,
            };

            Contexto.CLIENTE.Add(cliente);

            Contexto.SaveChanges();
         }
      }

      public bool Deletar()
      {
         using (var Contexto = new Contexto())
         {
            var clientes = Contexto.CLIENTE.ToList();

            foreach (var cliente in clientes)
            {
               Contexto.CLIENTE.Remove(cliente);
            }

            return (Contexto.SaveChanges() > 0);
         }
      }
   }
}
