using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pruebas3_.Models
{
    public class HorarioMant:IDisposable
    {
        GymNautilusEntities3 bd = new GymNautilusEntities3();

        public List<Sp_ListarHorariosXDia_Result> HorarioLunes()
        {
            return bd.Sp_ListarHorariosXDia("Lunes", "27").ToList();
        }

        public int ActualizarHorario(Horarios hor)
        {
            var hors = bd.Horarios.Find(hor.IdHorario);
            if (hors != null)
            {
                hors.Instructor = hor.Instructor;
                hors.IdClases = hor.IdClases;
                hors.IdTrabajador = hor.IdTrabajador;
                return bd.SaveChanges();
            }
            else
            {
                throw new Exception("No existe el horario");
            }
        }

        public List<Sp_ListarClase_Result> Clases()
        {
            return bd.Sp_ListarClase().ToList();
        }

        public Sp_BuscarHorario_Result BuscarHorario(int idhorario)
        {
            return bd.Sp_BuscarHorario(idhorario).SingleOrDefault();
        }

        public List<Sp_ListarHorariosXDia_Result> HorarioMartes()
        {
            return bd.Sp_ListarHorariosXDia("Martes","27").ToList();
        }

        public List<Sp_ListarHorariosXDia_Result> HorarioMiercoles()
        {
            return bd.Sp_ListarHorariosXDia("Miercoles", "27").ToList();
        }

        public List<Sp_ListarHorariosXDia_Result> HorarioJueves()
        {
            return bd.Sp_ListarHorariosXDia("Jueves", "27").ToList();
        }

        public List<Sp_ListarHorariosXDia_Result> HorarioViernes()
        {
            return bd.Sp_ListarHorariosXDia("Viernes", "27").ToList();
        }

        public List<Sp_ListarHorariosXDia_Result> HorarioSabado()
        {
            return bd.Sp_ListarHorariosXDia("Sabado", "27").ToList();
        }

        public List<Sp_ListarHorariosXDia_Result> HorarioDomingo()
        {
            return bd.Sp_ListarHorariosXDia("Domingo", "27").ToList();
        }

        public int ActualizarEstadoHorario(Horarios hor)
        {
            return bd.Sp_ActualizarEstadoHorario(hor.Estado,hor.IdHorario);
        }

        public List<Sp_ListarHorariosXDia_Result> HorariosNoDisponibles()
        {
            return bd.Sp_ListarHorariosXDia("","28").ToList();
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
        // ~HorarioMant() {
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