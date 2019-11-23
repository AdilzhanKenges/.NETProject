using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMart.Models
{
    public class Company
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "name")]
        public string name { get; set; }
        public IList<Book> Book { get; set; }
    }
}
