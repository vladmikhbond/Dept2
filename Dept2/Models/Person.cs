using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dept2.Models
{
    public enum Rank
    {
        None,
        Support = 1,
        Assistant = 2,
        Teacher = 3,
        Docent = 4,
        Professor = 5,
    }

    [Table("Persons")]
    public class Person
    {
        public int Id { set; get; }
        [Required]
        public string Name_uk { set; get; }
        public string Name_ru { set; get; }
        public string Name_en { set; get; }
        [Required]
        public string Post_uk { set; get; }
        public string Post_ru { set; get; }
        public string Post_en { set; get; }

        public string Resume_uk { set; get; }
        public string Resume_ru { set; get; }
        public string Resume_en { set; get; }

        public Rank Rank { set; get; }          // 1-сотр  2-асс  3-преп  4-доц  5-проф      
        public string Link { set; get; }       // for httр://nure.ua/staff/Link
        public string ImageName { set; get; }  // for /pic/staff/ImageName
    }
}
