using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pruebas3_.Models;
using System.Web.UI;

namespace Pruebas3_.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ListarPedidos()
        {
            using (PedidosMant pm = new PedidosMant())
            {
                ViewBag.PedidosSinCancelar = pm.PedidosSinCancelar();
                ViewBag.PedidosCancelados = pm.PedidosCancelados();
                ViewBag.PedidosEliminados = pm.PedidosEliminados();
                return View();
            }
        }
        [HttpPost]
        public ActionResult ActualizarACancelado(FormCollection frm,Pedidos ped)
        {
            using (PedidosMant pm = new PedidosMant())
            {
                ped.IdPedidos =Convert.ToInt32(frm["cod"]);
                ped.Estado =21;
                ped.IdTrabajador = Convert.ToInt32(Session["IdTrabajador"]);
                pm.ActualizarACancelados(ped);
                return RedirectToAction("ListarPedidos","Pedidos");
            }
        }
        [HttpPost]
        public ActionResult ActualizarAEliminado(FormCollection frm,Pedidos ped)
        {
            using (PedidosMant pm = new PedidosMant())
            {
                ped.IdPedidos = Convert.ToInt32(frm["cod"]);
                ped.Estado = 22;
                ped.IdTrabajador = Convert.ToInt32(Session["IdTrabajador"]);
                pm.ActualizarAEliminados(ped);
                return RedirectToAction("ListarPedidos", "Pedidos");
            }
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ListarDetalle(Pedidos ped)
        {
            using (PedidosMant pm = new PedidosMant())
            {
                ped.IdPedidos = Convert.ToInt32(Session["cod"]) ;
                ViewBag.Detalles = pm.VerDetalle(ped);
                return View();
            }

        }
        [HttpPost]
        public ActionResult VerDetalle(FormCollection frm)
        {
            using (PedidosMant pm = new PedidosMant())
            {
                int cod = Convert.ToInt32(frm["cod"]);
                Session["cod"] = cod;
                return RedirectToAction("ListarDetalle","Pedidos");
            }
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult MisPedidos(Cliente cli)
        {
            using (PedidosMant pm = new PedidosMant())
            {
                cli.IdCliente = Convert.ToInt32(Session["IdCliente"]);
                ViewBag.VerMisPedidos = pm.MisPedidos(cli);
                return View();
            }
        }

    }
}