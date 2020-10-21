using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dept2.Models
{
   [Table("News")]
   public class News
   {
      public int Id { set; get; }
      public DateTime Date { set; get; }
      [MaxLength(100)]
      public string Heading { set; get; }
      [Required]
      [MaxLength(1000)]
      public string Body { set; get; }
      public string ImageName { set; get; }
   }
}
