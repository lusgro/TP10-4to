using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }

    public List<Temporada> ObtenerTemporadas(int idSerie)
    {
        return BD.ObtenerTemporadas(idSerie);
    }

    public List<Actor> ObtenerActores(int idSerie)
    {
        return BD.ObtenerActores(idSerie);
    }

    public Serie ObtenerInfo(int idSerie)
    {
        return BD.ObtenerInfo(idSerie);
    }
}
