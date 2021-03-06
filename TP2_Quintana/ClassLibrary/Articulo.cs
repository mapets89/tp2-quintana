﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca IdMarca { get; set; }
        public Categoria IdCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public int Alta { get; set; }

    }
}
