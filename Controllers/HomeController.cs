using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp_02_recetify.Models;

namespace tp_02_recetify.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
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

    [HttpPost]
    public IActionResult respuesta(receta Receta){
        ViewBag.Receta = Receta.DeterminarPlato();
        ViewBag.Tiempo = Receta.calcularTiempo();
        ViewBag.Dificultad = Receta.determinarDificultad();
        ViewBag.Edad = Receta.calcularEdad();
        ViewBag.Persona = Receta.cocinaPara;
        ViewBag.fechaDeNacimiento = Receta.fechaDeNacimiento.ToShortDateString();
        ViewBag.nombre = Receta.name;
        return View();
        
    }
}
