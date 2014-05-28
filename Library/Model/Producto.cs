using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Producto
    {
        int cantidad;
        String descripcion;
        String nombre;
        int categoria;

        public Producto(int cantidad, String descripcion, String nombre, int categoria)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.nombre = nombre;
            this.categoria = categoria;
        }
    }
}
