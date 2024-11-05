using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NotaCompra
    {
        public int NotaCompraId { get; set; }
        public int NroNotaCompra { get; set; }
        public DateTime Fecha { get; set; }

        public Cliente Cliente { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<Producto> ListaProductos { get; set; }
    }
}
