using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pruebas3_.Models
{
    public class ClienteMant:IDisposable
    {

        GymNautilusEntities3 bd = new GymNautilusEntities3();
        
        public int InsertarCliente(ClienteView cli)
        {
            return bd.Sp_InsertarCliente(cli.Nombre, cli.Apellidos, cli.Dni, cli.Edad, cli.Sexo, cli.Distrito, cli.FechaNacimiento,
                cli.Email, cli.Contrasena, cli.Telefono);
        }

        public Sp_IngresoCliente_Result LoginCliente(string Email, string Contrasena)
        {
            return bd.Sp_IngresoCliente(Email,Contrasena).FirstOrDefault();
        }

        //public List<Sp_ListarSexo_Result> ListarSexo()
        //{
        //    return bd.Sp_ListarSexo().ToList();
        //}

        //public List<Sp_ListarDistrito_Result> ListarDistrito()
        //{
        //    return bd.Sp_ListarDistrito().ToList();
        //}
        public List<SP_Listar_Combos_Result> ListarSexo1()
        {
            return bd.SP_Listar_Combos("2").ToList();
        }
        public List<SP_Listar_Combos_Result> ListarDistrito1()
        {
            return bd.SP_Listar_Combos("3").ToList();
        }

        public List<Sp_ListarCliente_Result> ListarClienteActivo()
        {
            return bd.Sp_ListarCliente("17").ToList();
        }

        public List<Sp_ListarCliente_Result> ListarClienteEliminado()
        {
            return bd.Sp_ListarCliente("19").ToList();
        }

        public int ActualizarAEliminado(Cliente cli)
        {
            return bd.Sp_ActualizarCliente(cli.IdCliente,cli.Estado);
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
        // ~ClienteMant() {
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