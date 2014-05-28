using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace Library.Models
{
    public class ProductosViewModel
    {
        public List<Producto> productos { get; set; }
        public String Categoria { get; set; }

        public ProductosViewModel()
        {
            this.Categoria = "Juguetes";
            this.productos = new List<Producto>();
        }

        public void addProduct(Producto producto)
        {
            productos.Add(producto);
        }
    }
}