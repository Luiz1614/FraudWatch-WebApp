using FraudWatch.Application.DTOs;
using FraudWatch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FraudWatch_WebApp.Presentation.Controllers;

public class DentistaController : Controller
{
    private readonly IDentistaApplicationService _dentistaApplicationService;

    public DentistaController(IDentistaApplicationService dentistaApplicationService)
    {
        _dentistaApplicationService = dentistaApplicationService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var dentistas = _dentistaApplicationService.GetAll();

        return View(dentistas);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(DentistaDTO dentistaDTO)
    {
        if (ModelState.IsValid)
        {
            _dentistaApplicationService.Add(dentistaDTO);

            return RedirectToAction("Index");
        }

        return View(dentistaDTO);
    }


}
