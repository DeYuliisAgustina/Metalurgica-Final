﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Stock { get; set; }
    }
}
