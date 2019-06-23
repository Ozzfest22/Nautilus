using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pruebas3_.Models
{
    public class PedidoView
    {
        public int IdPedidos { get; set; }
        public Nullable<int> MetodoPago { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdTrabajador { get; set; }

        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedido { get; set; }
        public virtual Trabajador Trabajador { get; set; }

        public IEnumerable<T_TABLAS> Combos { get; set; }
    }
}