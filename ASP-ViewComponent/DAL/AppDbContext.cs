using ASP_ViewComponent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAndGenreRelation> Relations { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; } 
        public DbSet<User> Users { get; set; }
        
       

    }
}
