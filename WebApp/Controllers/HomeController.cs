using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models;
public class HomeController : Controller{
    public IActionResult Index()
    {
        return View();
    }
}