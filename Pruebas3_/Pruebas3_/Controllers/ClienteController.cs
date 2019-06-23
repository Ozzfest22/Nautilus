using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web;
using System.Web.Mvc;
using Pruebas3_.Models;
using Pruebas3_.Controllers;


namespace Pruebas3_.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegistrarCliente()
        {
            using (ClienteMant cm = new ClienteMant())
            {
                ViewBag.IdSexo = new SelectList(cm.ListarSexo1(), "T_IDCAMPO", "T_NOMBRE");

                ViewBag.IdDistrito = new SelectList(cm.ListarDistrito1(), "T_IDCAMPO", "T_NOMBRE");
                return View("RegistrarCliente");
            }
        }

        [HttpPost]
        public ActionResult RegistrarCliente(ClienteView cli)
        {
            using (ClienteMant cm = new ClienteMant())
            {
                cm.InsertarCliente(cli);
                return RedirectToAction("ConfirmacionCliRegistrado","Cliente");
            }
        }

        public ActionResult ConfirmacionCliRegistrado()
        {
            return View();
        }


        /*public ActionResult Login(Cliente cli)
        {
            using (ClienteMant cm = new ClienteMant())
            {
                var it = cm.LoginCliente();
                if (it == null)
                {
                    cli.LoginError = "Email o contraseña incorrecta";
                }
                else
                {
                    Session["IdCliente"] = cli.IdCliente;
                    Session["Email"] = cli.Email;
                    return RedirectToAction("Index","Home");
                }
            }
            return View();
        }*/

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Cliente cli)
        {
            using (GymNautilusEntities3 db = new GymNautilusEntities3())
            {
                var userDetails = db.Cliente.Where(x => x.Email == cli.Email && x.Contrasena == cli.Contrasena).FirstOrDefault();
                if (userDetails == null)
                {
                    cli.LoginError = "Email o contraseña incorrecta";
                    return View("Login", cli); 
                }
                else
                {
                    Session["IdCliente"] = userDetails.IdCliente;
                    Session["EmailCli"] = userDetails.Email;
                    Session["NombreCli"] = userDetails.Nombre;
                    Session["TelefCli"] = userDetails.Telefono;
                    return RedirectToAction("Index","Home");
                }
            }
        }

        public ActionResult CerrarSesion()
        {
            int IdCliente = (int)Session["IdCliente"];
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ListarClientes()
        {
            using (ClienteMant cm = new ClienteMant())
            {
                ViewBag.ClientesActivos = cm.ListarClienteActivo();
                ViewBag.ClientesEliminados = cm.ListarClienteEliminado();
                return View();
            }
        }
        [HttpPost]
        public ActionResult ActualizarAEliminado(FormCollection frm, Cliente cli)
        {
            using (ClienteMant cm = new ClienteMant())
            {
                cli.IdCliente =Convert.ToInt32(frm["cod"]);
                cli.Estado =19;
                cm.ActualizarAEliminado(cli);
                return RedirectToAction("ListarClientes","Cliente");
            }
        }

    }
}