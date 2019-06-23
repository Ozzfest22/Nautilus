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
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.DetallePedido = new HashSet<DetallePedido>();
        }
    
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public string ImagenProducto { get; set; }
        public Nullable<int> CantidadProducto { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
