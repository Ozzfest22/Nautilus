using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pruebas3_.Models;
using System.Web.UI;

namespace Pruebas3_.Controllers
{
    public class HorarioController : Controller
    {
        // GET: Horario
        public ActionResult Horarios()
        {
            return View();
        }

        public ActionResult ListarHorarios()
        {
            using (HorarioMant hm = new HorarioMant())
            {
                ViewBag.ListarLunes = hm.HorarioLunes();
                ViewBag.ListarMartes = hm.HorarioMartes();
                ViewBag.ListarMiercoles = hm.HorarioMiercoles();
                ViewBag.ListarJueves = hm.HorarioJueves();
                ViewBag.ListarViernes = hm.HorarioViernes();
                ViewBag.ListarSabado = hm.HorarioSabado();
                ViewBag.ListarDomingo = hm.HorarioDomingo();
                return View();
            }
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ListarHorariosParaEditar()
        {
            using (HorarioMant hm = new HorarioMant())
            {
                ViewBag.ListarLunes = hm.HorarioLunes();
                ViewBag.ListarMartes = hm.HorarioMartes();
                ViewBag.ListarMiercoles = hm.HorarioMiercoles();
                ViewBag.ListarJueves = hm.HorarioJueves();
                ViewBag.ListarViernes = hm.HorarioViernes();
                ViewBag.ListarSabado = hm.HorarioSabado();
                ViewBag.ListarDomingo = hm.HorarioDomingo();
                ViewBag.ListarNoDisponibles = hm.HorariosNoDisponibles();
                return View();
            }
        }

        [HttpGet]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult EditarHorarios(int id)
        {
            using (HorarioMant hm = new HorarioMant())
            {
                
                Sp_BuscarHorario_Result hora = hm.BuscarHorario(id);
                ViewBag.IdClases = new SelectList(hm.Clases(), "IdClases", "NombreClase",hora.IdClases);
                return View(hora);
            }

        }

        [HttpPost]
        public ActionResult EditarHorarios(Horarios hor)
        {
            using (HorarioMant hm = new HorarioMant())
            {
                hor.IdTrabajador = Convert.ToInt32(Session["IdTrabajador"]);
                hm.ActualizarHorario(hor);
                return RedirectToAction("ListarHorariosParaEditar");
            }
        }

        [HttpPost]
        public ActionResult ActualizarNoDisponible(FormCollection frm, Horarios hor)
        {
            using (HorarioMant hm = new HorarioMant())
            {
                hor.IdHorario = Convert.ToInt32(frm["cod"]);
                hor.Estado =28;
                hm.ActualizarEstadoHorario(hor);
                return RedirectToAction("ListarHorariosParaEditar");
            }
        }

        [HttpPost]
        public ActionResult ActualizarDisponible(FormCollection frm, Horarios hor)
        {
            using (HorarioMant hm = new HorarioMant())
            {
                hor.IdHorario = Convert.ToInt32(frm["cod"]);
                hor.Estado = 27;
                hm.ActualizarEstadoHorario(hor);
                return RedirectToAction("ListarHorariosParaEditar");
            }
        }

    }
    
}