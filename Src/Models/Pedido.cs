using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Postgre.Src.Models
{
   [Table("PEDIDO", Schema = "public")]
   public class Pedido
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public Guid Id { get; set; }

      [Required]
      public int Numero { get; set; }

      [Required]
      public DateTime Data { get; set; }

      [Required]
      public short Status { get; set; }

      public int ClienteId { get; set; }
      public Cliente Cliente { get; set; }

      public List<PedidoItem> ItensPedido { get; set; }
   }
}
