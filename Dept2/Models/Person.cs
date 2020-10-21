using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dept2.Models
{
   [Table("Persons")]
   public class Person
   {
      public int Id { set; get; }
      [Required]
      [MaxLength(100)]
      public string Name { set; get; }
      [MaxLength(1000)]
      public string Resume { set; get; }
   }
}
