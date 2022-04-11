using EF_Core_Postgre.Src.Controllers;
using System;

namespace EF_Core_Postgre
{
   internal class Program
   {
      private static byte FOpcoesTeclado;
      static void Main(string[] args)
      {
         do
         {
            Console.WriteLine("Selecione a opção desejada:\n1-INSERIR\n2-ATUALIZAR\n3-DELETAR");

            FOpcoesTeclado = byte.Parse(Console.ReadLine());

            switch (FOpcoesTeclado)
            {
               case 1:
                  Processamento.Instancia().InserirRegistro();
                  break;
               case 2:
                  Processamento.Instancia().AtualizarRegistro();
                  break;
               case 3:
                  Processamento.Instancia().DeletarRegistro();
                  break;
               default:
                  break;
            }

         } while (FOpcoesTeclado < 4);

      }
   }
}
