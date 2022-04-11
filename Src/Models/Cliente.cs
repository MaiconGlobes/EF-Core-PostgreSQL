using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Postgre.Src.Models
{
   [Table("CLIENTE", Schema = "public")]
   public class Cliente : Pessoa
   {
   }
}
