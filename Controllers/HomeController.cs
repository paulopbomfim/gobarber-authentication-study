using Microsoft.AspNetCore.Mvc;
// using GoBarber.Models;

namespace GoBarber.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
