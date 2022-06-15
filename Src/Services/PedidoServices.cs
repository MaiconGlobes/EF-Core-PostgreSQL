using EF_Core_Postgre.Src.Models;
using System.Collections.Generic;
using System.Linq;

namespace EF_Core_Postgre.Src.Services
{
   public class PedidoServices
   {
      private static PedidoServices FInstancia;

      public static PedidoServices Instancia()
      {
         if (FInstancia == null)
            FInstancia = new PedidoServices();

         return FInstancia;
      }

      public List<Pedido> Listar()
      {
         using (var Contexto = new Contexto())
         {
            var Pedidos = Contexto.PEDIDO.OrderBy(x => x.Id).ToList();

            return Pedidos;
         }
      }

      public bool Inserir()
      {
         using (var Contexto = new Contexto())
         {
            var Cliente = ClienteServices.Instancia().Listar();

            if (Cliente.Count > 0)
            {
               var pedido = new Pedido
               {
                  Numero = 1234,
                  ClienteId = Cliente.First().Id, /*Pega qualquer Id de cliente*/
                  Data = System.DateTime.Now.Date,
                  Status = 1
               };

               Contexto.PEDIDO.Add(pedido);

               Contexto.SaveChanges();

               return true;
            }

            return false;
         }
      }

      public bool Deletar()
      {
         using (var Contexto = new Contexto())
         {
            var pedidos = Contexto.PEDIDO.ToList();

            foreach (var Pedido in pedidos)
            {
               Contexto.PEDIDO.Remove(Pedido);
            }

            return (Contexto.SaveChanges() > 0);
         }
      }
   }
}
