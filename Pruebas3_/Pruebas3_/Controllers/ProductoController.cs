using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data.Sql;
using Pruebas3_.Models;
using Pruebas3_.Controllers;
using System.IO;
using Pruebas3_.Classes;
using System.Web.UI;

namespace Pruebas3_.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult InsertarProducto()
        {
            using (ProductoMant pm = new ProductoMant())
            {
                ViewBag.IdCategoria = new SelectList(pm.ListarCategoria(),"IdCategoria","Descripcion");
                return View();
            }

        }

        [HttpPost]
        public ActionResult InsertarProducto(ProductoView pro)
        {
    
            using (ProductoMant pm = new ProductoMant())
            {
                var img = string.Empty;
                var folder = "~/Content/Imagenes";

                if (pro.foto != null)
                {
                    img = FilesHelper.SubirFoto(pro.foto, folder);
                    img = string.Format("{0}/{1}", folder, img);
                }
                pro.ImagenProducto = img;
                pm.InsertarProducto(pro);
                
            }

            return RedirectToAction("ConfirmarcionProRegistrado","Producto");

        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ConfirmarcionProRegistrado()
        {
            return View();
        }

        public ActionResult ListarProductos()
        {
            using (ProductoMant pm = new ProductoMant())
            {
                ViewBag.ListarProduc = pm.ListarProductos();
                return View();
            }
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ListarProductos2()
        {
            using (ProductoMant pm = new ProductoMant())
            {
                ViewBag.ListarArtic = pm.ListarProductos2();
                return View();
            }
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ListarProductosEditar()
        {
            using (ProductoMant pm = new ProductoMant())
            {
                ViewBag.PlanesEditar = pm.ListarProductos();
                ViewBag.ArticulosEditar = pm.ListarProductos2();
                ViewBag.PlanesEliminados = pm.ListarPlanesEliminados();
                ViewBag.ArticulosEliminados = pm.ListarProductosEliminados();

                return View();
            }
        }
        [HttpGet]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult EditarPro(int id)
        {
            using (ProductoMant pm = new ProductoMant())
            {
                Sp_BuscarProducto_Result producto = pm.BuscarProducto(id);
                ViewBag.IdCategoria = new SelectList(pm.ListarCategoria(), "IdCategoria", "Descripcion", producto.IdCategoria);
                return View(producto);
            }
        }

        [HttpPost]
        public ActionResult EditarPro(Productos pro)
        {
            using (ProductoMant pm = new ProductoMant())
            {
                pm.ActualizarProducto(pro);
                return RedirectToAction("ListarProductosEditar");
            }
        }

        [HttpPost]
        public ActionResult ActualizarEstadoProducto(FormCollection frm, Productos pro)
        {
            using (ProductoMant pm = new ProductoMant())
            {
                pro.IdProducto = Convert.ToInt32(frm["cod"]);
                pro.Estado = 26;
                pm.ActualizarEstadoPro(pro);
                return RedirectToAction("ListarProductosEditar");
            }
        }

        [HttpPost]
        public ActionResult RegresarEstadoProducto(FormCollection frm, Productos pro)
        {
            using (ProductoMant pm = new ProductoMant())
            {
                pro.IdProducto = Convert.ToInt32(frm["cod"]);
                pro.Estado = 25;
                pm.ActualizarEstadoPro(pro);
                return RedirectToAction("ListarProductosEditar");
            }
        }

        [HttpPost]
        public ActionResult InsertarSus(string nom)
        {
            using (ProductoMant pm = new ProductoMant())
            {
                Planes plan = new Planes();
                plan.Nombre = Convert.ToString(Session["NombreCli"]);
                plan.Email = Convert.ToString(Session["EmailCli"]);
                plan.Telefono = Convert.ToString(Session["TelefCli"]);
                plan.FechaSuscripcion = DateTime.Now.Date;
                plan.Planes1 =nom;

                pm.SuscribirsePlan(plan);
                var redirecturl = new UrlHelper(Request.RequestContext).Action("Index","Home");
                return Json(new { response=true, Url=redirecturl }, JsonRequestBehavior.AllowGet);

            }


        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ListarSus()
        {
            using (ProductoMant pm = new ProductoMant())
            {
                ViewBag.SuscripXProcesar = pm.ListarSuscrip_PorProcesar();
                ViewBag.SuscripAceptadas = pm.ListarSuscrip_Aceptadas();
                ViewBag.SuscripRechazadas = pm.ListarSuscrip_Rechazadas();
                return View();
            }
        }

        [HttpPost]
        public ActionResult ActualizarSusc_Aceptada(FormCollection frm, Planes pla)
        {
            using (ProductoMant pm = new ProductoMant())
            {
                pla.Codigo = Convert.ToInt32(frm["cod"]);
                pla.Estado =24;
                pla.Cod_Trabajador = Convert.ToInt32(Session["IdTrabajador"]);
                pm.ActualizarAAceptadas(pla);
                return RedirectToAction("ListarSus","Producto");
            }
        }

        [HttpPost]
        public ActionResult ActualizarSusc_Rechazada(FormCollection frm, Planes pla)
        {
            using (ProductoMant pm = new ProductoMant())
            {
                pla.Codigo = Convert.ToInt32(frm["cod"]);
                pla.Estado = 25;
                pla.Cod_Trabajador = Convert.ToInt32(Session["IdTrabajador"]);
                pm.ActualizarARechazadas(pla);
                return RedirectToAction("ListarSus", "Producto");
            }
        }

    }
}