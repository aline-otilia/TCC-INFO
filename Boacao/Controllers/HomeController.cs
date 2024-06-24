using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Boacao.Models;
using Boacao.Data;

namespace Boacao.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Sobre()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Service()
    {
        var produtos = _context.Produtos.ToList();
        return View(produtos);
    }

     [HttpGet]
    public IActionResult Service1()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Service2()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Service3()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Service4()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Service5()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Gallery()
    {
        return View();
    }

    public IActionResult Events()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Team()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Donate()
    {
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
