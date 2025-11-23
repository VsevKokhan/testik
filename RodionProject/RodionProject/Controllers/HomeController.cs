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
        var promos = new List<Promo>
        {
            new Promo { ImageUrl = "/images/photo1.png", Text = "🎁 2 грузчика бесплатно при заказе от 5 часов" },
            new Promo { ImageUrl = "/images/photo2.jpg", Text = "🔥 Скидка 10% на первое обращение" },
            new Promo { ImageUrl = "/images/photo3.png", Text = "🚚 Бесплатная подача при заказе от 5 часов" }
        };

        return View(promos);
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