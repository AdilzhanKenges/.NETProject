using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMart.Models
{
    public class Author
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "firstName")]
        public string firstName { get; set; }
        [Display(Name ="lastName")]
        public string lastName { get; set; }
        [Display(Name = "Birthday")]
        public DateTime birthday { get; set; }
        public IList<AuthorBook> authorBooks { get; set; }

    }
}
