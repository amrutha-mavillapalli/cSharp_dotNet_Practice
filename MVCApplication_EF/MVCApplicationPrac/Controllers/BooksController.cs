using Microsoft.AspNetCore.Mvc;
using MVCApplicationPrac.Models;
using MVCApplicationPrac.Data;
namespace MVCApplicationPrac.Controllers;

public class BooksController : Controller
{
    private ApplicationDbContext _db;

    // Injecting the ApplicationDbContext through constructor
    public BooksController(ApplicationDbContext db)
    {
        _db = db;
    }

    // all the public  methods of controller class are called as action methods
    // Index action to list all books, IActionResult method for Index view will return Index.cshtml file
    //view method will look for Index.cshtml file in Views/Books folder and return that file
    public IActionResult Index()
    {
        // Fetching all books from the database
        var books = _db.BookEntity.ToList();
        return View(books);
    }

    // Create action to show the form for adding a new book
    // IActionResult method for Create view will return Create.cshtml file
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    // Action method to handle form submission for creating a new book
    // IActionResult method for Create view will return Create.cshtml file
    public IActionResult CreateBook(BookEntity book)
    {
        // Server-side validation
        _db.BookEntity.Add(book);
        _db.SaveChanges(); // Save changes to the database
        return RedirectToAction(nameof(Index));

    }

    public IActionResult Edit(int id)
    {
        var book = _db.BookEntity.Find(id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book);
    }

    [HttpPost]
    public IActionResult EditBook(BookEntity book)
    {

        var existing = _db.BookEntity.Find(book.Id);
        if (existing == null)
        {
            return NotFound();
        }

        // update only the editable properties
        existing.Title = book.Title;
        existing.Author = book.Author;
        existing.Price = book.Price;
        // ...copy other editable fields if any...

        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var book = _db.BookEntity.Find(id);
        if (book == null)
        {
            return NotFound();
        }
        _db.BookEntity.Remove(book);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }


}