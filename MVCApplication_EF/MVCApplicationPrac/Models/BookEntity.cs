namespace MVCApplicationPrac.Models
{
    // BookEntity class representing the Book entity in the database
    // This class will be mapped to a database table by Entity Framework Core
    // Each property in this class corresponds to a column in the database table
    // The Id property is the primary key and will be auto-incremented
    // The Title, Author, and Price properties represent the book's title, author, and price respectively
    
    public class BookEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}