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

        public ProductosViewModel(List<Producto> listaProductos, String categoria)
        {
            this.Categoria = categoria;
            this.productos = listaProductos;
        }
    }
}