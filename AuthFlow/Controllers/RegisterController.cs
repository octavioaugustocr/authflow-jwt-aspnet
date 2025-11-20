using Microsoft.AspNetCore.Mvc;

namespace AuthFlow.Controllers;

public class RegisterController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}