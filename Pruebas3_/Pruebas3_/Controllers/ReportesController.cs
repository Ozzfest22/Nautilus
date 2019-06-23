using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pruebas3_.Models;
using System.Web.UI;

namespace Pruebas3_.Controllers
{
    public class ReportesController : Controller
    {
        // GET: Reportes
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ListarReportes()
        {
            using (ReportesMant rm = new ReportesMant())
            {
                ViewBag.PlanesSolicitados = rm.PlanesMasSolicitados();
                ViewBag.ArtMasVendidos = rm.ArticuloMasVendido();
                ViewBag.CliMasPedidos = rm.ClientesMasPedidos();
                ViewBag.ReporteFecha = rm.ReporteXFecha();
                ViewBag.ClasesInstructor = rm.ClasesPorInstructor();
                ViewBag.SuscripcionesMes = rm.SuscripcionesMes();
                return View();
            }
        }

    }
}