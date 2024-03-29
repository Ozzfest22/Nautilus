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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public partial class Trabajador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trabajador()
        {
            this.Horarios = new HashSet<Horarios>();
            this.Pedidos = new HashSet<Pedidos>();
        }
    
        public int IdTrabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public Nullable<int> Edad { get; set; }
        public Nullable<int> Sexo { get; set; }
        public Nullable<int> Distrito { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Introduzca una cuenta de email válida")]
        public string Email { get; set; }
        [DisplayName("Contraseña")]
        [Required(ErrorMessage ="Este campo es requerido")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horarios> Horarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public string LoginError { get; set; }
    }
}
