using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Postgre.Src.Models
{
   [Table("PEDIDOITEM", Schema = "public")]
   public class PedidoItem
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id { get; set; }

      [Required]
      public int Codigo { get; set; }

      [Required]
      [StringLength(10)]
      public string SKU { get; set; }

      public long CodigoBarra { get; set; }

      [Required]
      [StringLength(50)]
      public string Descricao { get; set; }

      [Required]
      public double Qtde { get; set; }

      public Guid PedidoId { get; set; }
      public Pedido Pedido { get; set; }
   }
}
