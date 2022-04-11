using EF_Core_Postgre.Src.Models;
using EF_Core_Postgre.Src.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Core_Postgre.Src.Controllers
{
   public class Processamento
   {
      private static Processamento FInstancia;
      private Contexto FContexto;
      private Guid FId;
      private string FNome;

      /// <summary>
      /// Méododo estático p/ instanciação da classe com Design Pattern Singleton.
      /// </summary>
      /// <returns>Instância da classe</returns>
      public static Processamento Instancia()
      {
         if (FInstancia == null)
            FInstancia = new Processamento();

         return FInstancia;
      }

      /// <summary>
      /// Método construtor da classe.
      /// </summary>
      private Processamento()
      {
         FContexto = new Contexto();
      }

      /// <summary>
      /// Método privado p/ buscar IDs dos registros à serem manipulados
      /// </summary>
      /// <returns>True/False</returns>
      private Boolean ListarRegistros()
      {
         Console.WriteLine("Listando dados...");

         var items = FContexto.CLIENTE.OrderBy(x => x.Id).ToList();

         if (items.Count > 0)
         {
            foreach (var item in items)
            {
               Console.WriteLine($"{item.Id} - {item.Nome}");
            }

            Console.WriteLine("\n");

            return true;
         }
         else
         {
            Console.WriteLine("Não há registros p/ listar\n\n");
            return false;
         }
      }

      public void InserirRegistro()
      {
         Console.WriteLine("Digite um nome:");

         FNome = Console.ReadLine().ToString();

         var cliente = new Cliente 
         { 
            Nome = FNome,
            Email = $"{FNome}@entityframework.com",
         };

         FContexto.CLIENTE.Add(cliente);
         FContexto.SaveChanges();

         Console.WriteLine("Registro inserido com sucesso.\n\n");
      }

      public void AtualizarRegistro()
      {
         if (!ListarRegistros())
            return;

         Console.WriteLine("Digite o Id do registro que deseja atualizar:");

         FId = Guid.Parse(Console.ReadLine());

         Console.WriteLine("Digite o novo nome:");

         FNome = Console.ReadLine().ToString();

         var cliente = FContexto.CLIENTE.Single(b => b.Id == FId);

         cliente.Nome = FNome;

         FContexto.CLIENTE.Update(cliente);
         FContexto.SaveChanges();

         Console.WriteLine("Registro atualizado com sucesso.\n\n");

      }
      public void DeletarRegistro()
      {
         if (!ListarRegistros())
            return;

         Console.WriteLine("Digite o Id do registro que deseja deletar:");

         FId = Guid.Parse(Console.ReadLine());

         var cliente = FContexto.CLIENTE.Single(b => b.Id == FId);

         FContexto.CLIENTE.Remove(cliente);
         FContexto.SaveChanges();

         Console.WriteLine("Registro deletado com sucesso.\n\n");
      }
   }
}
