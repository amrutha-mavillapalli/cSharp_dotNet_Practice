namespace MVCApplicationPrac.Data;

using Microsoft.EntityFrameworkCore;
using MVCApplicationPrac.Models;

// ApplicationDbContext class inheriting from DbContext
// This class represents the session with the database and allows querying and saving data
// DbContext is part of Entity Framework Core, which is an Object-Relational Mapper (ORM) for .NET 
//and allows developers to work with a database using .NET objects
public class ApplicationDbContext : DbContext
{ // Constructor accepting DbContextOptions and passing it to the base class constructor
  // DbContextOptions carries configuration information such as the database provider (e.g., SQL Server, SQLite) and connection string
  // This constructor is used by the dependency injection system to provide the necessary configuration for the DbContext
  //base(options) calls the constructor of the base class (DbContext) with the provided options
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    // DbSet<BookEntity> property represents the Books table in the database
    // Each DbSet corresponds to a table in the database and allows CRUD operations on that table
    public DbSet<BookEntity> BookEntity { get; set; }

}
