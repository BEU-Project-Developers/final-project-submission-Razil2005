﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WInformRazil.DataAccess;

#nullable disable

namespace WInformRazil.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WInformRazil.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "rz",
                            Password = "rz"
                        });
                });

            modelBuilder.Entity("WInformRazil.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorName = "F. Scott Fitzgerald",
                            Name = "The Great Gatsby",
                            PageCount = 180,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            AuthorName = "George Orwell",
                            Name = "1984",
                            PageCount = 328,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 3,
                            AuthorName = "Harper Lee",
                            Name = "To Kill a Mockingbird",
                            PageCount = 281,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 4,
                            AuthorName = "Jane Austen",
                            Name = "Pride and Prejudice",
                            PageCount = 279,
                            Quantity = 6
                        },
                        new
                        {
                            Id = 5,
                            AuthorName = "Herman Melville",
                            Name = "Moby-Dick",
                            PageCount = 635,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 6,
                            AuthorName = "Leo Tolstoy",
                            Name = "War and Peace",
                            PageCount = 1225,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 7,
                            AuthorName = "Homer",
                            Name = "The Odyssey",
                            PageCount = 541,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 8,
                            AuthorName = "James Joyce",
                            Name = "Ulysses",
                            PageCount = 730,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 9,
                            AuthorName = "J.D. Salinger",
                            Name = "The Catcher in the Rye",
                            PageCount = 277,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 10,
                            AuthorName = "Aldous Huxley",
                            Name = "Brave New World",
                            PageCount = 268,
                            Quantity = 7
                        });
                });

            modelBuilder.Entity("WInformRazil.Models.Borrower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Borrowers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default Borrower"
                        });
                });

            modelBuilder.Entity("WInformRazil.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("BorrowerId")
                        .HasColumnType("int");

                    b.Property<int>("TakenQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("BorrowerId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            BorrowerId = 1,
                            TakenQuantity = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            BorrowerId = 1,
                            TakenQuantity = 1
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            BorrowerId = 1,
                            TakenQuantity = 1
                        });
                });

            modelBuilder.Entity("WInformRazil.Models.Transaction", b =>
                {
                    b.HasOne("WInformRazil.Models.Book", "Book")
                        .WithMany("Transactions")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WInformRazil.Models.Borrower", "Borrower")
                        .WithMany("Transactions")
                        .HasForeignKey("BorrowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Borrower");
                });

            modelBuilder.Entity("WInformRazil.Models.Book", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("WInformRazil.Models.Borrower", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
