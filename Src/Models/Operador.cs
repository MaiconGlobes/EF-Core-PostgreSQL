using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Postgre.Src.Models
{
   [Table("OPERADOR", Schema = "public")]
   public class Operador : Pessoa
   {
   }
}
