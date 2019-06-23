using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pruebas3_.Models
{
    public class PedidosMant:IDisposable
    {
        GymNautilusEntities3 bd = new GymNautilusEntities3();

        public int InsertarPedido(PedidoView ped)
        {
            return bd.Sp_InsertarPedido(ped.MetodoPago, ped.IdCliente);
        }

        public int InsertarDetallePedido(DetallePedido det)
        {
            return bd.Sp_InsertarDetallePedido(det.MontoTotal,det.Precio,det.Cantidad,det.IdPedidos,det.IdProducto);
        }

        public List<SP_Listar_Combos_Result> ListarMetPago()
        {
            return bd.SP_Listar_Combos("1").ToList();
        }

        public List<Sp_ListarPedidosPorEstados_Result> PedidosSinCancelar()
        {
            return bd.Sp_ListarPedidosPorEstados("20").ToList();
        }

        public List<Sp_ListarPedidosPorEstados_Result> PedidosCancelados()
        {
            return bd.Sp_ListarPedidosPorEstados("21").ToList();
        }

        public List<Sp_ListarPedidosPorEstados_Result> PedidosEliminados()
        {
            return bd.Sp_ListarPedidosPorEstados("22").ToList();
        }

        public int ActualizarACancelados(Pedidos ped)
        {
            return bd.Sp_ActualizarEstadoPedido(ped.IdPedidos,ped.Estado,ped.IdTrabajador);
        }

        public int ActualizarAEliminados(Pedidos ped)
        {
            return bd.Sp_ActualizarEstadoPedido(ped.IdPedidos, ped.Estado,ped.IdTrabajador);
        }

        public List<Sp_VerDetalle_Result> VerDetalle(Pedidos ped)
        {
            return bd.Sp_VerDetalle(ped.IdPedidos).ToList();
        }

        public List<Sp_ListarMisPedidos_Result> MisPedidos(Cliente cli)
        {
            return bd.Sp_ListarMisPedidos(cli.IdCliente).ToList();
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
        // ~PedidosMant() {
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