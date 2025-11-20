using Microsoft.AspNetCore.Mvc;

namespace AuthFlow.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}