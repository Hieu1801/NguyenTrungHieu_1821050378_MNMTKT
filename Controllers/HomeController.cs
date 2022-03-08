using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MaNguonMo.Models;
using MaNguonMo.Models.Process;

namespace MaNguonMo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    AutoGenerateKey atoKey = new AutoGenerateKey();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string abc = atoKey.SinhMaTuDong("STD001");
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

