using Microsoft.EntityFrameworkCore;

namespace Hammam_library.Models
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        { }

        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Books> Books { get; set; } = null!;
        public DbSet<Authors> Authors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    UserID = 1,
                    Name = "Administrator",
                    Username = "admin",
                    Password = "admin",
                }
            );


            modelBuilder.Entity<Authors>().HasData(
                new Authors { AuthorID = 1, AuthorName = "Hammam" },
                new Authors { AuthorID = 2, AuthorName = "Davinci" },
                new Authors { AuthorID = 3, AuthorName = "John" }
            );

            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    BookID = 1,
                    Title = "Web Programming",
                    Edition = "First",
                    AuthorID = 1,

                },
                new Books
                {
                    BookID = 2,
                    Title = "Mona lisa",
                    Edition = "Second",
                    AuthorID = 2,
                },
                new Books
                {
                    BookID = 3,
                    Title = "Doe",
                    Edition = "Third",
                    AuthorID = 3,
                }
            );
        }
    }
}
