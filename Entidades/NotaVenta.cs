﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NotaVenta
    {
        public int NotaVentaId { get; set; }
        public int NroNotaVenta { get; set; }
        public DateTime Fecha { get; set; }

        public List<LineaNotaVenta> ListaLineaNotaVenta { get; set; }
        public List<Producto> ListaProductos { get; set; }
        public Cliente Cliente { get; set; }
    }
}
