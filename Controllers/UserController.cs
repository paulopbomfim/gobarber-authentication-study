using Microsoft.AspNetCore.Mvc;
// using GoBarber.Models;

namespace GoBarber.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}