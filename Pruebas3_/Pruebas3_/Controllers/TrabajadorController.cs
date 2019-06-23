using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pruebas3_.Models;
using Pruebas3_.Controllers;
using System.Web.UI;

namespace Pruebas3_.Controllers
{
    public class TrabajadorController : Controller
    {
        // GET: Trabajador
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult RegistrarTrabajador()
        {
            using (TrabajadorMant tm = new TrabajadorMant())
            {
                ViewBag.IdSexo1 = new SelectList(tm.ListarSexo(), "T_IDCAMPO", "T_NOMBRE");

                ViewBag.IdDistrito1 = new SelectList(tm.ListarDistrito(), "T_IDCAMPO", "T_NOMBRE");
                return View("RegistrarTrabajador");
            }
        }
        
        [HttpPost]
        public ActionResult RegistrarTrabajador(TrabajadorView tra)
        {
            using (TrabajadorMant tm = new TrabajadorMant())
            {
                tm.InsertarTrabajador(tra);
                return RedirectToAction("ConfirmacionTraRegistrado","Trabajador");
            }
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ConfirmacionTraRegistrado()
        {
            return View();
        }

        public ActionResult LoginTrabajador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginTrabajador(Trabajador tra)
        {
            using (GymNautilusEntities3 db = new GymNautilusEntities3())
            {
                var userDetails = db.Trabajador.Where(x => x.Email == tra.Email && x.Contrasena == tra.Contrasena).FirstOrDefault();
                if (userDetails == null)
                {
                    tra.LoginError = "Email o contraseña incorrecta";
                    return View("LoginTrabajador", tra);
                }
                else
                {
                    Session["IdTrabajador"] = userDetails.IdTrabajador;
                    Session["EmailTra"] = userDetails.Email;
                    Session["NombreTra"] = userDetails.Nombre;
                    return RedirectToAction("InsertarProducto", "Producto");
                }
            }
        }

        public ActionResult CerrarSesionTrabajador()
        {
            int IdTrabajador = (int)Session["IdTrabajador"];
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }



    }
}