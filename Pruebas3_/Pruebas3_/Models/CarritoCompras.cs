using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Pruebas3_.Models
{
    public class CarritoCompras
    {
        private Productos _productos;
        private int _cantidad;

        public Productos Productos
        {
            get
            {
                return _productos;
            }

            set
            {
                _productos = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }

        public CarritoCompras()
        {

        }

        public CarritoCompras(Productos producto, int cantidad)
        {
            this.Productos = producto;
            this.Cantidad = cantidad;
        }

    }
}