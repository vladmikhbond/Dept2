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
      public string Name_uk { set; get; }
      public string Name_ru { set; get; }
      public string Name_en { set; get; }
      [Required]
      public string Resume_uk { set; get; }
      public string Resume_ru { set; get; }
      public string Resume_en { set; get; }

      public int Rank { set; get; }          // 1-сотр  2-асс  3-преп  4-доц  5-проф      
      public string Link { set; get; }       // for httр://nure.ua/staff/Link
      public string ImageName { set; get; }  // for /pic/staff/ImageName
   }
}
