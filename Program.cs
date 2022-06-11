using EF_Core_Postgre.Src.Controllers;
using System;

namespace EF_Core_Postgre
{
   internal class Program
   {
      private static byte FOpcoesTeclado;
      static void Main(string[] args)
      {
         Processamento.Instancia().Executar();
      }
   }
}
