using Microsoft.EntityFrameworkCore;

namespace MyContacts.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
              new Category { CategoryId = 1, Name = "Family" },
              new Category { CategoryId = 2, Name = "Friend" },
              new Category { CategoryId = 3, Name = "Work" }
            );

            modelBuilder.Entity<Contact>().HasData(
              new Contact
                  {
                     ContactId = 1,
                     FirstName = "Jack",
                     LastName = "Chris",
                     PhoneNumber = "123-456-7890",
                     Email = "chris@gmail.com",
                     CategoryId = 1,
                     },
              new Contact
              {
                  ContactId = 2,
                  FirstName = "Matt",
                  LastName = "Pratt",
                  PhoneNumber = "123-456-7890",
                  Email = "matt@gmail.com",
                  CategoryId = 2,
              },
              new Contact
              {
                  ContactId = 3,
                  FirstName = "Ben",
                  LastName = "Blake",
                  PhoneNumber = "123-456-7890",
                  Email = "ben@gmail.com",
                  CategoryId = 3,
              }
         );
        }
    }   
   
}
