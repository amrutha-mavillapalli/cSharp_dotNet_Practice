using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApplicationPrac.Models;

namespace MVCApplicationPrac.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // all the public  methods of controller class are called as action methods 
    //ActionResult method for Privacy view will return Privacy.cshtml file
    public IActionResult Privacy()
    {
        return View(); 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
