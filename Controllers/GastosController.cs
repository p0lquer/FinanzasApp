using FinanzasApp.Context;
using FinanzasApp.Context.Servicios;
using FinanzasApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanzasApp.Controllers
{
    public class GastosController : Controller
    {
        public readonly IGastosService _gastosService;

        public GastosController(IGastosService gastosService)
        {
            _gastosService = gastosService;
        }

        public async Task<IActionResult> Index()
        {
            var expenses = await _gastosService.GetAll();
            return View(expenses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Gastos gastos)
        {
            if (ModelState.IsValid)
            {
                await _gastosService.Add(gastos);

                return RedirectToAction("Index");
            }
            return View(gastos);
        }
    }
}
