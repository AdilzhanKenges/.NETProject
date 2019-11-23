using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMart.Models
{
    public class Year
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "year")]
        public int year { get; set; }
        public IList<Book> Book { get; set; }
    }
}
