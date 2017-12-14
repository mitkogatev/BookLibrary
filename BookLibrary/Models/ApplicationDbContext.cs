namespace BookLibrary.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //public virtual DbSet<Book> Books { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<BookLibrary.Models.Book> Books { get; set; }

        //public System.Data.Entity.DbSet<BookLibrary.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}