using Microsoft.AspNetCore.Mvc;
// using GoBarber.Models;

namespace GoBarber.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Client()
    {
        return View();
    }

    public IActionResult Barber()
    {
        return View();
    }

}
