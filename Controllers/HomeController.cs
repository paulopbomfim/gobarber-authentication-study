using GoBarber.Models;
using GoBarber.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GoBarber.Controllers;

public class HomeController : Controller
{
    private readonly ClientsRepository _repository;

    public HomeController(ClientsRepository repository)
    {
        this._repository = repository;
    }

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
    
    // [HttpPost]
    // public IActionResult CreateClient(Client client)
    // {

    // }

    public IActionResult PasswordRecovery()
    {
        return View();
    }

    public IActionResult EmailSentSuccessfully()
    {
        return View();
    }

}
