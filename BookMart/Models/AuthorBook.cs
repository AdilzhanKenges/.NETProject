using System.ComponentModel.DataAnnotations;

namespace BookMart.Models
{
    public class AuthorBook
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}