using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pruebas3_.Controllers;

namespace Pruebas3_.Models
{
    public class ProductoMant:IDisposable
    {
        GymNautilusEntities3 bd = new GymNautilusEntities3();
        
        public int InsertarProducto(ProductoView pro)
        {
            return bd.Sp_InsertarProducto(pro.NombreProducto, pro.Precio, pro.Descripcion, pro.IdCategoria, 
                pro.ImagenProducto, pro.CantidadProducto);
        }

        public List<ListarSusc_PorEstado_Result> ListarSuscrip_PorProcesar()
        {
            return bd.ListarSusc_PorEstado("23").ToList();
        }

        public List<ListarSusc_PorEstado_Result> ListarSuscrip_Aceptadas()
        {
            return bd.ListarSusc_PorEstado("24").ToList();
        }

        public List<ListarSusc_PorEstado_Result> ListarSuscrip_Rechazadas()
        {
            return bd.ListarSusc_PorEstado("25").ToList();
        }

        public int SuscribirsePlan(Planes plan)
        {
            return bd.Suscripcion(plan.Nombre,plan.Email,plan.Telefono,plan.Planes1);
        }
        public int ActualizarStock(int cantidad,int idproducto)
        {
            return bd.Sp_ActualizarStock(cantidad,idproducto);
        }

        public int ActualizarProducto(Productos pro)
        {
            var prods = bd.Productos.Find(pro.IdProducto);
            if (prods != null)
            {
                prods.NombreProducto = pro.NombreProducto;
                prods.Precio = pro.Precio;
                prods.Descripcion = pro.Descripcion;
                prods.IdCategoria = pro.IdCategoria;
                prods.CantidadProducto = pro.CantidadProducto;
                return bd.SaveChanges();
            }
            else { throw new Exception("No existe el producto"); }
        }

        public Sp_BuscarProducto_Result BuscarProducto(int idproducto)
        {
            return bd.Sp_BuscarProducto(idproducto).SingleOrDefault();
        }

        public List<Sp_ListarCategoria_Result> ListarCategoria()
        {
            return bd.Sp_ListarCategoria().ToList();
        }

        public List<Sp_ListarCategoriaProductoXEstado_Result> ListarProductos()
        {
            return bd.Sp_ListarCategoriaProductoXEstado("Planes","25").ToList();
        }

        public List<Sp_ListarCategoriaProductoXEstado_Result> ListarProductos2()
        {
            return bd.Sp_ListarCategoriaProductoXEstado("Articulos","25").ToList();
        }

        public List<Sp_ListarCategoriaProductoXEstado_Result> ListarPlanesEliminados()
        {
            return bd.Sp_ListarCategoriaProductoXEstado("Planes", "26").ToList();
        }

        public List<Sp_ListarCategoriaProductoXEstado_Result> ListarProductosEliminados()
        {
            return bd.Sp_ListarCategoriaProductoXEstado("Articulos", "26").ToList();
        }

        public int ActualizarAAceptadas(Planes pla)
        {
            return bd.ActualizarEstadoSuscripcion(pla.Codigo,pla.Estado,pla.Cod_Trabajador);
        }

        public int ActualizarARechazadas(Planes pla)
        {
            return bd.ActualizarEstadoSuscripcion(pla.Codigo, pla.Estado, pla.Cod_Trabajador);
        }

        public int ActualizarEstadoPro(Productos pro)
        {
            return bd.Sp_ActualizarEstadoProducto(pro.Estado,pro.IdProducto);
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar llamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: elimine el estado administrado (objetos administrados).
                }

                // TODO: libere los recursos no administrados (objetos no administrados) y reemplace el siguiente finalizador.
                // TODO: configure los campos grandes en nulos.

                disposedValue = true;
            }
        }

        // TODO: reemplace un finalizador solo si el anterior Dispose(bool disposing) tiene código para liberar los recursos no administrados.
        // ~ProductoMant() {
        //   // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
        //   Dispose(false);
        // }

        // Este código se agrega para implementar correctamente el patrón descartable.
        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
            Dispose(true);
            // TODO: quite la marca de comentario de la siguiente línea si el finalizador se ha reemplazado antes.
             GC.SuppressFinalize(this);
        }
        #endregion

    }
}