using FraudWatch.Application.DTOs;
using FraudWatch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FraudWatch_WebApp.Presentation.Controllers;

public class AnalistaController : Controller
{
    private readonly IAnalistaApplicationService _analistaApplicationService;

    public AnalistaController(IAnalistaApplicationService analistaApplicationService)
    {
        _analistaApplicationService = analistaApplicationService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var analistas = _analistaApplicationService.GetAll();

        return View(analistas);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(AnalistaDTO analistaDTO)
    {
        if (ModelState.IsValid)
        {
            _analistaApplicationService.Add(analistaDTO);

            return RedirectToAction("Index");
        }

        return View(analistaDTO);
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        var analista = _analistaApplicationService.GetById(id);

        return View(analista);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var analista = _analistaApplicationService.GetById(id);

        return View(analista);
    }

}
