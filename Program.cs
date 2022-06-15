using EF_Core_Postgre.Src.Controllers;

namespace EF_Core_Postgre
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Processamento.Instancia().Executar();
      }
   }
}
