using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WInformRazil.Models;

namespace WInformRazil.DataAccess
{
    using Microsoft.EntityFrameworkCore;

    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "The Great Gatsby", AuthorName = "F. Scott Fitzgerald", PageCount = 180, Quantity = 5 },
                new Book { Id = 2, Name = "1984", AuthorName = "George Orwell", PageCount = 328, Quantity = 3 },
                new Book { Id = 3, Name = "To Kill a Mockingbird", AuthorName = "Harper Lee", PageCount = 281, Quantity = 4 },
                new Book { Id = 4, Name = "Pride and Prejudice", AuthorName = "Jane Austen", PageCount = 279, Quantity = 6 },
                new Book { Id = 5, Name = "Moby-Dick", AuthorName = "Herman Melville", PageCount = 635, Quantity = 2 },
                new Book { Id = 6, Name = "War and Peace", AuthorName = "Leo Tolstoy", PageCount = 1225, Quantity = 1 },
                new Book { Id = 7, Name = "The Odyssey", AuthorName = "Homer", PageCount = 541, Quantity = 4 },
                new Book { Id = 8, Name = "Ulysses", AuthorName = "James Joyce", PageCount = 730, Quantity = 3 },
                new Book { Id = 9, Name = "The Catcher in the Rye", AuthorName = "J.D. Salinger", PageCount = 277, Quantity = 5 },
                new Book { Id = 10, Name = "Brave New World", AuthorName = "Aldous Huxley", PageCount = 268, Quantity = 7 }
            );

            modelBuilder.Entity<Borrower>().HasData(
                new Borrower { Id = 1, Name = "Default Borrower" }
            );

            modelBuilder.Entity<Transaction>().HasData(
                new Transaction { Id = 1, BookId = 1, BorrowerId = 1, TakenQuantity=1 },
                new Transaction { Id = 2, BookId = 2, BorrowerId = 1, TakenQuantity = 1 },
                new Transaction { Id = 3, BookId = 3, BorrowerId = 1, TakenQuantity = 1 }
            );


            modelBuilder.Entity<Admin>().HasData(
              new Admin() { Id = 1, Login = "rz", Password = "rz" }
          );
        }

    }

}
