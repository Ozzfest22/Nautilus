//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pruebas3_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horarios
    {
        public int IdHorario { get; set; }
        public string Instructor { get; set; }
        public string Hora { get; set; }
        public string Dia { get; set; }
        public Nullable<int> IdClases { get; set; }
        public Nullable<int> IdTrabajador { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual Clases Clases { get; set; }
        public virtual Trabajador Trabajador { get; set; }
    }
}