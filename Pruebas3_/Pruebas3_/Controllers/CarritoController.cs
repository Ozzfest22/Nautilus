using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pruebas3_.Models;
using System.Web.UI;

namespace Pruebas3_.Controllers
{
    public class CarritoController : Controller
    {
        GymNautilusEntities3 bd = new GymNautilusEntities3();
        // GET: Carrito
        
            [HttpPost]
        public JsonResult AgregaCarrito(int id,int cantidad)
        {
           
            if (Session["carrito"] == null)
            {
                Math.Abs(cantidad);
                List<CarritoCompras> compras = new List<CarritoCompras>();
                compras.Add(new CarritoCompras(bd.Productos.Find(id), Math.Abs(cantidad)));
                Session["carrito"] = compras;
            }
            else
            {
                List<CarritoCompras> compras = (List<CarritoCompras>)Session["carrito"];
                int IndexExistente = getIndex(id);
                if (IndexExistente == -1)
                {
                    compras.Add(new CarritoCompras(bd.Productos.Find(id), Math.Abs(cantidad)));
                }
                else
                {
                    compras[IndexExistente].Cantidad+=Math.Abs(cantidad);
                }
                Session["carrito"] = compras;
            }

            return Json(new { response = true }, JsonRequestBehavior.AllowGet);

        }
        //public ActionResult AgregaCarrito(int id)
        //{
        //    if (Session["carrito"] == null)
        //    {
        //        List<CarritoCompras> compras = new List<CarritoCompras>();
        //        compras.Add(new CarritoCompras(bd.Productos.Find(id),1));
        //        Session["carrito"] = compras;
        //    }
        //    else
        //    {
        //        List<CarritoCompras> compras = (List<CarritoCompras>)Session["carrito"];
        //        int IndexExistente = getIndex(id);
        //        if (IndexExistente == -1)
        //        {
        //            compras.Add(new CarritoCompras(bd.Productos.Find(id), 1));
        //        }
        //        else
        //        {
        //            compras[IndexExistente].Cantidad++;
        //        }
        //        Session["carrito"] = compras;
        //    }

        //    return View();

        //}

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult AgregaCarrito()
        {
            using (PedidosMant pm = new PedidosMant())
            {
                ViewBag.MetodoPago = new SelectList(pm.ListarMetPago(),"T_IDCAMPO","T_NOMBRE");
                return View();
            }
        }

        
        public ActionResult Eliminar(int id)
        {
            using (PedidosMant pm = new PedidosMant())
            {
                ViewBag.MetodoPago = new SelectList(pm.ListarMetPago(), "T_IDCAMPO", "T_NOMBRE");
                
            }
            List<CarritoCompras> compras = (List<CarritoCompras>)Session["carrito"];
            compras.RemoveAt(getIndex(id));
            return View("AgregaCarrito");
        }

        [HttpPost]
        public ActionResult FinalizarCompra(FormCollection frm)
        {
            List<CarritoCompras> compras = (List<CarritoCompras>)Session["carrito"];
            if (compras != null && compras.Count > 0)
            {
                //using (PedidosMant pm = new PedidosMant())
                //{
                //    ped.IdCliente = Convert.ToInt32(Session["IdCliente"]);
                //    ped.IdTrabajador = 1;
                //    pm.InsertarPedido(ped);


                //    foreach (var item in Session["Carrito"] as List<Pruebas3_.Models.CarritoCompras>)
                //    {
                //        DetallePedido det = new DetallePedido();
                //        det.MontoTotal = item.Productos.Precio * item.Cantidad;
                //        det.Precio = item.Productos.Precio;
                //        det.Cantidad = item.Cantidad;
                //        det.IdPedidos = 1;
                //        det.IdProducto = item.Productos.IdProducto;
                //        try
                //        {
                //            pm.InsertarDetallePedido(det);

                //        }
                //        catch (Exception e) { throw e; }
                //    }
                //    bd.SaveChanges();
                //    Session["carrito"] = new List<CarritoCompras>();

                //}
                Pedidos ped = new Pedidos();
                ped.IdCliente = Convert.ToInt32(Session["IdCliente"]);
                ped.IdTrabajador = 1;
                ped.Estado = 20;
                ped.MetodoPago = Convert.ToInt32 (frm["ddl"]);
                ped.FechaRegistro = DateTime.Now.Date;
                ped.DetallePedido = (from Productos in compras
                                     select new DetallePedido
                                     {
                                         MontoTotal = Math.Abs(Productos.Cantidad) * Productos.Productos.Precio,
                                         Precio = Productos.Productos.Precio,
                                         Cantidad = Math.Abs(Productos.Cantidad),
                                         IdProducto = Productos.Productos.IdProducto  
                                     }).ToList();
                bd.Pedidos.Add(ped);
                bd.SaveChanges();            
                Session["carrito"] = new List<CarritoCompras>();
            }
            return RedirectToAction("Index","Home");
        }


        private int getIndex(int id)
        {
            List<CarritoCompras> compras = (List<CarritoCompras>)Session["carrito"];
            for (int i = 0; i < compras.Count; i++)
            {
                if (compras[i].Productos.IdProducto == id)
                    return i;
            }

            return -1;
        }

    }
}