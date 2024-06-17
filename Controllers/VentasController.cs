using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinal;

public class VentasController : Controller
{
    public VentasController()
    {
    }

    public IActionResult VentasPunto()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CalculoTotal (int cantidadT, int cantidadE)
    {
        VentasModel cantidad = new VentasModel();

        cantidad.CantidadEntrada = cantidadE;
        cantidad.CantidadTotal = 500;

        



        return View();
    }
}