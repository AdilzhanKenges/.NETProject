using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMart.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "Fullname")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role role { get; set; }
        public IList<Review> Review { get; set; }
    }
}
