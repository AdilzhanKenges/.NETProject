using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMart.Models
{
    public class Book
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "name")]
        public string name { get; set; }
        public Year year { get; set; }
        public Company company { get; set; }
        public IList<AuthorBook> authorBooks { get; set; }
    }
}
