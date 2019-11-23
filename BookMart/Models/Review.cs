using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMart.Models
{
    public class Review
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "content")]
        public string Content { get; set; }

        public User User { get; set; }
        public DateTime publishedDate { get; set; }
    }
}
