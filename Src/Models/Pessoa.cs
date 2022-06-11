using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Postgre.Src.Models
{
   abstract public class Pessoa
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id { get; set; }

      [Required]
      [MaxLength(45)]
      public string Nome { get; set; }

      public long Telefone { get; set; }

      public long Celular { get; set; }

      [MaxLength(120)]
      [EmailAddress]
      public string Email { get; set; }
   }
}
