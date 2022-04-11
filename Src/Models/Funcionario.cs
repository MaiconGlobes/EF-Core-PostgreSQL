using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Postgre.Src.Models
{
   [Table("FUNCIONARIO", Schema = "public")]
   public class Funcionario : Pessoa
   {
   }
}
