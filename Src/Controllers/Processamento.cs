using System;

namespace EF_Core_Postgre.Src.Controllers
{
   public class Processamento
   {
      private static Processamento FInstancia;
      private static readonly byte FOpcoesTeclado;

      public static Processamento Instancia()
      {
         if (FInstancia == null)
            FInstancia = new Processamento();

         return FInstancia;
      }

      public void Executar()
      {
         do
         {
            Console.WriteLine("Selecione a opção desejada:\n1-Clientes\n2-Pedidos");

            byte FOpcoesTeclado = byte.Parse(Console.ReadLine());

            switch (FOpcoesTeclado)
            {
               case 1:
                  this.ExecutarCliente();
                  break;
               case 2:
                  this.ExecutarPedido();
                  break;
               default:
                  Console.Clear();
                  break;
            }

         } while (FOpcoesTeclado < 3);
      }

      private void ExecutarCliente()
      {
         do
         {
            Console.WriteLine("Selecione a opção desejada:\n1-Inserir Cliente\n2-Listar Clientes\n3-Deletar Clientes\n0-Retornar");

            byte FOpcoesTeclado = byte.Parse(Console.ReadLine());

            switch (FOpcoesTeclado)
            {
               case 1:
                  ClienteController.Instancia().InserirCliente();
                  break;
               case 2:
                  ClienteController.Instancia().ListarClientes();
                  break;
               case 3:
                  ClienteController.Instancia().DeletarClientes();
                  break;
               case 0:
                  Console.Clear();
                  return;
            }

         } while (FOpcoesTeclado < 4);
      }

      private void ExecutarPedido()
      {
         do
         {
            Console.WriteLine("Selecione a opção desejada:\n1-Inserir Pedido\n2-Listar Pedidos\n3-Deletar Pedidos\n0-Retornar");

            byte FOpcoesTeclado = byte.Parse(Console.ReadLine());

            switch (FOpcoesTeclado)
            {
               case 1:
                  PedidoController.Instancia().InserirPedido();
                  break;
               case 2:
                  PedidoController.Instancia().ListarPedidos();
                  break;
               case 3:
                  PedidoController.Instancia().DeletarPedidos();
                  break;
               case 0:
                  Console.Clear();
                  return;
            }

         } while (FOpcoesTeclado < 4);
      }
   }
}
