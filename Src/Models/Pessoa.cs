using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Postgre.Src.Models
{
   [Table("PESSOA", Schema = "public")]
   abstract public class Pessoa
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public Guid Id { get; set; }

      [Required]
      [MinLength(3)]
      [MaxLength(45)]
      public string Nome { get; set; }

      [MinLength(10)]
      [MaxLength(10)]
      public string Telefone { get; set; }

      [MaxLength(11)]
      public string Celular { get; set; }

      [MinLength(3)]
      [MaxLength(120)]
      [EmailAddress]
      public string Email { get; set; }
   }
}
