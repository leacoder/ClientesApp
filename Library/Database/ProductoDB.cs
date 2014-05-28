using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Database
{
    public class ProductoDB
    {
        public ProductoDB()
        {
            
        }

       public List<Producto> FiveProducts()
       {
            List<Producto> listaProductos = new List<Producto>();
           Producto producto1 = new Producto(3,"Hecha de Madera","Mesa", 2);
           listaProductos.Add(new Producto(5, "Uso Comercial", "Escritorio", 1));
           listaProductos.Add(new Producto(1, "Uso Domestico", "Camara", 4));
           listaProductos.Add(new Producto(2, "Hecha de Vidrio", "Celular", 5));
           listaProductos.Add(new Producto(22, "Hecha de Metal", "Vaso", 10));
           return listaProductos;
       }
    }
}
