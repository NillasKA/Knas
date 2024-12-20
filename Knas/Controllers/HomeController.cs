using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace Knas.Controllers;

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

    public IActionResult Menu()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/menukort.pdf");
        return PhysicalFile(filePath, "application/pdf");
    }
}