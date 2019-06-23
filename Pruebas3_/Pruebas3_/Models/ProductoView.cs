using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pruebas3_.Models
{
    public class ProductoView
    {
        
        public int IdProducto { get; set; }
        [DisplayName("Nombre Producto")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(30, ErrorMessage = "Introduzca máximo 30 caracteres")]
        public string NombreProducto { get; set; }
        [DisplayName("Precio")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1,600,ErrorMessage ="Introduzca un precio válido entre 1 y 600 soles")]
        [RegularExpression("[0-9]+", ErrorMessage = "Introduza un precio válido")]
        public Nullable<decimal> Precio { get; set; }
        [DisplayName("Descripcion")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50, ErrorMessage = "Introduzca máximo 50 caracteres")]
        public string Descripcion { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string ImagenProducto { get; set; }
        [DisplayName("Cantidad")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1,2000,ErrorMessage ="Introduzca una cantida válida entre 1 y 2000")]
        public Nullable<int> CantidadProducto { get; set; }
        public Nullable<int> Estado { get; set; }

        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedido { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression("(.*).(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$", ErrorMessage ="Debe subir un archivo de imagen válido")]
        public HttpPostedFileBase foto { get; set; }

    }
}