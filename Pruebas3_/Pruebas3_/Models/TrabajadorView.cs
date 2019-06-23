using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pruebas3_.Models
{
    public class TrabajadorView
    {
        public int IdTrabajador { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(20, ErrorMessage = "Introduzca máximo 20 caracteres")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Introduza un nombre válido")]
        public string Nombre { get; set; }
        [DisplayName("Apellidos")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(30, ErrorMessage = "Introduzca máximo 30 caracteres")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Introduza un apellido válido")]
        public string Apellidos { get; set; }
        [DisplayName("Dni")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(8, MinimumLength = 8, ErrorMessage ="El DNI debe tener máximo 8 digitos")]
        [RegularExpression("[0-9]+", ErrorMessage = "Introduza un DNI válido")]
        public string Dni { get; set; }
        [DisplayName("Edad")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(18, 100, ErrorMessage = "Introduzca una edad válida entre 18 y 100")]
        public Nullable<int> Edad { get; set; }
        public Nullable<int> Sexo { get; set; }
        public Nullable<int> Distrito { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Introduzca una cuenta de email válida")]
        public string Email { get; set; }
        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Su clave debe contener mínimo 6 caracteres y 10 como máximo")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(9, MinimumLength = 7)]
        [RegularExpression("[0-9]+", ErrorMessage = "Introduzca un número de telefono válido")]
        public string Telefono { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horarios> Horarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public IEnumerable<T_TABLAS> Combos { get; set; }
        public string LoginError { get; set; } 
    }
}