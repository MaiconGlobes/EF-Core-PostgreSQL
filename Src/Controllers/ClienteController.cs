using EF_Core_Postgre.Src.Services;
using System;

namespace EF_Core_Postgre.Src.Controllers
{
   public class ClienteController
   {
      private static ClienteController FInstancia;

      /// <summary>
      /// Méododo estático p/ instanciação da classe com Design Pattern Singleton.
      /// </summary>
      /// <returns>Instância da classe</returns>
      public static ClienteController Instancia()
      {
         if (FInstancia == null)
            FInstancia = new ClienteController();

         return FInstancia;
      }

      /// <summary>
      /// Método p/ inserir registros de novos CLientes
      /// </summary>
      public void InserirCliente()
      {
         Console.WriteLine("Digite um nome:");

         string nome = Console.ReadLine().ToString();

         ClienteServices.Instancia().Inserir(nome);

         Console.WriteLine("Registro inserido com sucesso.\n\n");
      }

      /// <summary>
      /// Método p/ listar todos os registros de CLientes
      /// </summary>
      public void ListarClientes()
      {
         Console.WriteLine("Listando dados...");

         var clientes = ClienteServices.Instancia().Listar();

         if (clientes.Count > 0)
         {
            foreach (var item in clientes)
            {
               Console.WriteLine($"{item.Id} - {item.Nome}");
            }

            Console.WriteLine("\n");
         }
         else
         {
            Console.WriteLine("Não há registros p/ listar\n\n");
         }
      }

      /// <summary>
      /// Método p/ deletar todos os registros de CLientes
      /// </summary>
      public void DeletarClientes()
      {
         bool clientesDeletados = ClienteServices.Instancia().Deletar();

         if (clientesDeletados)
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
