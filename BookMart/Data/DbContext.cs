using BookMart.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMart.Data
{
    public class DBContext : IdentityDbContext<User>
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }

        public DBContext() { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(p => p.role).WithMany(i => i.User);
            modelBuilder.Entity<AuthorBook>().HasKey(sca => new { sca.AuthorId, sca.BookId });
            modelBuilder.Entity<Book>().HasOne(p => p.year).WithMany(i => i.Book);
            modelBuilder.Entity<Book>().HasOne(p => p.company).WithMany(i => i.Book);
            modelBuilder.Entity<Review>().HasOne(p => p.User).WithMany(i => i.Review);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Year> Years { get; set; }
    }
}
