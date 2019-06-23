using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pruebas3_.Models
{
    public class ReportesMant:IDisposable
    {

        GymNautilusEntities3 bd = new GymNautilusEntities3();

        public List<PlanMasSolicitado_Result> PlanesMasSolicitados()
        {
            return bd.PlanMasSolicitado().ToList();
        }

        public List<SuplementoMasVendido_Result> ArticuloMasVendido()
        {
            return bd.SuplementoMasVendido().ToList();
        }

        public List<Sp_ClientesMasPedidos_Result> ClientesMasPedidos()
        {
            return bd.Sp_ClientesMasPedidos().ToList();
        }

        public List<Sp_ReporteXFecha_Result> ReporteXFecha()
        {
            return bd.Sp_ReporteXFecha().ToList();
        }

        public List<Sp_ClasesPorInstructor_Result> ClasesPorInstructor()
        {
            return bd.Sp_ClasesPorInstructor().ToList();
        }

        public List<Sp_SusAceptadasMes_Result> SuscripcionesMes()
        {
            return bd.Sp_SusAceptadasMes().ToList();
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
        // ~ReportesMant() {
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