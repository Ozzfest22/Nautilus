using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pruebas3_.Models
{
    public class TrabajadorMant:IDisposable
    {

        GymNautilusEntities3 bd = new GymNautilusEntities3();

        public int InsertarTrabajador(TrabajadorView tra)
        {
            return bd.Sp_InsertarTrabajador(tra.Nombre,tra.Apellidos,tra.Dni,tra.Edad,tra.Sexo,tra.Distrito,tra.FechaNacimiento
                ,tra.Email,tra.Contrasena,tra.Telefono);
        }

        public Sp_IngresoTrabajador_Result IngresoTrabajador(string Email, string Contrasena)
        {
            return bd.Sp_IngresoTrabajador(Email,Contrasena).FirstOrDefault();
        }

        public List<SP_Listar_Combos_Result> ListarSexo()
        {
            return bd.SP_Listar_Combos("2").ToList();
        }

        public List<SP_Listar_Combos_Result> ListarDistrito()
        {
            return bd.SP_Listar_Combos("3").ToList();
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
        // ~TrabajadorMant() {
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