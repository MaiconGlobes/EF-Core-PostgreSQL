using EF_Core_Postgre.Src.Services;
using System;

namespace EF_Core_Postgre.Src.Controllers
{
   public class PedidoController
   {
      private static PedidoController FInstancia;
      public static PedidoController Instancia()
      {
         if (FInstancia == null)
            FInstancia = new PedidoController();

         return FInstancia;
      }

      public void InserirPedido()
      {
         bool PedidoInserido = PedidoServices.Instancia().Inserir();

         if (PedidoInserido)
         {
            Console.WriteLine("Registro inserido com sucesso.\n\n");
         }
         else
         {
            Console.WriteLine("Erro: Não há clientes no banco p/ vincular com pedido!\n\n");
         }
      }

      public void ListarPedidos()
      {
         Console.WriteLine("Listando pedidos...");

         var Pedidos = PedidoServices.Instancia().Listar();

         if (Pedidos.Count > 0)
         {
            foreach (var item in Pedidos)
            {
               Console.WriteLine($"Nr:{item.Numero} - Data:{item.Data.Date.ToString("dd-mm-yyyy")}");
            }

            Console.WriteLine("\n");
         }
         else
         {
            Console.WriteLine("Não há registros p/ listar\n\n");
         }
      }
      
      public void DeletarPedidos()
      {
         bool pedidosDeletados = PedidoServices.Instancia().Deletar();

         if (pedidosDeletados)
         {
            Console.WriteLine("Registros deletados com sucesso.\n\n");
         }
         else
         {
            Console.WriteLine("Não houve deleção de registros.\n\n");
         }
      }
   }
}
