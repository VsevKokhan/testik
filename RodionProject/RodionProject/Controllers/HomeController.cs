using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RodionProject.Models;

namespace RodionProject.Controllers;

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

    [HttpPost]
    public ActionResult Calculate(int truckCount, int workingHours)
    {
        // Выполняем расчет по формуле: количество грузичков + количество часов работы.
        int calculationResult = truckCount  + workingHours;

        // Передаем результат во View с помощью ViewBag.
        ViewBag.CalculationResult = calculationResult;
        ViewBag.TruckCount = truckCount;
        ViewBag.WorkingHours = workingHours;

        // Можно вернуть представление с результатом, например, "CalculateResult".
        return View("Index");
    }

}