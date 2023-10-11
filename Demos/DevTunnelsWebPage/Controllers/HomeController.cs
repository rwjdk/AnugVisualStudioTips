using DevTunnelsWebPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevTunnelsWebPage.Controllers;
public class HomeController : Controller
{
    private static List<string> _names = new List<string>();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        ViewBag.Names = _names;
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Names = _names;
        return View();
    }

    [HttpPost]
    public IActionResult Index(Participant p)
    {
        if (!_names.Contains(p.Name))
        {
            _names.Add(p.Name);
        }
        ViewBag.Names = _names;
        return View();
    }
    
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
